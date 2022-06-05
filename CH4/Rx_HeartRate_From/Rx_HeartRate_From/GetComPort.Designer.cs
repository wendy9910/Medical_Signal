namespace COMPortForm
{
    partial class GetComPort
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
            this.GetPort = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.cmbBxCOMPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GetPort
            // 
            this.GetPort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetPort.Font = new System.Drawing.Font("新細明體", 14F);
            this.GetPort.Location = new System.Drawing.Point(12, 12);
            this.GetPort.Name = "GetPort";
            this.GetPort.Size = new System.Drawing.Size(129, 35);
            this.GetPort.TabIndex = 0;
            this.GetPort.Text = "Get Port";
            this.GetPort.UseVisualStyleBackColor = false;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.YellowGreen;
            this.OK.Font = new System.Drawing.Font("新細明體", 14F);
            this.OK.Location = new System.Drawing.Point(328, 12);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(113, 35);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            // 
            // cmbBxCOMPort
            // 
            this.cmbBxCOMPort.FormattingEnabled = true;
            this.cmbBxCOMPort.Location = new System.Drawing.Point(147, 21);
            this.cmbBxCOMPort.Name = "cmbBxCOMPort";
            this.cmbBxCOMPort.Size = new System.Drawing.Size(166, 23);
            this.cmbBxCOMPort.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 59);
            this.Controls.Add(this.cmbBxCOMPort);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.GetPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetPort;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox cmbBxCOMPort;
    }
}

