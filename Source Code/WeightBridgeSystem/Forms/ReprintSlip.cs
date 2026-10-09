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
    public partial class ReprintSlip : Form
    {
        public ReprintSlip()
        {
            InitializeComponent();
        }

        private void ReprintSlip_Load(object sender, EventArgs e)
        {
            txtSrNo.Clear();
            txtSrNo.Focus();
        }

        private void txtSrNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSrNo.Text))
            {
                MessageBox.Show("Please Enter Sr Number.",
                    "Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSrNo.Focus();
                return;
            }
            PrintSlip frm = new PrintSlip();
            frm.SrNo = Convert.ToInt32(txtSrNo.Text);
            frm.ReprintSlip(false);
        }
        
    }
}
