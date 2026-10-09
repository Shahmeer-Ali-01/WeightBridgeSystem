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
    public partial class PartyList : Form
    {
        public PartyList()
        {
            InitializeComponent();
        }

        private void PartyList_Load(object sender, EventArgs e)
        {
            dgvParty.ColumnHeadersDefaultCellStyle.Font =
               new Font("Segoe UI", 11, FontStyle.Bold);

            dgvParty.ColumnHeadersHeight = 40;

            dgvParty.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvParty.DefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);

            dgvParty.RowTemplate.Height = 32;

            dgvParty.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            LoadParty();
        }

        private void LoadParty()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = @"
SELECT
PartyCode,
PartyName
FROM Parties
ORDER BY PartyCode";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvParty.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPartyCode.Text == "" || txtPartyName.Text == "")
            {
                MessageBox.Show("Please enter Party Code and Party Name.");
                return;
            }

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM Parties WHERE PartyCode=@Code";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@Code", txtPartyCode.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Party Code already exists.");
                    return;
                }

                string insertQuery = "INSERT INTO Parties(PartyCode,PartyName) VALUES(@Code,@Name)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@Code", txtPartyCode.Text);
                cmd.Parameters.AddWithValue("@Name", txtPartyName.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Party Added Successfully.");

                txtPartyCode.Clear();
                txtPartyName.Clear();

                LoadParty();
                txtPartyCode.Focus();
            }
        }

        private void PartyList_Click(object sender, EventArgs e)
        {

        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPartyCode.Text.Trim() == "" || txtPartyName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Party Code and Party Name.");
                return;
            }

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                // Check if another party already has this Party Code
                string checkQuery = @"
SELECT COUNT(*)
FROM Parties
WHERE PartyCode = @Code
AND PartyName <> @OldName";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@Code", txtPartyCode.Text.Trim());
                checkCmd.Parameters.AddWithValue("@OldName",
                    dgvParty.CurrentRow.Cells["PartyName"].Value.ToString());

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Party Code already exists.\nPlease use another Party Code.");
                    return;
                }

                string updateQuery = @"
UPDATE Parties
SET PartyCode=@Code,
    PartyName=@Name
WHERE PartyName=@OldName";

                SqlCommand cmd = new SqlCommand(updateQuery, con);

                cmd.Parameters.AddWithValue("@Code", txtPartyCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtPartyName.Text.Trim());
                cmd.Parameters.AddWithValue("@OldName",
                    dgvParty.CurrentRow.Cells["PartyName"].Value.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Party Updated Successfully.");

                txtPartyCode.Clear();
                txtPartyName.Clear();

                LoadParty();

                txtPartyCode.Focus();
            }
        }

        private void dgvParty_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPartyCode.Text =
                    dgvParty.Rows[e.RowIndex].Cells["PartyCode"].Value.ToString();
                txtPartyName.Text = dgvParty.Rows[e.RowIndex].Cells["PartyName"].Value.ToString();
            }
        }
    }
}
