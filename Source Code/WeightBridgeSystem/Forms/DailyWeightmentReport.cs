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
    
    public partial class DailyWeightmentReport : Form
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DailyWeightmentReport()
        {
            InitializeComponent();
        }

        private void LoadReport()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = @"
SELECT
SrNo,
VehicleNo,
PartyName,
ProductName,
FirstWeight,
SecondWeight,
NetWeight,
FirstDate,
FirstTime,
SecondDate,
SecondTime,
CashReceipt
FROM WeightEntry
WHERE FirstDate BETWEEN @FromDate AND @ToDate
ORDER BY SrNo";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue("@FromDate", FromDate.Date);
                da.SelectCommand.Parameters.AddWithValue("@ToDate",
                    ToDate.Date.AddDays(1).AddSeconds(-1));

                DataTable dt = new DataTable();
                da.Fill(dt);
                

                 dgvReport.DataSource = dt;
                int totalCash = 0;
               foreach(DataRow row in dt.Rows)
                {
                    if(row["CashReceipt"] != DBNull.Value)
                   {
                        totalCash += Convert.ToInt32(row["CashReceipt"]);
                    }
                }
                lblTotalCash.Text = "Total Cash : " + totalCash.ToString("N0");
                lblTotalRecords.Text = "Total Records : " + dt.Rows.Count;
                
            }
        }
        private void DailyWeightmentReport_Load(object sender, EventArgs e)
        {
            dgvReport.AutoGenerateColumns = true;

            dgvReport.DefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Regular);

            dgvReport.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgvReport.RowTemplate.Height = 35;
            dgvReport.ColumnHeadersHeight = 40;

            dgvReport.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvReport.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            LoadReport();
        }

        private void lblTotalCash_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
            e.Graphics.DrawString(
                "DAILY WEIGHTMENT REPORT",
                titleFont, Brushes.Black, 220, 40);
            Font normalFont = new Font("Sogoe UI", 10, FontStyle.Bold);
            string dateText = FromDate.ToString("dd-MM-yyyy") + " To : " + ToDate.ToString("dd-MM-yyyy");
            e.Graphics.DrawString(
                dateText, normalFont, Brushes.Black, 20, 90);
            Font headerFont = new Font("Segoe UI", 9, FontStyle.Bold);

            int y = 130;

            e.Graphics.DrawRectangle(Pens.Black, 20, y, 60, 30);
            e.Graphics.DrawString("Sr No", headerFont, Brushes.Black, 25, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 80, y, 90, 30);
            e.Graphics.DrawString("Vehicle", headerFont, Brushes.Black, 90, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 170, y, 140, 30);
            e.Graphics.DrawString("Party", headerFont, Brushes.Black, 185, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 310, y, 140, 30);
            e.Graphics.DrawString("Product", headerFont, Brushes.Black, 320, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 450, y, 70, 30);
            e.Graphics.DrawString("1st Wt", headerFont, Brushes.Black, 455, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 520, y, 70, 30);
            e.Graphics.DrawString("2nd Wt", headerFont, Brushes.Black, 525, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 590, y, 70, 30);
            e.Graphics.DrawString("Net Wt", headerFont, Brushes.Black, 595, y + 8);

            e.Graphics.DrawRectangle(Pens.Black, 660, y, 90, 30);
            e.Graphics.DrawString("Cash", headerFont, Brushes.Black, 675, y + 8);

            Font rowFont = new Font("Segoe UI", 9);

            y += 30;

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawRectangle(Pens.Black, 20, y, 60, 25);
                e.Graphics.DrawString(row.Cells["SrNo"].Value?.ToString(), rowFont, Brushes.Black, 25, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 80, y, 90, 25);
                e.Graphics.DrawString(row.Cells["VehicleNo"].Value?.ToString(), rowFont, Brushes.Black, 85, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 170, y, 140, 25);
                e.Graphics.DrawString(row.Cells["PartyName"].Value?.ToString(), rowFont, Brushes.Black, 175, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 310, y, 140, 25);
                e.Graphics.DrawString(row.Cells["ProductName"].Value?.ToString(), rowFont, Brushes.Black, 315, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 450, y, 70, 25);
                e.Graphics.DrawString(row.Cells["FirstWeight"].Value?.ToString(), rowFont, Brushes.Black, 455, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 520, y, 70, 25);
                e.Graphics.DrawString(row.Cells["SecondWeight"].Value?.ToString(), rowFont, Brushes.Black, 525, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 590, y, 70, 25);
                e.Graphics.DrawString(row.Cells["NetWeight"].Value?.ToString(), rowFont, Brushes.Black, 595, y + 5);

                e.Graphics.DrawRectangle(Pens.Black, 660, y, 90, 25);
                e.Graphics.DrawString(row.Cells["CashReceipt"].Value?.ToString(), rowFont, Brushes.Black, 665, y + 5);

                y += 25;
            }
            y += 20;

            Font totalFont = new Font("Segoe UI", 10, FontStyle.Bold);

            e.Graphics.DrawString(
                "Total Records : " + lblTotalRecords.Text.Replace("Total Records : ", ""),
                totalFont,
                Brushes.Black,
                20,
                y);

            e.Graphics.DrawString(
                "Total Cash : " + lblTotalCash.Text.Replace("Total Cash : ", ""),
                totalFont,
                Brushes.Black,
                300,
                y);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.Margins = new
                System.Drawing.Printing.Margins(30, 30, 30, 30);
            printPreviewDialog1.ShowDialog();
        }
    }
}
