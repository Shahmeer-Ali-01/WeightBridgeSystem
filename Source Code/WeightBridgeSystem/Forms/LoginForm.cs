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
using WeightBridgeSystem.Forms;

namespace WeightBridgeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbUsername.Items.Clear();
            cmbUsername.Items.Add("Admin");
            cmbUsername.Items.Add("Operator");
            cmbUsername.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DatabaseConnection.GetConnection();
                con.Open();

                string username = cmbUsername.Text;
                string password = txtPassword.Text;

                string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    con.Close();

                    if (username == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                        
                    }
                    else if (username == "Operator")
                    {
                        OperatorDashboard op = new OperatorDashboard();
                        op.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}