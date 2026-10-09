
namespace WeightBridgeSystem.Forms
{
    partial class OperatorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.EditWeight = new System.Windows.Forms.Button();
            this.btnClearDatabase = new System.Windows.Forms.Button();
            this.btnMachine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERATOR DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditWeight
            // 
            this.EditWeight.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditWeight.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.EditWeight.FlatAppearance.BorderSize = 5;
            this.EditWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditWeight.ForeColor = System.Drawing.Color.White;
            this.EditWeight.Location = new System.Drawing.Point(74, 97);
            this.EditWeight.Name = "EditWeight";
            this.EditWeight.Size = new System.Drawing.Size(150, 60);
            this.EditWeight.TabIndex = 1;
            this.EditWeight.Text = "Edit Weight";
            this.EditWeight.UseVisualStyleBackColor = false;
            this.EditWeight.Click += new System.EventHandler(this.EditWeight_Click);
            // 
            // btnClearDatabase
            // 
            this.btnClearDatabase.BackColor = System.Drawing.Color.Red;
            this.btnClearDatabase.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnClearDatabase.FlatAppearance.BorderSize = 5;
            this.btnClearDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDatabase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDatabase.ForeColor = System.Drawing.Color.White;
            this.btnClearDatabase.Location = new System.Drawing.Point(256, 97);
            this.btnClearDatabase.Name = "btnClearDatabase";
            this.btnClearDatabase.Size = new System.Drawing.Size(150, 60);
            this.btnClearDatabase.TabIndex = 2;
            this.btnClearDatabase.Text = "Clear Database";
            this.btnClearDatabase.UseVisualStyleBackColor = false;
            this.btnClearDatabase.Click += new System.EventHandler(this.btnClearDatabase_Click);
            // 
            // btnMachine
            // 
            this.btnMachine.BackColor = System.Drawing.Color.Gold;
            this.btnMachine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMachine.FlatAppearance.BorderSize = 5;
            this.btnMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachine.Location = new System.Drawing.Point(161, 176);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(154, 60);
            this.btnMachine.TabIndex = 3;
            this.btnMachine.Text = "Machine Communication";
            this.btnMachine.UseVisualStyleBackColor = false;
            this.btnMachine.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnMachine);
            this.Controls.Add(this.btnClearDatabase);
            this.Controls.Add(this.EditWeight);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OperatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeightBridge System - Operator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditWeight;
        private System.Windows.Forms.Button btnClearDatabase;
        private System.Windows.Forms.Button btnMachine;
    }
}