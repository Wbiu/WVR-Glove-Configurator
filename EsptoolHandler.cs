using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WVR_Glove_Configurator
{
    class EsptoolHandler
    {
        private Process process = new Process();
        private string comName;
        private int baundRate;

        public event EventHandlerPassInt eventHandlerPassInt;

        public EsptoolHandler(string comName, int baundRate, string espToolPath)
        {
            this.comName = comName;
            this.baundRate = baundRate;
            Directory.SetCurrentDirectory(espToolPath);
        }

        public void ToolStart()
        {
            process.StartInfo.FileName = "esptool.exe";
            process.StartInfo.Arguments = "--chip esp32 --port " + this.comName + " --baud " + this.baundRate + " write_flash -z 0x110000 settings.bin";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            if(eventHandlerPassInt != null)
            {
                while(!process.HasExited)
                {
                    int i = process.StandardOutput.Read();
                    eventHandlerPassInt(this,null,i);
                }
                process.WaitForExit();
            }
        }
    }
}
