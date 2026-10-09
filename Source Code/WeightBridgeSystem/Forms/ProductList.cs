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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgvProducts.ColumnHeadersHeight = 40;

            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.DefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);

            dgvProducts.RowTemplate.Height = 32;

            dgvProducts.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = @"
SELECT
ProductCode,
ProductName
FROM Products
ORDER BY ProductCode";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvProducts.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "" || txtProductName.Text == "")
            {
                MessageBox.Show("Please enter Product Code and Product Name.");
                return;
            }

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM Products WHERE ProductCode=@Code";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@Code", txtProductCode.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Product Code already exists.");
                    return;
                }

                string insertQuery = "INSERT INTO Products(ProductCode,ProductName) VALUES(@Code,@Name)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@Code", txtProductCode.Text);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added Successfully.");

                txtProductCode.Clear();
                txtProductName.Clear();

                LoadProducts();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtProductCode.Text =
                    dgvProducts.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
                txtProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            }
        }

        
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (txtProductCode.Text.Trim() == "" || txtProductName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Product Code and Product Name.");
                    return;
                }

                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();

                    // Check if another product already has this Product Code
                    string checkQuery = @"
SELECT COUNT(*)
FROM Products
WHERE ProductCode = @Code
AND ProductName <> @OldName";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                    checkCmd.Parameters.AddWithValue("@Code", txtProductCode.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@OldName", dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString());

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Product Code already exists.\nPlease use another Product Code.");
                        return;
                    }

                    string updateQuery = @"
UPDATE Products
SET ProductCode=@Code,
    ProductName=@Name
WHERE ProductName=@OldName";

                    SqlCommand cmd = new SqlCommand(updateQuery, con);

                    cmd.Parameters.AddWithValue("@Code", txtProductCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                    cmd.Parameters.AddWithValue("@OldName", dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Updated Successfully.");

                    txtProductCode.Clear();
                    txtProductName.Clear();

                    LoadProducts();

                    txtProductCode.Focus();
                }
        }

        private void ProductList_Click(object sender, EventArgs e)
        {

        }
    }
}
