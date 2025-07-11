
namespace WVR_Glove_Configurator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.cmb_SerialPorts = new System.Windows.Forms.ComboBox();
            this.txt_baundrate = new System.Windows.Forms.TextBox();
            this.lbl_ComPort = new System.Windows.Forms.Label();
            this.lbl_baundrate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ImuDataType = new System.Windows.Forms.ComboBox();
            this.cb_ImuOn = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txt_MacAddr = new System.Windows.Forms.TextBox();
            this.cmb_Contype = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_threshold_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_threshold = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_assistStrenth = new System.Windows.Forms.TextBox();
            this.cb_fingerassist = new System.Windows.Forms.CheckBox();
            this.cb_ServoCheck = new System.Windows.Forms.CheckBox();
            this.lbl_log = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_Log
            // 
            this.txt_Log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(21, 492);
            this.txt_Log.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.Size = new System.Drawing.Size(672, 187);
            this.txt_Log.TabIndex = 1;
            // 
            // btn_upload
            // 
            this.btn_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(396, 27);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(299, 81);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "Upload Config";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // cmb_SerialPorts
            // 
            this.cmb_SerialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SerialPorts.FormattingEnabled = true;
            this.cmb_SerialPorts.ItemHeight = 24;
            this.cmb_SerialPorts.Location = new System.Drawing.Point(529, 160);
            this.cmb_SerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_SerialPorts.Name = "cmb_SerialPorts";
            this.cmb_SerialPorts.Size = new System.Drawing.Size(164, 32);
            this.cmb_SerialPorts.TabIndex = 3;
            this.cmb_SerialPorts.SelectedIndexChanged += new System.EventHandler(this.cmb_SerialPorts_SelectedIndexChanged);
            // 
            // txt_baundrate
            // 
            this.txt_baundrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baundrate.Location = new System.Drawing.Point(529, 210);
            this.txt_baundrate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_baundrate.Name = "txt_baundrate";
            this.txt_baundrate.Size = new System.Drawing.Size(164, 29);
            this.txt_baundrate.TabIndex = 4;
            // 
            // lbl_ComPort
            // 
            this.lbl_ComPort.AutoSize = true;
            this.lbl_ComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComPort.Location = new System.Drawing.Point(417, 161);
            this.lbl_ComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ComPort.Name = "lbl_ComPort";
            this.lbl_ComPort.Size = new System.Drawing.Size(100, 25);
            this.lbl_ComPort.TabIndex = 5;
            this.lbl_ComPort.Text = "COM Port";
            // 
            // lbl_baundrate
            // 
            this.lbl_baundrate.AutoSize = true;
            this.lbl_baundrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baundrate.Location = new System.Drawing.Point(409, 210);
            this.lbl_baundrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_baundrate.Name = "lbl_baundrate";
            this.lbl_baundrate.Size = new System.Drawing.Size(102, 25);
            this.lbl_baundrate.TabIndex = 6;
            this.lbl_baundrate.Text = "Baundrate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_ImuDataType);
            this.groupBox1.Controls.Add(this.cb_ImuOn);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(361, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IMU Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data Type";
            // 
            // cmb_ImuDataType
            // 
            this.cmb_ImuDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ImuDataType.FormattingEnabled = true;
            this.cmb_ImuDataType.ItemHeight = 24;
            this.cmb_ImuDataType.Location = new System.Drawing.Point(175, 46);
            this.cmb_ImuDataType.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ImuDataType.Name = "cmb_ImuDataType";
            this.cmb_ImuDataType.Size = new System.Drawing.Size(164, 32);
            this.cmb_ImuDataType.TabIndex = 8;
            // 
            // cb_ImuOn
            // 
            this.cb_ImuOn.AutoSize = true;
            this.cb_ImuOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ImuOn.Location = new System.Drawing.Point(33, 46);
            this.cb_ImuOn.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ImuOn.Name = "cb_ImuOn";
            this.cb_ImuOn.Size = new System.Drawing.Size(92, 28);
            this.cb_ImuOn.TabIndex = 0;
            this.cb_ImuOn.Text = "IMU on";
            this.cb_ImuOn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_Type);
            this.groupBox2.Controls.Add(this.txt_MacAddr);
            this.groupBox2.Controls.Add(this.cmb_Contype);
            this.groupBox2.Location = new System.Drawing.Point(21, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(369, 123);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mac Addr";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(92, 27);
            this.lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(53, 24);
            this.lbl_Type.TabIndex = 11;
            this.lbl_Type.Text = "Type";
            // 
            // txt_MacAddr
            // 
            this.txt_MacAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MacAddr.Location = new System.Drawing.Point(8, 79);
            this.txt_MacAddr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MacAddr.Name = "txt_MacAddr";
            this.txt_MacAddr.Size = new System.Drawing.Size(352, 29);
            this.txt_MacAddr.TabIndex = 10;
            // 
            // cmb_Contype
            // 
            this.cmb_Contype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Contype.FormattingEnabled = true;
            this.cmb_Contype.ItemHeight = 24;
            this.cmb_Contype.Location = new System.Drawing.Point(153, 23);
            this.cmb_Contype.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Contype.Name = "cmb_Contype";
            this.cmb_Contype.Size = new System.Drawing.Size(207, 32);
            this.cmb_Contype.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_threshold_time);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_threshold);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_assistStrenth);
            this.groupBox3.Controls.Add(this.cb_fingerassist);
            this.groupBox3.Controls.Add(this.cb_ServoCheck);
            this.groupBox3.Location = new System.Drawing.Point(21, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(675, 170);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Advaced";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Assist threshold time";
            // 
            // tb_threshold_time
            // 
            this.tb_threshold_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_threshold_time.Location = new System.Drawing.Point(508, 59);
            this.tb_threshold_time.Name = "tb_threshold_time";
            this.tb_threshold_time.Size = new System.Drawing.Size(145, 28);
            this.tb_threshold_time.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Assist threshold";
            // 
            // tb_threshold
            // 
            this.tb_threshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_threshold.Location = new System.Drawing.Point(508, 119);
            this.tb_threshold.Name = "tb_threshold";
            this.tb_threshold.Size = new System.Drawing.Size(145, 28);
            this.tb_threshold.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Assist strenth";
            // 
            // tb_assistStrenth
            // 
            this.tb_assistStrenth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_assistStrenth.Location = new System.Drawing.Point(295, 119);
            this.tb_assistStrenth.Margin = new System.Windows.Forms.Padding(4);
            this.tb_assistStrenth.Name = "tb_assistStrenth";
            this.tb_assistStrenth.Size = new System.Drawing.Size(164, 29);
            this.tb_assistStrenth.TabIndex = 11;
            // 
            // cb_fingerassist
            // 
            this.cb_fingerassist.AutoSize = true;
            this.cb_fingerassist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fingerassist.Location = new System.Drawing.Point(295, 26);
            this.cb_fingerassist.Margin = new System.Windows.Forms.Padding(4);
            this.cb_fingerassist.Name = "cb_fingerassist";
            this.cb_fingerassist.Size = new System.Drawing.Size(132, 28);
            this.cb_fingerassist.TabIndex = 0;
            this.cb_fingerassist.Text = "Fingerassist";
            this.cb_fingerassist.UseVisualStyleBackColor = true;
            // 
            // cb_ServoCheck
            // 
            this.cb_ServoCheck.AutoSize = true;
            this.cb_ServoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ServoCheck.Location = new System.Drawing.Point(12, 23);
            this.cb_ServoCheck.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ServoCheck.Name = "cb_ServoCheck";
            this.cb_ServoCheck.Size = new System.Drawing.Size(206, 28);
            this.cb_ServoCheck.TabIndex = 0;
            this.cb_ServoCheck.Text = "Servo check on boot";
            this.cb_ServoCheck.UseVisualStyleBackColor = true;
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log.Location = new System.Drawing.Point(16, 464);
            this.lbl_log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(45, 25);
            this.lbl_log.TabIndex = 10;
            this.lbl_log.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(709, 693);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_baundrate);
            this.Controls.Add(this.lbl_ComPort);
            this.Controls.Add(this.txt_baundrate);
            this.Controls.Add(this.cmb_SerialPorts);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.txt_Log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Glove Configurator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.ComboBox cmb_SerialPorts;
        private System.Windows.Forms.TextBox txt_baundrate;
        private System.Windows.Forms.Label lbl_ComPort;
        private System.Windows.Forms.Label lbl_baundrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_ImuDataType;
        private System.Windows.Forms.CheckBox cb_ImuOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MacAddr;
        private System.Windows.Forms.ComboBox cmb_Contype;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_ServoCheck;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_assistStrenth;
        private System.Windows.Forms.CheckBox cb_fingerassist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_threshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_threshold_time;
    }
}

