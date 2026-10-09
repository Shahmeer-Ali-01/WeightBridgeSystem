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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThirdWeight_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
                pnlMain.Top = (this.ClientSize.Height - pnlMain.Height) / 2;
            timerDateTime.Start();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "Date :" + DateTime.Now.ToString("dd-MMM-yyyy");
            lblTime.Text = "Time :" + DateTime.Now.ToString("hh-mm-sstt");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirstWeight_Click(object sender, EventArgs e)
        {
            FirstWeight frm = new FirstWeight();
            frm.Show();
        }

        private void btnSecondWeight_Click(object sender, EventArgs e)
        {
            SecondWeight frm = new SecondWeight();
            frm.Show();
        }

        private void btnThirdWeight_Click_1(object sender, EventArgs e)
        {
            ThirdWeight frm = new ThirdWeight();
            frm.Show();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyWeightment frm = new DailyWeightment();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReprintSlip frm = new ReprintSlip();
            frm.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductList frm = new ProductList();
            frm.Show();
        }

        private void btnPartyList_Click(object sender, EventArgs e)
        {
            PartyList frm = new PartyList();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWeight.Text = LiveWeight.CurrentWeight;
        }
    }
}
