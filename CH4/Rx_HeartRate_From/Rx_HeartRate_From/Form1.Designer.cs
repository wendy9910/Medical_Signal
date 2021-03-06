namespace Rx_HeartRate_From
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.assignCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureCOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startRxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Now:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateLabel.Location = new System.Drawing.Point(135, 27);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(74, 27);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "label2";
            this.dateLabel.TextChanged += new System.EventHandler(this.timer1_Tick);
            this.dateLabel.Click += new System.EventHandler(this.date_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Heart Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(296, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "beats/min";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignCOMPortToolStripMenuItem,
            this.configureCOMPortToolStripMenuItem,
            this.startRxToolStripMenuItem,
            this.stopRxToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 124);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // assignCOMPortToolStripMenuItem
            // 
            this.assignCOMPortToolStripMenuItem.Name = "assignCOMPortToolStripMenuItem";
            this.assignCOMPortToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.assignCOMPortToolStripMenuItem.Text = "Assign COM Port";
            this.assignCOMPortToolStripMenuItem.Click += new System.EventHandler(this.assignCOMPortToolStripMenuItem_Click);
            // 
            // configureCOMPortToolStripMenuItem
            // 
            this.configureCOMPortToolStripMenuItem.Name = "configureCOMPortToolStripMenuItem";
            this.configureCOMPortToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.configureCOMPortToolStripMenuItem.Text = "Configure COM Port";
            this.configureCOMPortToolStripMenuItem.Click += new System.EventHandler(this.configureCOMPortToolStripMenuItem_Click);
            // 
            // startRxToolStripMenuItem
            // 
            this.startRxToolStripMenuItem.Name = "startRxToolStripMenuItem";
            this.startRxToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.startRxToolStripMenuItem.Text = "Start Rx";
            this.startRxToolStripMenuItem.Click += new System.EventHandler(this.startRxToolStripMenuItem_Click);
            // 
            // stopRxToolStripMenuItem
            // 
            this.stopRxToolStripMenuItem.Name = "stopRxToolStripMenuItem";
            this.stopRxToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.stopRxToolStripMenuItem.Text = "StopRx";
            this.stopRxToolStripMenuItem.Click += new System.EventHandler(this.stopRxToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(419, 153);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 16F);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assignCOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureCOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startRxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

