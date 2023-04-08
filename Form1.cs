using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace WVR_Glove_Configurator
{
    public partial class Form1 : Form
    {
        private string[] serialPorts;
        private string currentPath;
        private string toolPath;
        private string gloveSettingsPath;
        private Dictionary<string, Object> dictSettings;

        private EsptoolHandler esptoolHandler;
        private Mk_SpiffsHandler mk_SpiffsHandler;

        public Form1()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeSettings();
        }

        private void InitializeProperty()
        {
            currentPath = Directory.GetCurrentDirectory();
            toolPath = currentPath + "\\tools";
            gloveSettingsPath = toolPath + "\\data";
            serialPorts = SerialPort.GetPortNames();
            foreach (var port in serialPorts)
            {
                cmb_SerialPorts.Items.Add(port);
            }
            cmb_ImuDataType.Items.Add("eu");
            cmb_ImuDataType.Items.Add("quat");
            cmb_Contype.Items.Add("wired");
            cmb_Contype.Items.Add("wireless");
        }

        private void InitializeSettings()
        {
            string jsonString = File.ReadAllText(gloveSettingsPath + "\\settings.json");
            dictSettings = JsonSerializer.Deserialize<Dictionary<string, Object>>(jsonString);
            ValidateSettings();
        }
        private void ValidateSettings()
        {
            JsonElement je_imu_state = (JsonElement) dictSettings["imu_state"];
            JsonElement je_imu_data = (JsonElement)dictSettings["imu_data"];
            JsonElement je_iconType = (JsonElement)dictSettings["conType"];
            JsonElement je_collector_addr = (JsonElement)dictSettings["collector_addr"];
            JsonElement je_onboot_servo = (JsonElement)dictSettings["onboot_servo"];

            int imuState = je_imu_state.GetInt32();
            cmb_ImuDataType.SelectedItem = je_imu_data.GetString();
            txt_MacAddr.Text = je_collector_addr.GetString();
            cmb_Contype.SelectedItem = je_iconType.GetString();
            int onboot_servo = je_onboot_servo.GetInt32();

            _ = imuState == 1 ? cb_ImuOn.Checked = true : cb_ImuOn.Checked = false;
            _ = onboot_servo == 1 ? cb_ServoCheck.Checked = true : cb_ServoCheck.Checked = false;


        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            txt_Log.Clear();
            if (cmb_SerialPorts.Text != string.Empty && txt_baundrate.Text != string.Empty)
            {
               
                if( saveSettings())
                {
                    mk_SpiffsHandler = new Mk_SpiffsHandler(this.toolPath);
                    mk_SpiffsHandler.eventHandlerPassInt += new EventHandlerPassInt(updateTxtlbl);

                    esptoolHandler = new EsptoolHandler(cmb_SerialPorts.Text, Int32.Parse(txt_baundrate.Text), toolPath);
                    esptoolHandler.eventHandlerPassInt += new EventHandlerPassInt(updateTxtlbl);

                    mk_SpiffsHandler.eventHandlerPassBool += new EventHandlerPassBool(StartEspTool);

                    var mk_SpiffsHandlerThreadParameters = new ThreadStart(delegate { mk_SpiffsHandler.makeBin(); });
                    var mk_SpiffsHandlerThread = new System.Threading.Thread(mk_SpiffsHandlerThreadParameters);
                    mk_SpiffsHandlerThread.Start();
                }
                else
                {
                    txt_Log.AppendText("Settings are not beeing uploaded !\r\n");
                }
            }
            if(cmb_SerialPorts.Text == string.Empty)
            {
                txt_Log.AppendText("Invalid upload parameter :\r\n");
                txt_Log.AppendText("COM Port is selected \r\n");
            }
            if (txt_baundrate.Text == string.Empty)
            {
                txt_Log.AppendText("Invalid upload parameter :\r\n");
                txt_Log.AppendText("Baundrate is not set \r\n");
            }
        }

        private void updateTxtlbl(object sender, EventArgs e, int i)
        {
            char a = (char)i;
            if (txt_Log.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { updateTxtlbl(sender, e, i); };
                txt_Log.Invoke(safeWrite);
            }
            else
                txt_Log.AppendText(a.ToString());
        }
        private void StartEspTool(object sender, EventArgs e, bool b)
        {
            if(b)
            {
                var esptoolHandlerThreadParameters = new ThreadStart(delegate { esptoolHandler.ToolStart(); });
                var esptoolHandlerThread = new System.Threading.Thread(esptoolHandlerThreadParameters);
                esptoolHandlerThread.Start();

            }
        }

        private bool saveSettings()
        {
            bool saved = true;
            if(retrieveGuiUserselection())
            {
                string jsonString = JsonSerializer.Serialize<Dictionary<string, Object>>(dictSettings);
                File.WriteAllText(gloveSettingsPath + "\\settings.json", jsonString);
                txt_Log.AppendText("Settings are Saved ! \r\n");
            }
            else
            {
                txt_Log.AppendText("Settings were NOT Saved ! \r\n");
                saved = false;
            }
            return saved;
        }

        private bool retrieveGuiUserselection()
        {
            bool sucess = true;
            txt_Log.Clear();
            _ = cb_ImuOn.Checked? dictSettings["imu_state"] = JsonSerializer.SerializeToElement(1) : dictSettings["imu_state"] = JsonSerializer.SerializeToElement(0);
            if (cmb_ImuDataType.SelectedItem != null)
            {   
                dictSettings["imu_data"] = JsonSerializer.SerializeToElement(cmb_ImuDataType.SelectedItem.ToString());
            }
            else
            {
                txt_Log.AppendText("Invalid IMU data type only [eu] and [quat] alowed ! \r\n");
                sucess = false;
            }


            if (cmb_Contype.SelectedItem != null)
            {
                dictSettings["conType"] = JsonSerializer.SerializeToElement(cmb_Contype.SelectedItem.ToString());
            }
            else
            {
                txt_Log.AppendText("Invalid connection type only [wired] and [wireless] alowed ! \r\n");
                sucess = false;
            }

            if(txt_MacAddr.Text != string.Empty)
            {
                if(validateMacAddr(txt_MacAddr.Text))
                {
                    dictSettings["collector_addr"] = JsonSerializer.SerializeToElement(txt_MacAddr.Text);
                }
                else
                {
                    txt_Log.AppendText("Invalid Mac Address please check! \r\n");
                    sucess = false;
                }
            }
            return sucess;
        }

        private bool validateMacAddr(string macAddr)
        {
            bool b = true;
            if (macAddr.Split(':').Length == 6)
            {
                foreach (string s in macAddr.Split(':'))
                {
                    if (s == string.Empty)
                    {
                        b = false;
                        break;
                    }
                    try
                    {
                        int intValue = Convert.ToInt32(s, 16);
                    }
                    catch
                    {
                        b = false;
                        break;
                    }
                }
            }
            else
            {
                b = false;
            }
            return b;
        }
    }
}
