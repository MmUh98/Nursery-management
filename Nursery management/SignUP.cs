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
using System.Net.NetworkInformation;

namespace Nursery_management
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\manso\\Documents\\LoginDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && last_name.Text != "" && date.Text != "" && gender.Text != "" && email.Text != "" &&
                    address.Text != "" && password.Text != "" && con_password.Text != "") {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into Registration values(@first_name, @last_name, @date, @gender, @email, @address, @password)", connection);
                            command.Parameters.AddWithValue("@first_name", first_name.Text);
                            command.Parameters.AddWithValue("@last_name", last_name.Text);
                            command.Parameters.AddWithValue("@date", date.Text);
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@password", password.Text);

                            command.ExecuteNonQuery();
                            string query = "select * from Registration where email = @email";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@email", email);
                            connection.Close();
                            MessageBox.Show("Registration Successful");
                            first_name.Text = "";
                            last_name.Text = "";
                            date.Text = "";
                            gender.Text = "";
                            email.Text = "";
                            address.Text = "";
                            password.Text = "";
                            con_password.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Yor are already redistered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string email)
        {
            connection.Open();
            string query = "select * from Registration where email = '" + email + "'";
            SqlCommand command = new SqlCommand(query, connection); 
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
                con_password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignIn form1 = new SignIn();
            form1.Show();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void con_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
