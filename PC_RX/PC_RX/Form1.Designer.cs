namespace PC_RX
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
            this.GetPortbtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.StartRxbtn = new System.Windows.Forms.Button();
            this.StopRxbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ShowText1 = new System.Windows.Forms.TextBox();
            this.ShowText2 = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.Clearbtn);
            this.groupBox1.Controls.Add(this.Savebtn);
            this.groupBox1.Controls.Add(this.StopRxbtn);
            this.groupBox1.Controls.Add(this.StartRxbtn);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.GetPortbtn);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // GetPortbtn
            // 
            this.GetPortbtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.GetPortbtn.ForeColor = System.Drawing.Color.Green;
            this.GetPortbtn.Location = new System.Drawing.Point(7, 33);
            this.GetPortbtn.Name = "GetPortbtn";
            this.GetPortbtn.Size = new System.Drawing.Size(130, 31);
            this.GetPortbtn.TabIndex = 0;
            this.GetPortbtn.Text = "Get Ports";
            this.GetPortbtn.UseVisualStyleBackColor = true;
            this.GetPortbtn.Click += new System.EventHandler(this.GetPortbtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(143, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 31);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // StartRxbtn
            // 
            this.StartRxbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StartRxbtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.StartRxbtn.Location = new System.Drawing.Point(270, 34);
            this.StartRxbtn.Name = "StartRxbtn";
            this.StartRxbtn.Size = new System.Drawing.Size(83, 30);
            this.StartRxbtn.TabIndex = 2;
            this.StartRxbtn.Text = "Start Rx";
            this.StartRxbtn.UseVisualStyleBackColor = false;
            this.StartRxbtn.Click += new System.EventHandler(this.StartRxbtn_Click);
            // 
            // StopRxbtn
            // 
            this.StopRxbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.StopRxbtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.StopRxbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StopRxbtn.Location = new System.Drawing.Point(359, 33);
            this.StopRxbtn.Name = "StopRxbtn";
            this.StopRxbtn.Size = new System.Drawing.Size(79, 30);
            this.StopRxbtn.TabIndex = 3;
            this.StopRxbtn.Text = "Stop Rx";
            this.StopRxbtn.UseVisualStyleBackColor = false;
            this.StopRxbtn.Click += new System.EventHandler(this.StopRxbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Yellow;
            this.Savebtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.Savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Savebtn.Location = new System.Drawing.Point(444, 34);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(59, 30);
            this.Savebtn.TabIndex = 4;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Clearbtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.Clearbtn.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Clearbtn.Location = new System.Drawing.Point(544, 34);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(76, 30);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Font = new System.Drawing.Font("新細明體", 12F);
            this.button6.ForeColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(626, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Update Com Port";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ShowText1
            // 
            this.ShowText1.Location = new System.Drawing.Point(13, 98);
            this.ShowText1.Multiline = true;
            this.ShowText1.Name = "ShowText1";
            this.ShowText1.Size = new System.Drawing.Size(619, 397);
            this.ShowText1.TabIndex = 1;
            // 
            // ShowText2
            // 
            this.ShowText2.Location = new System.Drawing.Point(638, 98);
            this.ShowText2.Multiline = true;
            this.ShowText2.Name = "ShowText2";
            this.ShowText2.Size = new System.Drawing.Size(150, 397);
            this.ShowText2.TabIndex = 2;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ShowText2);
            this.Controls.Add(this.ShowText1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button StopRxbtn;
        private System.Windows.Forms.Button StartRxbtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button GetPortbtn;
        private System.Windows.Forms.TextBox ShowText1;
        private System.Windows.Forms.TextBox ShowText2;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer1;
    }
}

