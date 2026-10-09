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
    public partial class PasswordDialog : Form
    {
        public bool IsVerified = false;
        public PasswordDialog()
        {
            InitializeComponent();
        }

        private void PasswordDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username='Operator' AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    IsVerified = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Operator Password.");

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }
    }
}
