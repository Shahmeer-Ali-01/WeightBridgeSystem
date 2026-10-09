
namespace WeightBridgeSystem.Forms
{
    partial class SecondWeight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondWeight));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.chkDoublePrint = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.txtCashReceipt = new System.Windows.Forms.TextBox();
            this.lblCashReceipt = new System.Windows.Forms.Label();
            this.dtpSecondTime = new System.Windows.Forms.DateTimePicker();
            this.dtpSecondDate = new System.Windows.Forms.DateTimePicker();
            this.lblSecondTime = new System.Windows.Forms.Label();
            this.lblSecondDate = new System.Windows.Forms.Label();
            this.txtMnd = new System.Windows.Forms.TextBox();
            this.lblMnd = new System.Windows.Forms.Label();
            this.txtMond = new System.Windows.Forms.TextBox();
            this.lblMond = new System.Windows.Forms.Label();
            this.dtpFirstTime = new System.Windows.Forms.DateTimePicker();
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.lblNetWeight = new System.Windows.Forms.Label();
            this.txtSecondWeight = new System.Windows.Forms.TextBox();
            this.lblSecondWeight = new System.Windows.Forms.Label();
            this.txtFirstWeight = new System.Windows.Forms.TextBox();
            this.lblFirstWeight = new System.Windows.Forms.Label();
            this.lblWeightInfo = new System.Windows.Forms.Label();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtPartyCode = new System.Windows.Forms.TextBox();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblPartyCode = new System.Windows.Forms.Label();
            this.lblSrNo = new System.Windows.Forms.Label();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(984, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SECOND WEIGHT ENTRY";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Controls.Add(this.pnlWeight);
            this.pnlMain.Controls.Add(this.pnlVehicle);
            this.pnlMain.Location = new System.Drawing.Point(41, 66);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 520);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.chkDoublePrint);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Location = new System.Drawing.Point(66, 412);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(770, 70);
            this.pnlButtons.TabIndex = 2;
            // 
            // chkDoublePrint
            // 
            this.chkDoublePrint.AutoSize = true;
            this.chkDoublePrint.BackColor = System.Drawing.Color.YellowGreen;
            this.chkDoublePrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDoublePrint.Location = new System.Drawing.Point(543, 19);
            this.chkDoublePrint.Name = "chkDoublePrint";
            this.chkDoublePrint.Size = new System.Drawing.Size(145, 29);
            this.chkDoublePrint.TabIndex = 3;
            this.chkDoublePrint.Text = "Double Print";
            this.chkDoublePrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(368, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(223, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 45);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(76, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlWeight
            // 
            this.pnlWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeight.Controls.Add(this.txtCashReceipt);
            this.pnlWeight.Controls.Add(this.lblCashReceipt);
            this.pnlWeight.Controls.Add(this.dtpSecondTime);
            this.pnlWeight.Controls.Add(this.dtpSecondDate);
            this.pnlWeight.Controls.Add(this.lblSecondTime);
            this.pnlWeight.Controls.Add(this.lblSecondDate);
            this.pnlWeight.Controls.Add(this.txtMnd);
            this.pnlWeight.Controls.Add(this.lblMnd);
            this.pnlWeight.Controls.Add(this.txtMond);
            this.pnlWeight.Controls.Add(this.lblMond);
            this.pnlWeight.Controls.Add(this.dtpFirstTime);
            this.pnlWeight.Controls.Add(this.lblFirstTime);
            this.pnlWeight.Controls.Add(this.dtpFirstDate);
            this.pnlWeight.Controls.Add(this.lblFirstDate);
            this.pnlWeight.Controls.Add(this.txtNetWeight);
            this.pnlWeight.Controls.Add(this.lblNetWeight);
            this.pnlWeight.Controls.Add(this.txtSecondWeight);
            this.pnlWeight.Controls.Add(this.lblSecondWeight);
            this.pnlWeight.Controls.Add(this.txtFirstWeight);
            this.pnlWeight.Controls.Add(this.lblFirstWeight);
            this.pnlWeight.Controls.Add(this.lblWeightInfo);
            this.pnlWeight.Location = new System.Drawing.Point(40, 179);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(820, 227);
            this.pnlWeight.TabIndex = 1;
            // 
            // txtCashReceipt
            // 
            this.txtCashReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCashReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashReceipt.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCashReceipt.Location = new System.Drawing.Point(248, 190);
            this.txtCashReceipt.Name = "txtCashReceipt";
            this.txtCashReceipt.Size = new System.Drawing.Size(80, 29);
            this.txtCashReceipt.TabIndex = 20;
            this.txtCashReceipt.Text = "0";
            this.txtCashReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCashReceipt
            // 
            this.lblCashReceipt.AutoSize = true;
            this.lblCashReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReceipt.Location = new System.Drawing.Point(97, 192);
            this.lblCashReceipt.Name = "lblCashReceipt";
            this.lblCashReceipt.Size = new System.Drawing.Size(107, 21);
            this.lblCashReceipt.TabIndex = 19;
            this.lblCashReceipt.Text = "Cash Reciept";
            this.lblCashReceipt.Click += new System.EventHandler(this.lblCashReceipt_Click);
            // 
            // dtpSecondTime
            // 
            this.dtpSecondTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecondTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSecondTime.Location = new System.Drawing.Point(681, 82);
            this.dtpSecondTime.Name = "dtpSecondTime";
            this.dtpSecondTime.ShowUpDown = true;
            this.dtpSecondTime.Size = new System.Drawing.Size(110, 25);
            this.dtpSecondTime.TabIndex = 18;
            // 
            // dtpSecondDate
            // 
            this.dtpSecondDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSecondDate.Location = new System.Drawing.Point(681, 45);
            this.dtpSecondDate.Name = "dtpSecondDate";
            this.dtpSecondDate.Size = new System.Drawing.Size(114, 25);
            this.dtpSecondDate.TabIndex = 17;
            // 
            // lblSecondTime
            // 
            this.lblSecondTime.AutoSize = true;
            this.lblSecondTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondTime.Location = new System.Drawing.Point(572, 88);
            this.lblSecondTime.Name = "lblSecondTime";
            this.lblSecondTime.Size = new System.Drawing.Size(87, 17);
            this.lblSecondTime.TabIndex = 16;
            this.lblSecondTime.Text = "Second Time";
            // 
            // lblSecondDate
            // 
            this.lblSecondDate.AutoSize = true;
            this.lblSecondDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondDate.Location = new System.Drawing.Point(574, 51);
            this.lblSecondDate.Name = "lblSecondDate";
            this.lblSecondDate.Size = new System.Drawing.Size(85, 17);
            this.lblSecondDate.TabIndex = 15;
            this.lblSecondDate.Text = "Second Date";
            // 
            // txtMnd
            // 
            this.txtMnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnd.Location = new System.Drawing.Point(559, 158);
            this.txtMnd.Name = "txtMnd";
            this.txtMnd.ReadOnly = true;
            this.txtMnd.Size = new System.Drawing.Size(120, 25);
            this.txtMnd.TabIndex = 14;
            this.txtMnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMnd
            // 
            this.lblMnd.AutoSize = true;
            this.lblMnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnd.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMnd.Location = new System.Drawing.Point(454, 161);
            this.lblMnd.Name = "lblMnd";
            this.lblMnd.Size = new System.Drawing.Size(60, 17);
            this.lblMnd.TabIndex = 13;
            this.lblMnd.Text = "Mnd(40)";
            // 
            // txtMond
            // 
            this.txtMond.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMond.Location = new System.Drawing.Point(560, 124);
            this.txtMond.Name = "txtMond";
            this.txtMond.ReadOnly = true;
            this.txtMond.Size = new System.Drawing.Size(120, 25);
            this.txtMond.TabIndex = 12;
            this.txtMond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMond
            // 
            this.lblMond.AutoSize = true;
            this.lblMond.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMond.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMond.Location = new System.Drawing.Point(446, 127);
            this.lblMond.Name = "lblMond";
            this.lblMond.Size = new System.Drawing.Size(93, 17);
            this.lblMond.TabIndex = 11;
            this.lblMond.Text = "Mond(37.324)";
            // 
            // dtpFirstTime
            // 
            this.dtpFirstTime.Enabled = false;
            this.dtpFirstTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFirstTime.Location = new System.Drawing.Point(430, 82);
            this.dtpFirstTime.Name = "dtpFirstTime";
            this.dtpFirstTime.ShowUpDown = true;
            this.dtpFirstTime.Size = new System.Drawing.Size(109, 25);
            this.dtpFirstTime.TabIndex = 10;
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.AutoSize = true;
            this.lblFirstTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstTime.Location = new System.Drawing.Point(354, 88);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(70, 17);
            this.lblFirstTime.TabIndex = 9;
            this.lblFirstTime.Text = "First Time";
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Enabled = false;
            this.dtpFirstDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFirstDate.Location = new System.Drawing.Point(430, 45);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(109, 25);
            this.dtpFirstDate.TabIndex = 8;
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstDate.Location = new System.Drawing.Point(356, 51);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.Size = new System.Drawing.Size(68, 17);
            this.lblFirstDate.TabIndex = 7;
            this.lblFirstDate.Text = "First Date";
            this.lblFirstDate.Click += new System.EventHandler(this.lblFirstDate_Click);
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.BackColor = System.Drawing.Color.White;
            this.txtNetWeight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetWeight.Location = new System.Drawing.Point(149, 142);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.ReadOnly = true;
            this.txtNetWeight.Size = new System.Drawing.Size(150, 33);
            this.txtNetWeight.TabIndex = 6;
            this.txtNetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNetWeight
            // 
            this.lblNetWeight.AutoSize = true;
            this.lblNetWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeight.Location = new System.Drawing.Point(6, 148);
            this.lblNetWeight.Name = "lblNetWeight";
            this.lblNetWeight.Size = new System.Drawing.Size(98, 21);
            this.lblNetWeight.TabIndex = 5;
            this.lblNetWeight.Text = "Net Weight";
            // 
            // txtSecondWeight
            // 
            this.txtSecondWeight.BackColor = System.Drawing.Color.White;
            this.txtSecondWeight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondWeight.Location = new System.Drawing.Point(149, 96);
            this.txtSecondWeight.Name = "txtSecondWeight";
            this.txtSecondWeight.Size = new System.Drawing.Size(150, 33);
            this.txtSecondWeight.TabIndex = 4;
            this.txtSecondWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecondWeight.TextChanged += new System.EventHandler(this.txtSecondWeight_TextChanged);
            // 
            // lblSecondWeight
            // 
            this.lblSecondWeight.AutoSize = true;
            this.lblSecondWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondWeight.Location = new System.Drawing.Point(6, 102);
            this.lblSecondWeight.Name = "lblSecondWeight";
            this.lblSecondWeight.Size = new System.Drawing.Size(99, 21);
            this.lblSecondWeight.TabIndex = 3;
            this.lblSecondWeight.Text = "2nd Weight";
            // 
            // txtFirstWeight
            // 
            this.txtFirstWeight.BackColor = System.Drawing.Color.White;
            this.txtFirstWeight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstWeight.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtFirstWeight.Location = new System.Drawing.Point(149, 51);
            this.txtFirstWeight.Name = "txtFirstWeight";
            this.txtFirstWeight.ReadOnly = true;
            this.txtFirstWeight.Size = new System.Drawing.Size(150, 33);
            this.txtFirstWeight.TabIndex = 2;
            this.txtFirstWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstWeight.TextChanged += new System.EventHandler(this.txtFirstWeight_TextChanged);
            // 
            // lblFirstWeight
            // 
            this.lblFirstWeight.AutoSize = true;
            this.lblFirstWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstWeight.Location = new System.Drawing.Point(3, 57);
            this.lblFirstWeight.Name = "lblFirstWeight";
            this.lblFirstWeight.Size = new System.Drawing.Size(102, 21);
            this.lblFirstWeight.TabIndex = 1;
            this.lblFirstWeight.Text = "First Weight";
            // 
            // lblWeightInfo
            // 
            this.lblWeightInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblWeightInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWeightInfo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightInfo.ForeColor = System.Drawing.Color.White;
            this.lblWeightInfo.Location = new System.Drawing.Point(0, 0);
            this.lblWeightInfo.Name = "lblWeightInfo";
            this.lblWeightInfo.Size = new System.Drawing.Size(818, 35);
            this.lblWeightInfo.TabIndex = 0;
            this.lblWeightInfo.Text = "WEIGHT INFORMATION";
            this.lblWeightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVehicle.Controls.Add(this.txtProductName);
            this.pnlVehicle.Controls.Add(this.txtPartyName);
            this.pnlVehicle.Controls.Add(this.txtVehicleNo);
            this.pnlVehicle.Controls.Add(this.txtProductCode);
            this.pnlVehicle.Controls.Add(this.txtPartyCode);
            this.pnlVehicle.Controls.Add(this.txtSrNo);
            this.pnlVehicle.Controls.Add(this.lblProductName);
            this.pnlVehicle.Controls.Add(this.lblPartyName);
            this.pnlVehicle.Controls.Add(this.lblVehicleNo);
            this.pnlVehicle.Controls.Add(this.lblProductCode);
            this.pnlVehicle.Controls.Add(this.lblPartyCode);
            this.pnlVehicle.Controls.Add(this.lblSrNo);
            this.pnlVehicle.Controls.Add(this.lblVehicleInfo);
            this.pnlVehicle.Location = new System.Drawing.Point(40, 3);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(820, 170);
            this.pnlVehicle.TabIndex = 0;
            this.pnlVehicle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVehicle_Paint);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(479, 126);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(280, 25);
            this.txtProductName.TabIndex = 12;
            // 
            // txtPartyName
            // 
            this.txtPartyName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(479, 85);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(280, 25);
            this.txtPartyName.TabIndex = 11;
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehicleNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(479, 43);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(180, 25);
            this.txtVehicleNo.TabIndex = 10;
            this.txtVehicleNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVehicleNo_KeyDown);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(158, 122);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(120, 25);
            this.txtProductCode.TabIndex = 9;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // txtPartyCode
            // 
            this.txtPartyCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyCode.Location = new System.Drawing.Point(158, 82);
            this.txtPartyCode.Name = "txtPartyCode";
            this.txtPartyCode.Size = new System.Drawing.Size(120, 25);
            this.txtPartyCode.TabIndex = 8;
            this.txtPartyCode.TextChanged += new System.EventHandler(this.txtPartyCode_TextChanged);
            this.txtPartyCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartyCode_KeyDown);
            // 
            // txtSrNo
            // 
            this.txtSrNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.Location = new System.Drawing.Point(158, 43);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(120, 25);
            this.txtSrNo.TabIndex = 7;
            this.txtSrNo.TabStop = false;
            this.txtSrNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrNo_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(336, 122);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 17);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyName.Location = new System.Drawing.Point(336, 82);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(88, 17);
            this.lblPartyName.TabIndex = 5;
            this.lblPartyName.Text = "Party Name :";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.Location = new System.Drawing.Point(336, 43);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(82, 17);
            this.lblVehicleNo.TabIndex = 4;
            this.lblVehicleNo.Text = "Vehicle No :";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(46, 122);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(99, 17);
            this.lblProductCode.TabIndex = 3;
            this.lblProductCode.Text = "Product Code :";
            // 
            // lblPartyCode
            // 
            this.lblPartyCode.AutoSize = true;
            this.lblPartyCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyCode.Location = new System.Drawing.Point(46, 82);
            this.lblPartyCode.Name = "lblPartyCode";
            this.lblPartyCode.Size = new System.Drawing.Size(83, 17);
            this.lblPartyCode.TabIndex = 2;
            this.lblPartyCode.Text = "Party Code :";
            // 
            // lblSrNo
            // 
            this.lblSrNo.AutoSize = true;
            this.lblSrNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrNo.Location = new System.Drawing.Point(46, 43);
            this.lblSrNo.Name = "lblSrNo";
            this.lblSrNo.Size = new System.Drawing.Size(50, 17);
            this.lblSrNo.TabIndex = 1;
            this.lblSrNo.Text = "Sr No :";
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblVehicleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVehicleInfo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleInfo.ForeColor = System.Drawing.Color.White;
            this.lblVehicleInfo.Location = new System.Drawing.Point(0, 0);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(818, 23);
            this.lblVehicleInfo.TabIndex = 0;
            this.lblVehicleInfo.Text = "VEHICLE INFORMATION";
            this.lblVehicleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SecondWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SecondWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Weight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecondWeight_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.Label lblWeightInfo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtPartyCode;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblPartyCode;
        private System.Windows.Forms.Label lblSrNo;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.Label lblNetWeight;
        private System.Windows.Forms.TextBox txtSecondWeight;
        private System.Windows.Forms.Label lblSecondWeight;
        private System.Windows.Forms.TextBox txtFirstWeight;
        private System.Windows.Forms.Label lblFirstWeight;
        private System.Windows.Forms.TextBox txtMnd;
        private System.Windows.Forms.Label lblMnd;
        private System.Windows.Forms.TextBox txtMond;
        private System.Windows.Forms.Label lblMond;
        private System.Windows.Forms.DateTimePicker dtpFirstTime;
        private System.Windows.Forms.Label lblFirstTime;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.Label lblFirstDate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.CheckBox chkDoublePrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpSecondTime;
        private System.Windows.Forms.DateTimePicker dtpSecondDate;
        private System.Windows.Forms.Label lblSecondTime;
        private System.Windows.Forms.Label lblSecondDate;
        private System.Windows.Forms.Label lblCashReceipt;
        private System.Windows.Forms.TextBox txtCashReceipt;
        private System.Windows.Forms.Timer timer1;
    }
}