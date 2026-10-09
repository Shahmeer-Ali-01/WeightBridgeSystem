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
    public partial class EditWeight : Form
    {
        public EditWeight()
        {
            InitializeComponent();
        }

        private void txtSrNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                LoadRecord();
            }
        }

        private void LoadRecord()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM WeightEntry WHERE SrNo=@SrNo";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@SrNo", txtSrNo.Text.Trim());

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtSrNo.Text = dr["SrNo"].ToString();
                    txtVehicleNo.Text = dr["VehicleNo"].ToString();

                    txtPartyCode.Text = dr["PartyCode"].ToString();
                    txtPartyName.Text = dr["PartyName"].ToString();

                    txtProductCode.Text = dr["ProductCode"].ToString();
                    txtProductName.Text = dr["ProductName"].ToString();

                    txtFirstWeight.Text = dr["FirstWeight"].ToString();
                    txtSecondWeight.Text = dr["SecondWeight"].ToString();

                    txtNetWeight.Text = dr["NetWeight"].ToString();

                    txtMond.Text = dr["Mond"].ToString();
                    txtMnd.Text = dr["Mnd"].ToString();

                    txtCashReceipt.Text = dr["CashReceipt"].ToString();

                    dtpFirstDate.Value = Convert.ToDateTime(dr["FirstDate"]);
                    dtpSecondDate.Value = Convert.ToDateTime(dr["SecondDate"]);

                    TimeSpan firstTime = (TimeSpan)dr["FirstTime"];
                    dtpFirstTime.Value = DateTime.Today.Add(firstTime);
                    TimeSpan secondTime = (TimeSpan)dr["SecondTime"];
                    dtpSecondTime.Value = DateTime.Today.Add(secondTime);
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }

                dr.Close();

                this.BeginInvoke(new Action(() =>
               {
                   txtSrNo.Focus();
                   this.ActiveControl = txtSrNo;
               }));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSrNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Sr No.");
                txtSrNo.Focus();
                return;
            }

            if (txtVehicleNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Vehicle Number.");
                txtVehicleNo.Focus();
                return;
            }

            if (txtPartyCode.Text.Trim() == "")
            {
                MessageBox.Show("Enter Party Code.");
                txtPartyCode.Focus();
                return;
            }

            if (txtProductCode.Text.Trim() == "")
            {
                MessageBox.Show("Enter Product Code.");
                txtProductCode.Focus();
                return;
            }

            int firstWeight = Convert.ToInt32(txtFirstWeight.Text);
            int secondWeight = Convert.ToInt32(txtSecondWeight.Text);

            int netWeight = Math.Abs(firstWeight - secondWeight);

            txtNetWeight.Text = netWeight.ToString();

            txtMond.Text = (netWeight / 37.324).ToString("0.00");
            txtMnd.Text = (netWeight / 40).ToString("0.00");

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = @"UPDATE WeightEntry SET
        VehicleNo=@VehicleNo,
        PartyCode=@PartyCode,
        PartyName=@PartyName,
        ProductCode=@ProductCode,
        ProductName=@ProductName,
        FirstWeight=@FirstWeight,
        SecondWeight=@SecondWeight,
        NetWeight=@NetWeight,
        Mond=@Mond,
        Mnd=@Mnd,
        CashReceipt=@CashReceipt,
        FirstDate=@FirstDate,
        FirstTime=@FirstTime,
        SecondDate=@SecondDate,
        SecondTime=@SecondTime,
        EditStatus=@EditStatus
        WHERE SrNo=@SrNo";

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

                cmd.Parameters.AddWithValue("@CashReceipt", txtCashReceipt.Text);

                cmd.Parameters.AddWithValue("@FirstDate", dtpFirstDate.Value.Date);
                cmd.Parameters.AddWithValue("@FirstTime", dtpFirstTime.Value.TimeOfDay);

                cmd.Parameters.AddWithValue("@SecondDate", dtpSecondDate.Value.Date);
                cmd.Parameters.AddWithValue("@SecondTime", dtpSecondTime.Value.TimeOfDay);

                cmd.Parameters.AddWithValue("@EditStatus", "Edited");

                cmd.Parameters.AddWithValue("@SrNo", txtSrNo.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully.");
            }
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

        private void EditWeight_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
