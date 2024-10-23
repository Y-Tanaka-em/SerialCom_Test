namespace SerialCom_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxTxData = new System.Windows.Forms.TextBox();
            this.tbxRxData = new System.Windows.Forms.TextBox();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.rbCRLF = new System.Windows.Forms.RadioButton();
            this.rbLF = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Re-Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(304, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(403, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxTxData
            // 
            this.tbxTxData.Location = new System.Drawing.Point(11, 100);
            this.tbxTxData.Name = "tbxTxData";
            this.tbxTxData.Size = new System.Drawing.Size(367, 19);
            this.tbxTxData.TabIndex = 1;
            // 
            // tbxRxData
            // 
            this.tbxRxData.Location = new System.Drawing.Point(11, 145);
            this.tbxRxData.Multiline = true;
            this.tbxRxData.Name = "tbxRxData";
            this.tbxRxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRxData.Size = new System.Drawing.Size(367, 178);
            this.tbxRxData.TabIndex = 1;
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(93, 14);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(185, 20);
            this.cmbCOMPort.TabIndex = 2;
            this.cmbCOMPort.Text = "- Select -";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(402, 100);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(402, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(12, 65);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 20);
            this.cmbBaud.TabIndex = 3;
            this.cmbBaud.Text = "- Select -";
            // 
            // rbCRLF
            // 
            this.rbCRLF.AutoSize = true;
            this.rbCRLF.Checked = true;
            this.rbCRLF.Location = new System.Drawing.Point(184, 65);
            this.rbCRLF.Name = "rbCRLF";
            this.rbCRLF.Size = new System.Drawing.Size(52, 16);
            this.rbCRLF.TabIndex = 4;
            this.rbCRLF.TabStop = true;
            this.rbCRLF.Text = "CRLF";
            this.rbCRLF.UseVisualStyleBackColor = true;
            // 
            // rbLF
            // 
            this.rbLF.AutoSize = true;
            this.rbLF.Location = new System.Drawing.Point(290, 64);
            this.rbLF.Name = "rbLF";
            this.rbLF.Size = new System.Drawing.Size(36, 16);
            this.rbLF.TabIndex = 4;
            this.rbLF.Text = "LF";
            this.rbLF.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(402, 64);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(49, 16);
            this.rbNone.TabIndex = 4;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 496);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbLF);
            this.Controls.Add(this.rbCRLF);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.cmbCOMPort);
            this.Controls.Add(this.tbxRxData);
            this.Controls.Add(this.tbxTxData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "SerialCom_Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxTxData;
        private System.Windows.Forms.TextBox tbxRxData;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.RadioButton rbCRLF;
        private System.Windows.Forms.RadioButton rbLF;
        private System.Windows.Forms.RadioButton rbNone;
    }
}

