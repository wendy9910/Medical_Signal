namespace mySerialPort
{
    partial class ComPortConfigForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BaudRate = new System.Windows.Forms.Label();
            this.DataBit = new System.Windows.Forms.Label();
            this.Parity = new System.Windows.Forms.Label();
            this.StopBit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtrOff = new System.Windows.Forms.RadioButton();
            this.dtrOn = new System.Windows.Forms.RadioButton();
            this.DTR = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtsOff = new System.Windows.Forms.RadioButton();
            this.rtsOn = new System.Windows.Forms.RadioButton();
            this.RTS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Font = new System.Drawing.Font("新細明體", 14F);
            this.BaudRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BaudRate.Location = new System.Drawing.Point(12, 22);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(110, 24);
            this.BaudRate.TabIndex = 0;
            this.BaudRate.Text = "Baud Rate:";
            // 
            // DataBit
            // 
            this.DataBit.AutoSize = true;
            this.DataBit.Font = new System.Drawing.Font("新細明體", 14F);
            this.DataBit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DataBit.Location = new System.Drawing.Point(32, 71);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(91, 24);
            this.DataBit.TabIndex = 1;
            this.DataBit.Text = "Data Bit:";
            // 
            // Parity
            // 
            this.Parity.AutoSize = true;
            this.Parity.Font = new System.Drawing.Font("新細明體", 14F);
            this.Parity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Parity.Location = new System.Drawing.Point(52, 117);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(70, 24);
            this.Parity.TabIndex = 2;
            this.Parity.Text = "Parity:";
            // 
            // StopBit
            // 
            this.StopBit.AutoSize = true;
            this.StopBit.Font = new System.Drawing.Font("新細明體", 14F);
            this.StopBit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StopBit.Location = new System.Drawing.Point(32, 165);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(90, 24);
            this.StopBit.TabIndex = 3;
            this.StopBit.Text = "Stop Bit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtrOff);
            this.groupBox1.Controls.Add(this.dtrOn);
            this.groupBox1.Controls.Add(this.DTR);
            this.groupBox1.Location = new System.Drawing.Point(16, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dtrOff
            // 
            this.dtrOff.AutoSize = true;
            this.dtrOff.Font = new System.Drawing.Font("新細明體", 14F);
            this.dtrOff.Location = new System.Drawing.Point(231, 18);
            this.dtrOff.Name = "dtrOff";
            this.dtrOff.Size = new System.Drawing.Size(63, 28);
            this.dtrOff.TabIndex = 8;
            this.dtrOff.TabStop = true;
            this.dtrOff.Text = "Off";
            this.dtrOff.UseVisualStyleBackColor = true;
            // 
            // dtrOn
            // 
            this.dtrOn.AutoSize = true;
            this.dtrOn.Font = new System.Drawing.Font("新細明體", 14F);
            this.dtrOn.Location = new System.Drawing.Point(135, 18);
            this.dtrOn.Name = "dtrOn";
            this.dtrOn.Size = new System.Drawing.Size(58, 28);
            this.dtrOn.TabIndex = 7;
            this.dtrOn.TabStop = true;
            this.dtrOn.Text = "On";
            this.dtrOn.UseVisualStyleBackColor = true;
            // 
            // DTR
            // 
            this.DTR.AutoSize = true;
            this.DTR.Font = new System.Drawing.Font("新細明體", 14F);
            this.DTR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DTR.Location = new System.Drawing.Point(17, 21);
            this.DTR.Name = "DTR";
            this.DTR.Size = new System.Drawing.Size(61, 24);
            this.DTR.TabIndex = 6;
            this.DTR.Text = "DTR:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtsOff);
            this.groupBox2.Controls.Add(this.rtsOn);
            this.groupBox2.Controls.Add(this.RTS);
            this.groupBox2.Location = new System.Drawing.Point(16, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // rtsOff
            // 
            this.rtsOff.AutoSize = true;
            this.rtsOff.Font = new System.Drawing.Font("新細明體", 14F);
            this.rtsOff.Location = new System.Drawing.Point(231, 14);
            this.rtsOff.Name = "rtsOff";
            this.rtsOff.Size = new System.Drawing.Size(63, 28);
            this.rtsOff.TabIndex = 9;
            this.rtsOff.TabStop = true;
            this.rtsOff.Text = "Off";
            this.rtsOff.UseVisualStyleBackColor = true;
            // 
            // rtsOn
            // 
            this.rtsOn.AutoSize = true;
            this.rtsOn.Font = new System.Drawing.Font("新細明體", 14F);
            this.rtsOn.Location = new System.Drawing.Point(135, 14);
            this.rtsOn.Name = "rtsOn";
            this.rtsOn.Size = new System.Drawing.Size(58, 28);
            this.rtsOn.TabIndex = 9;
            this.rtsOn.TabStop = true;
            this.rtsOn.Text = "On";
            this.rtsOn.UseVisualStyleBackColor = true;
            // 
            // RTS
            // 
            this.RTS.AutoSize = true;
            this.RTS.Font = new System.Drawing.Font("新細明體", 14F);
            this.RTS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RTS.Location = new System.Drawing.Point(16, 21);
            this.RTS.Name = "RTS";
            this.RTS.Size = new System.Drawing.Size(58, 24);
            this.RTS.TabIndex = 7;
            this.RTS.Text = "RTS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Receive/Send Buffer Size:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "20";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("新細明體", 14F);
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(16, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Com Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(157, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBox3.Location = new System.Drawing.Point(157, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 23);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.comboBox4.Location = new System.Drawing.Point(157, 168);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 23);
            this.comboBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "3600",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.comboBox1.Location = new System.Drawing.Point(157, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // ComPortConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopBit);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.DataBit);
            this.Controls.Add(this.BaudRate);
            this.Name = "ComPortConfigForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ComPortConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BaudRate;
        private System.Windows.Forms.Label DataBit;
        private System.Windows.Forms.Label Parity;
        private System.Windows.Forms.Label StopBit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dtrOff;
        private System.Windows.Forms.RadioButton dtrOn;
        private System.Windows.Forms.Label DTR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rtsOff;
        private System.Windows.Forms.RadioButton rtsOn;
        private System.Windows.Forms.Label RTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

