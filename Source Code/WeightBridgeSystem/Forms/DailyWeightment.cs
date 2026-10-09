using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightBridgeSystem.Forms
{
    public partial class DailyWeightment : Form
    {
        public DailyWeightment()
        {
            InitializeComponent();
        }

        private void DailyWeightment_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            dtpFromDate.Focus();
        }

        private void dtpFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                dtpToDate.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void dtpToDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnView.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value.Date>dtpToDate.Value.Date)
            {
                MessageBox.Show("From Date is Cannot be greater than To Date",
                  "Invalid Date",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
                    }
            
            DailyWeightmentReport frm = new DailyWeightmentReport();
            frm.FromDate = dtpFromDate.Value.Date;
            frm.ToDate = dtpToDate.Value.Date;
            frm.ShowDialog();
        }
    }
}
