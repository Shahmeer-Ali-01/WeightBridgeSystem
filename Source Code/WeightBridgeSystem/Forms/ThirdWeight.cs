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
    public partial class ThirdWeight : Form
    {
        public ThirdWeight()
        {
            InitializeComponent();
        }

        private void ThirdWeight_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dtpFirstDate.Value = DateTime.Now;
            dtpFirstTime.Value = DateTime.Now;
            dtpSecondDate.Value = DateTime.Now;
            dtpSecondTime.Value = DateTime.Now;
            LoadNextSrNo();
            txtVehicleNo.Focus();
            this.ActiveControl = txtVehicleNo;
            btnPrint.Enabled = false;
        }

        private void LoadNextSrNo()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(MAX(SrNo),0)+1 FROM WeightEntry", con);
                txtSrNo.Text = cmd.ExecuteScalar().ToString();
            }
        }

        private void txtVehicleNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPartyCode.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPartyCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    string query = "SELECT PartyName From dbo.Parties WHERE PartyCode = @PartyCode";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PartyCode", txtPartyCode.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtPartyName.Text = result.ToString().Trim();
                        txtProductCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Party Code Not Found.");
                        txtPartyName.Clear();
                        txtPartyCode.Focus();
                    }
                }
                e.SuppressKeyPress = true;
            }
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    string query = "SELECT ProductName From dbo.Products WHERE ProductCode = @ProductCode";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtProductName.Text = result.ToString().Trim();
                        btnSave.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Product Code Not Found.");
                        txtProductName.Clear();
                        txtProductCode.Focus();
                    }
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Vehicle Number");
                txtVehicleNo.Focus();
                return;
            }

            if (txtPartyCode.Text.Trim() == "")
            {
                MessageBox.Show("Enter Party Code");
                txtPartyCode.Focus();
                return;
            }

            if (txtProductCode.Text.Trim() == "")
            {
                MessageBox.Show("Enter Product Code");
                txtProductCode.Focus();
                return;
            }

            if (txtCashReceipt.Text.Trim() == "")
            {
                txtCashReceipt.Text = "0";
            }
            int cashReceipt = Convert.ToInt32(txtCashReceipt.Text);
            if (cashReceipt < 0)
            {
                MessageBox.Show("Cash Receipt cannot be negative.");
                txtCashReceipt.Focus();
                return;
            }
            if (txtSecondWeight.Text.Trim() == "" || txtSecondWeight.Text == "0")
            {
                MessageBox.Show("Enter First Weight");
                txtFirstWeight.Focus();
                return;
            }

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = @"INSERT INTO WeightEntry
(
VehicleNo,
PartyCode,
PartyName,
ProductCode,
ProductName,
FirstWeight,
SecondWeight,
NetWeight,
Mond,
Mnd,
FirstDate,
FirstTime,
SecondDate,
SecondTime,
CashReceipt
)
VALUES
(
@VehicleNo,
@PartyCode,
@PartyName,
@ProductCode,
@ProductName,
@FirstWeight,
@SecondWeight,
@NetWeight,
@Mond,
@Mnd,
@FirstDate,
@FirstTime,
@SecondDate,
@SecondTime,
@CashReceipt
)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VehicleNo", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@PartyCode", txtPartyCode.Text);
                cmd.Parameters.AddWithValue("@PartyName", txtPartyName.Text);

                cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);

                cmd.Parameters.AddWithValue("@FirstWeight", txtFirstWeight.Text);
                cmd.Parameters.AddWithValue("@SecondWeight", txtSecondWeight.Text);
                cmd.Parameters.AddWithValue("@NetWeight", txtNetWeight.Text);

                cmd.Parameters.AddWithValue("@Mond", txtMond.Text);
                cmd.Parameters.AddWithValue("@Mnd", txtMnd.Text);

                cmd.Parameters.AddWithValue("@FirstDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@FirstTime", DateTime.Now.TimeOfDay);
                cmd.Parameters.AddWithValue("@SecondDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@SecondTime", DateTime.Now.TimeOfDay);
                cmd.Parameters.AddWithValue("@CashReceipt", txtCashReceipt.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Third Weight Saved Successfully.");
                btnSave.Enabled = false;
                btnPrint.Enabled = true;
            }
        }



        private void CalculateWeight()
        {
            if (txtFirstWeight.Text.Trim() == "" ||
                txtSecondWeight.Text.Trim() == "")
                return;

            double firstWeight = Convert.ToDouble(txtFirstWeight.Text);
            double secondWeight = Convert.ToDouble(txtSecondWeight.Text);

            double netWeight = Math.Abs(firstWeight - secondWeight);

            txtNetWeight.Text = netWeight.ToString();

            txtMond.Text = (netWeight / 37.324).ToString("0.00");
            txtMnd.Text = (netWeight / 40).ToString("0.00");
        }

        private void txtSecondWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateWeight();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintSlip frm = new PrintSlip();
            frm.LoadData(
                txtSrNo.Text,
                txtVehicleNo.Text,
                txtPartyName.Text,
                txtProductName.Text,
                txtFirstWeight.Text,
                txtSecondWeight.Text,
                txtNetWeight.Text,
                txtMond.Text,
                txtMnd.Text,
                txtCashReceipt.Text,
                dtpFirstDate.Text,
                dtpFirstTime.Text,
                dtpSecondDate.Text,
                dtpSecondTime.Text
                );
            frm.Show();
            frm.StartPrint(chkDoublePrint.Checked);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFirstWeight.Text = LiveWeight.CurrentWeight;
        }
    }
}
