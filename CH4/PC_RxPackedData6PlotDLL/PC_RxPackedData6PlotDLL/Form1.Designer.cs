namespace PC_RxPackedData6PlotDLL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxCOMPort = new System.Windows.Forms.ComboBox();
            this.StartRx = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.StopRx = new System.Windows.Forms.Button();
            this.UpdateComPort = new System.Windows.Forms.Button();
            this.GetPort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBxCOMPort);
            this.groupBox1.Controls.Add(this.StartRx);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.StopRx);
            this.groupBox1.Controls.Add(this.UpdateComPort);
            this.groupBox1.Controls.Add(this.GetPort);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(739, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 35);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sigma:";
            // 
            // cmbBxCOMPort
            // 
            this.cmbBxCOMPort.FormattingEnabled = true;
            this.cmbBxCOMPort.Location = new System.Drawing.Point(133, 36);
            this.cmbBxCOMPort.Name = "cmbBxCOMPort";
            this.cmbBxCOMPort.Size = new System.Drawing.Size(175, 31);
            this.cmbBxCOMPort.TabIndex = 5;
            // 
            // StartRx
            // 
            this.StartRx.BackColor = System.Drawing.Color.PowderBlue;
            this.StartRx.ForeColor = System.Drawing.Color.Black;
            this.StartRx.Location = new System.Drawing.Point(324, 34);
            this.StartRx.Name = "StartRx";
            this.StartRx.Size = new System.Drawing.Size(100, 33);
            this.StartRx.TabIndex = 4;
            this.StartRx.Text = "Start Rx";
            this.StartRx.UseVisualStyleBackColor = false;
            this.StartRx.Click += new System.EventHandler(this.StartRx_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(536, 34);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(90, 33);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // StopRx
            // 
            this.StopRx.BackColor = System.Drawing.Color.PowderBlue;
            this.StopRx.ForeColor = System.Drawing.Color.Black;
            this.StopRx.Location = new System.Drawing.Point(430, 34);
            this.StopRx.Name = "StopRx";
            this.StopRx.Size = new System.Drawing.Size(100, 33);
            this.StopRx.TabIndex = 2;
            this.StopRx.Text = "Stop Rx";
            this.StopRx.UseVisualStyleBackColor = false;
            this.StopRx.Click += new System.EventHandler(this.StopRx_Click);
            // 
            // UpdateComPort
            // 
            this.UpdateComPort.BackColor = System.Drawing.Color.GreenYellow;
            this.UpdateComPort.ForeColor = System.Drawing.Color.Black;
            this.UpdateComPort.Location = new System.Drawing.Point(873, 34);
            this.UpdateComPort.Name = "UpdateComPort";
            this.UpdateComPort.Size = new System.Drawing.Size(233, 33);
            this.UpdateComPort.TabIndex = 1;
            this.UpdateComPort.Text = "Update Com Port";
            this.UpdateComPort.UseVisualStyleBackColor = false;
            this.UpdateComPort.Click += new System.EventHandler(this.UpdateComPort_Click);
            // 
            // GetPort
            // 
            this.GetPort.BackColor = System.Drawing.Color.Pink;
            this.GetPort.ForeColor = System.Drawing.Color.Black;
            this.GetPort.Location = new System.Drawing.Point(27, 34);
            this.GetPort.Name = "GetPort";
            this.GetPort.Size = new System.Drawing.Size(100, 33);
            this.GetPort.TabIndex = 0;
            this.GetPort.Text = "Get Port";
            this.GetPort.UseVisualStyleBackColor = false;
            this.GetPort.Click += new System.EventHandler(this.GetPort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1115, 354);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(12, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1115, 354);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 811);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartRx;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button StopRx;
        private System.Windows.Forms.Button UpdateComPort;
        private System.Windows.Forms.Button GetPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBxCOMPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

