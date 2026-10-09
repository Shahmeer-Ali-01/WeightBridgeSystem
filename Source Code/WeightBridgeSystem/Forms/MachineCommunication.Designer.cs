
namespace WeightBridgeSystem.Forms
{
    partial class MachineCommunication
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpIndicator = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.cmbIndicator = new System.Windows.Forms.ComboBox();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerWeight = new System.Windows.Forms.Timer(this.components);
            this.grpIndicator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Communication";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpIndicator
            // 
            this.grpIndicator.BackColor = System.Drawing.Color.SteelBlue;
            this.grpIndicator.Controls.Add(this.btnClose);
            this.grpIndicator.Controls.Add(this.btnDisconnect);
            this.grpIndicator.Controls.Add(this.btnConnect);
            this.grpIndicator.Controls.Add(this.cmbStopBits);
            this.grpIndicator.Controls.Add(this.lblStopBits);
            this.grpIndicator.Controls.Add(this.cmbDataBits);
            this.grpIndicator.Controls.Add(this.lblDataBits);
            this.grpIndicator.Controls.Add(this.cmbParity);
            this.grpIndicator.Controls.Add(this.lblParity);
            this.grpIndicator.Controls.Add(this.cmbBaudRate);
            this.grpIndicator.Controls.Add(this.lblBaud);
            this.grpIndicator.Controls.Add(this.cmbComPort);
            this.grpIndicator.Controls.Add(this.lblCom);
            this.grpIndicator.Controls.Add(this.cmbIndicator);
            this.grpIndicator.Controls.Add(this.lblIndicator);
            this.grpIndicator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIndicator.ForeColor = System.Drawing.Color.White;
            this.grpIndicator.Location = new System.Drawing.Point(8, 47);
            this.grpIndicator.Name = "grpIndicator";
            this.grpIndicator.Size = new System.Drawing.Size(780, 280);
            this.grpIndicator.TabIndex = 1;
            this.grpIndicator.TabStop = false;
            this.grpIndicator.Text = "Weight Indicator";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(403, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Firebrick;
            this.btnDisconnect.Location = new System.Drawing.Point(252, 207);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 50);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Green;
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(100, 207);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 50);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(500, 135);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(120, 28);
            this.cmbStopBits.TabIndex = 11;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(399, 140);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(72, 20);
            this.lblStopBits.TabIndex = 10;
            this.lblStopBits.Text = "Stop Bits";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(170, 135);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(180, 28);
            this.cmbDataBits.TabIndex = 9;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(25, 140);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(73, 20);
            this.lblDataBits.TabIndex = 8;
            this.lblDataBits.Text = "Data Bits";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Space"});
            this.cmbParity.Location = new System.Drawing.Point(500, 85);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(120, 28);
            this.cmbParity.TabIndex = 7;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(399, 90);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(50, 20);
            this.lblParity.TabIndex = 6;
            this.lblParity.Text = "Parity";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbBaudRate.Location = new System.Drawing.Point(170, 85);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(180, 28);
            this.cmbBaudRate.TabIndex = 5;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(25, 90);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(81, 20);
            this.lblBaud.TabIndex = 4;
            this.lblBaud.Text = "Baud Rate";
            // 
            // cmbComPort
            // 
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(500, 35);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(120, 28);
            this.cmbComPort.TabIndex = 3;
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(400, 40);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(68, 17);
            this.lblCom.TabIndex = 2;
            this.lblCom.Text = "COM Port";
            // 
            // cmbIndicator
            // 
            this.cmbIndicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIndicator.FormattingEnabled = true;
            this.cmbIndicator.Items.AddRange(new object[] {
            "D1000C",
            "D2008",
            "A12E",
            "other"});
            this.cmbIndicator.Location = new System.Drawing.Point(170, 35);
            this.cmbIndicator.Name = "cmbIndicator";
            this.cmbIndicator.Size = new System.Drawing.Size(180, 28);
            this.cmbIndicator.TabIndex = 1;
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.Location = new System.Drawing.Point(25, 40);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(103, 17);
            this.lblIndicator.TabIndex = 0;
            this.lblIndicator.Text = "Indicator Name";
            // 
            // timerWeight
            // 
            this.timerWeight.Tick += new System.EventHandler(this.timerWeight_Tick);
            // 
            // MachineCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.grpIndicator);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MachineCommunication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Communication";
            this.Load += new System.EventHandler(this.MachineCommunication_Load);
            this.grpIndicator.ResumeLayout(false);
            this.grpIndicator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpIndicator;
        private System.Windows.Forms.ComboBox cmbIndicator;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label lblCom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerWeight;
    }
}