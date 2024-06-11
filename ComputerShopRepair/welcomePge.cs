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
    public partial class welcomePge : Form
    {
        public welcomePge()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-93jchrb\sqlexpress;Initial Catalog=LUZLtd;Integrated Security=True");
        private void welcomePge_Load(object sender, EventArgs e)
        {

        }
        private const string _alg = "HmacSHA256";
        private const string _salt = "Fghjfghjkghjmgnk57gk9oHnj";
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

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (emailBox.Text.Contains("@gmail.com"))
            {
                Boolean active = true;
                if (active)
                {
                    String query = "INSERT INTO customer VALUES('" + fullNameBox.Text + "','" + emailBox.Text + "','" + GetHashedPassword(passwordBox.Text) + "','" + compModelCombo.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    con.Open();
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Registered Successfully");
                    fullNameBox.Text = "";
                    emailBox.Text = "";
                    passwordBox.Text = "";
                    compModelCombo.Text = "";
                }
                else
                {
                    MessageBox.Show(" Not Registered");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid email");
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.ShowDialog();
        }
    }
}
