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

namespace Nursery_management
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\manso\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(u_name.Text != "" && password.Text != "")
            {
                string query = "SELECT * FROM RegistrationTbl WHERE email = '" + u_name.Text + "' AND password = '" + password.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int) command.ExecuteScalar();
                if(v != 1)
                {
                    MessageBox.Show("Invalid username or password");
                }
                else
                {
                    MessageBox.Show("Login successful");
                    u_name.Text = "";
                    password.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUP form1 = new SignUP(); 
            this.Hide();
            form1.Show();
        }
    }
}
