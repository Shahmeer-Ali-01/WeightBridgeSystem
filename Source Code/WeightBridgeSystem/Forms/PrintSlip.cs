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
    
    public partial class PrintSlip : Form
    {
        private bool _doublePrint = false;
        public int SrNo { get; set; }
        public PrintSlip()
        {
            InitializeComponent();

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4",827,1169);
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblSlipNo_Click(object sender, EventArgs e)
        {

        }

        private void lblVehicleNo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlSlip_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDriverValue_Click(object sender, EventArgs e)
        {

        }

        private void lblSignatureValue_Click(object sender, EventArgs e)
        {

        }

        private void PrintSlip_Load(object sender, EventArgs e)
        {
            if (SrNo > 0)
            {
                LoadSlipData();
            }
            printPreviewDialog1.Document = printDocument1;
        }

        private void LoadSlipData()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM WeightEntry WHERE SrNo=@SrNo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SrNo", SrNo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    LoadData(
                        dr["SrNo"].ToString(),
                        dr["VehicleNo"].ToString(),
                        dr["PartyName"].ToString(),
                        dr["ProductName"].ToString(),
                        dr["FirstWeight"].ToString(),
                        dr["SecondWeight"].ToString(),
                        dr["NetWeight"].ToString(),
                        dr["Mond"].ToString(),
                        dr["Mnd"].ToString(),
                        dr["CashReceipt"].ToString(),
                        Convert.ToDateTime(dr["FirstDate"]).ToString("dd-MM-yyyy"),
                        dr["FirstTime"].ToString(),
                        Convert.ToDateTime(dr["SecondDate"]).ToString("dd-MM-yyyy"),
                        dr["SecondTime"].ToString()
                    );
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    this.Close();
                }

                dr.Close();
            }
        }

        public void StartPrint(bool doublePrint)
        {
            _doublePrint = doublePrint;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

        private void lblSecondDate_Click(object sender, EventArgs e)
        {

        }

        public void LoadData(
    string srNo,
    string vehicleNo,
    string partyName,
    string productName,
    string firstWeight,
    string secondWeight,
    string netWeight,
    string mond,
    string mnd,
    string cashReceipt,
    string firstDate,
    string firstTime,
    string secondDate,
    string secondTime)
        {
            lblSrNoValue.Text = srNo;
            lblVehicleNoValue.Text = vehicleNo;
            lblPartyValue.Text = partyName;
            lblProductValue.Text = productName;

            lblFirstWeightValue.Text = firstWeight;
            lblSecondWeightValue.Text = secondWeight;
            lblNetWeightValue.Text = netWeight;

            lblMondValue.Text = mond;
            lblMndValue.Text = mnd;

            lblCashReceiptValue.Text = cashReceipt;

            lblFirstDateValue.Text = firstDate;
            lblFirstTimeValue.Text = firstTime;

            lblSecondDateValue.Text = secondDate;
            lblSecondTimeValue.Text = secondTime;
        }

        
        public void ReprintSlip(bool doublePrint=false)
        {
            LoadSlipData();
            this.Show();
            StartPrint(doublePrint);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new
                Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Rectangle rect1 = new Rectangle(15, 15, 780, 500);
            e.Graphics.DrawImage(bmp, rect1);
            if (_doublePrint)
            {
                Rectangle rect2 = new Rectangle(15, 610, 760, 500);
                e.Graphics.DrawImage(bmp, rect2);
            }
        }

        private void lblCompany1_Click(object sender, EventArgs e)
        {

        }

        private void lblSignature_Click(object sender, EventArgs e)
        {

        }

        private void lblCashReceiptValue_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
