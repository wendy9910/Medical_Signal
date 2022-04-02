namespace HW3
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopRxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnOn = new System.Windows.Forms.RadioButton();
            this.rdBtnOFF = new System.Windows.Forms.RadioButton();
            this.txtBxRxInfo = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnSetIntrval = new System.Windows.Forms.Button();
            this.cmbBxCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.ContextMenuStrip = this.contextMenuStrip1;
            this.btnAssign.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAssign.ForeColor = System.Drawing.Color.Red;
            this.btnAssign.Location = new System.Drawing.Point(12, 12);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(163, 38);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign COM Port:";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopRxToolStripMenuItem,
            this.clearMessageToolStripMenuItem,
            this.getPortsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stopRxToolStripMenuItem
            // 
            this.stopRxToolStripMenuItem.Name = "stopRxToolStripMenuItem";
            this.stopRxToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.stopRxToolStripMenuItem.Text = "Stop Rx";
            this.stopRxToolStripMenuItem.Click += new System.EventHandler(this.stopRxToolStripMenuItem_Click);
            // 
            // clearMessageToolStripMenuItem
            // 
            this.clearMessageToolStripMenuItem.Name = "clearMessageToolStripMenuItem";
            this.clearMessageToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clearMessageToolStripMenuItem.Text = "Clear Message";
            this.clearMessageToolStripMenuItem.Click += new System.EventHandler(this.clearMessageToolStripMenuItem_Click);
            // 
            // getPortsToolStripMenuItem
            // 
            this.getPortsToolStripMenuItem.Name = "getPortsToolStripMenuItem";
            this.getPortsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.getPortsToolStripMenuItem.Text = "Get Ports";
            this.getPortsToolStripMenuItem.Click += new System.EventHandler(this.getPortsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnOn);
            this.groupBox1.Controls.Add(this.rdBtnOFF);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Magenta;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set LED Status";
            // 
            // rdBtnOn
            // 
            this.rdBtnOn.AutoSize = true;
            this.rdBtnOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdBtnOn.Location = new System.Drawing.Point(6, 36);
            this.rdBtnOn.Name = "rdBtnOn";
            this.rdBtnOn.Size = new System.Drawing.Size(94, 24);
            this.rdBtnOn.TabIndex = 2;
            this.rdBtnOn.TabStop = true;
            this.rdBtnOn.Text = "LED On";
            this.rdBtnOn.UseVisualStyleBackColor = true;
            this.rdBtnOn.CheckedChanged += new System.EventHandler(this.rdBtnOn_CheckedChanged);
            this.rdBtnOn.Click += new System.EventHandler(this.rdBtnOn_CheckedChanged);
            // 
            // rdBtnOFF
            // 
            this.rdBtnOFF.AutoSize = true;
            this.rdBtnOFF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdBtnOFF.Location = new System.Drawing.Point(150, 36);
            this.rdBtnOFF.Name = "rdBtnOFF";
            this.rdBtnOFF.Size = new System.Drawing.Size(97, 24);
            this.rdBtnOFF.TabIndex = 1;
            this.rdBtnOFF.TabStop = true;
            this.rdBtnOFF.Text = "LED Off";
            this.rdBtnOFF.UseVisualStyleBackColor = true;
            this.rdBtnOFF.CheckedChanged += new System.EventHandler(this.rdBtnOFF_CheckedChanged);
            this.rdBtnOFF.Click += new System.EventHandler(this.rdBtnOFF_CheckedChanged);
            // 
            // txtBxRxInfo
            // 
            this.txtBxRxInfo.Font = new System.Drawing.Font("新細明體", 10F);
            this.txtBxRxInfo.Location = new System.Drawing.Point(12, 160);
            this.txtBxRxInfo.Multiline = true;
            this.txtBxRxInfo.Name = "txtBxRxInfo";
            this.txtBxRxInfo.Size = new System.Drawing.Size(775, 287);
            this.txtBxRxInfo.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(302, 79);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Minimum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(359, 56);
            this.trackBar1.SmallChange = 100;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnSetIntrval
            // 
            this.btnSetIntrval.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSetIntrval.Location = new System.Drawing.Point(667, 66);
            this.btnSetIntrval.Name = "btnSetIntrval";
            this.btnSetIntrval.Size = new System.Drawing.Size(121, 78);
            this.btnSetIntrval.TabIndex = 4;
            this.btnSetIntrval.Text = "Set Interval";
            this.btnSetIntrval.UseVisualStyleBackColor = true;
            this.btnSetIntrval.Click += new System.EventHandler(this.btnSetIntrval_Click);
            // 
            // cmbBxCOMPort
            // 
            this.cmbBxCOMPort.FormattingEnabled = true;
            this.cmbBxCOMPort.Location = new System.Drawing.Point(182, 21);
            this.cmbBxCOMPort.Name = "cmbBxCOMPort";
            this.cmbBxCOMPort.Size = new System.Drawing.Size(106, 23);
            this.cmbBxCOMPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(312, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LED Turn ON Interval(ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "500";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(460, 130);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(28, 15);
            this.lblInterval.TabIndex = 9;
            this.lblInterval.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "5000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxCOMPort);
            this.Controls.Add(this.btnSetIntrval);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtBxRxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAssign);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnOFF;
        private System.Windows.Forms.TextBox txtBxRxInfo;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnSetIntrval;
        private System.Windows.Forms.ComboBox cmbBxCOMPort;
        private System.Windows.Forms.RadioButton rdBtnOn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopRxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

