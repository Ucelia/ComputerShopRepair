using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopRepair
{
    public partial class customerRequest : Form
    {
        public customerRequest()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=LUZLtd;Integrated Security=True");
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void orderDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.orderDgv.Rows[e.RowIndex];
            fullNameBox.Text = row.Cells["fullName"].Value.ToString();
            compModelCombo.SelectedValue = row.Cells["computerModel"].Value.ToString();
        }

        private void displayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM sales", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "sales");
            orderDgv.DataSource = ds.Tables["sales"];
        }

        private void customerRequest_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from sales", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            orderDgv.DataSource = dt;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO sales VALUES ('" + fullNameBox.Text + "','" + compModelCombo.SelectedValue + "')";
                SqlCommand command = new SqlCommand(query, con);
                int cmd = (int)command.ExecuteNonQuery();
                if (cmd != 1)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Order sent successfully");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void compModelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fullNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void repairBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
