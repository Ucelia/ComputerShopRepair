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
using System.Security.Cryptography;

namespace ComputerShopRepair
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=LUZLtd;Integrated Security=True");

        private const string _salt = "Fghjfghjkghjmgnk57gk9oHnj";
        private const string _alg = "HmacSHA256";

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string enteredPassword = passwordBox.Text;

            if (managerCheck.Checked)
            {
                LoginAsManager();
            }
            else if (staffCheck.Checked)
            {
                LoginAsStaff();
            }
            else
            {
                LoginAsCustomer(email, enteredPassword);
            }
        }
            private void LoginAsManager()
        {
            try
            {
                string query = "SELECT * FROM manager WHERE email = '" + emailBox.Text + "' AND password = '" + passwordBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Manager login successful!");

                    //new customerRequest().Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Manager login failed. Please check your credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoginAsStaff()
        {
            try
            {
                string query = "SELECT * FROM staff WHERE email = '" + emailBox.Text + "' AND password = '" + passwordBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Staff login successful!");

                    //new ViewRequests().Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Staff login failed. Please check your credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoginAsCustomer(string email, string enteredPassword)
        {
            string storedPasswordHash = GetStoredCustomerPasswordHash(email);

            if (storedPasswordHash != null)
            {
                string enteredPasswordHash = GetHashedPassword(enteredPassword);

                if (storedPasswordHash == enteredPasswordHash)
                {
                    MessageBox.Show("Student login successful!");

                    new customerRequest().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Student login failed. Please check your credentials.");
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
            con.Close();
        }

        private string GetStoredCustomerPasswordHash(string email)
        {
            con.Open();
            string query = "SELECT password FROM customer WHERE email = @email";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@email", email);
                object result = command.ExecuteScalar();
                return result as string;
            }
        }
        public static string GetHashedPassword(string password)
        {
            string key = string.Join(":", new string[] { password, _salt });

            using (HMAC hmac = HMACSHA256.Create(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(_salt);
                hmac.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(hmac.Hash);
            }
        }

    }
}
