using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library_Management
{
    public partial class student_sign_in : Form
    {
        private SqlConnection _connection;
        public student_sign_in()
        {
            InitializeComponent();
            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;


            _connection = new SqlConnection(connString1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string sqlQuery = "SELECT PASSWORD FROM \"USER\" WHERE EMAIL = @email AND PASSWORD = @password";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@email", email.Text);
                Command.Parameters.AddWithValue("@password", password.Text);

                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    error.Text = "";
                    Form form = new student_main_screen();
                    Hide();
                    form.Show();

                }
                else
                {
                    error.Text = "Invalid credentials";

                }
                _connection.Close();
            }
            catch(Exception ex)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_sign_in_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new student_form();
            Hide();
            form.Show();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new student_sign_upcs();
            Hide();
            form.Show();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
