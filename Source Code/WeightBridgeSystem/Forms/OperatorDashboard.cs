using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using WeightBridgeSystem.Database;

namespace WeightBridgeSystem.Forms
{
    public partial class OperatorDashboard : Form
    {
        public OperatorDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditWeight_Click(object sender, EventArgs e)
        { 
            EditWeight frm = new EditWeight();
            frm.Show();
        }

        private void btnClearDatabase_Click(object sender, EventArgs e)
        {
            PasswordDialog pd = new PasswordDialog();
            pd.ShowDialog();

            if (pd.IsVerified == false)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all Weight Entries?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            MessageBox.Show("Password Verified Successfully.");

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = @"DELETE FROM WeightEntry;
DBCC CHECKIDENT('WeightEntry',RESEED,0);";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Database Cleared Successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MachineCommunication frm = new MachineCommunication();
            frm.Show();
        }
    }
}

