using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace University_Library_Management
{
    public partial class student_sign_upcs : Form
    {
        private SqlConnection _connection;
        public student_sign_upcs()
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

        private void student_sign_upcs_Load(object sender, EventArgs e)
        {
            passwordError.Text = string.Empty;
            emailError.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            bool flag = true;

            _connection.Open();
            string sqlQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @email";
            SqlCommand Command = new SqlCommand(sqlQuery, _connection);
            Command.Parameters.AddWithValue("@email", email_input.Text);

            SqlDataReader reader = Command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("This email is already associated with an account.");
                Form form = new  student_sign_in();
                Hide();
                form.Show();

            }

            if (password_input.Text != confirm_password_input.Text)
            {
                flag = false;
                passwordError.Text = "Passwords do NOT match";
            }
            else
            {
                if(password_input.Text.Length < 8)
                {
                    flag = false;
                    passwordError.Text = "At least 8 characters LONG or more";
                }
            }

            if (!validateEmailRegex.IsMatch(email_input.Text))
            {
                flag = false;
                emailError.Text = "Invalid Email";
            }

            if (flag)
            {
                try
                {
                    _connection.Open();
                    string sqlInsert = "INSERT INTO \"USER\"(EMAIL, PASSWORD, FIRST_NAME, LAST_NAME, ROLE)" +
                        "VALUES(@email, @password, @first_name, @last_name, \'Student\')";
                    SqlCommand sqlCommand = new SqlCommand(sqlInsert, _connection);
                    sqlCommand.Parameters.AddWithValue("@email", email_input.Text);
                    sqlCommand.Parameters.AddWithValue("@password", password_input.Text);
                    sqlCommand.Parameters.AddWithValue("@first_name", first_name_input.Text);
                    sqlCommand.Parameters.AddWithValue("@last_name", last_name_input.Text);

                    sqlCommand.ExecuteNonQuery();
                    _connection.Close();

                    Form form = new student_sign_in();
                    Hide();
                    form.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailError_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new student_form();
            Hide();
            form.Show();
        }

        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordError_Click(object sender, EventArgs e)
        {

        }

        private void first_name_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
