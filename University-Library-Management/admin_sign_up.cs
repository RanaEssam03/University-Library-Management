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
    public partial class admin_sign_up : Form
    {

        private SqlConnection _connection;


        public admin_sign_up()
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

        private void signUp_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            bool flag = true;
            _connection.Open();
            try
            {

                string sqlQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @email";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@email", Email.Text);

                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("This email is already associated with an account.");
                    Form form = new admin_sign_in();
                    Hide();
                    form.Show();

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            _connection.Close();

            if (Password.Text != confirmPassword.Text)
            {
                flag = false;
                passwordError.Text = "Passwords do NOT match";
            }
            else
            {
                if (Password.Text.Length < 8)
                {
                    flag = false;
                    passwordError.Text = "At least 8 characters LONG or more";
                }
            }

            if (!validateEmailRegex.IsMatch(Email.Text))
            {
                flag = false;
                emailError.Text = "Invalid Email";
            }

            if (flag)
            {
                _connection.Open();
                try
                {
                    
                    string sqlInsert = "INSERT INTO \"USER\"(EMAIL, PASSWORD, FIRST_NAME, LAST_NAME, ROLE)" +
                        "VALUES(@email, @password, @first_name, @last_name, \'Admin\')";
                    SqlCommand sqlCommand = new SqlCommand(sqlInsert, _connection);
                    sqlCommand.Parameters.AddWithValue("@email", Email.Text);
                    sqlCommand.Parameters.AddWithValue("@password", Encryption.Hashstring(Password.Text));
                    sqlCommand.Parameters.AddWithValue("@first_name", firstName.Text);
                    sqlCommand.Parameters.AddWithValue("@last_name", lastName.Text);

                    sqlCommand.ExecuteNonQuery();
                    

                    Form form = new admin_sign_in();
                    Hide();
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                _connection.Close();
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void memberAlready_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new admin_sign_in();
            Hide();
            form.Show();
        }

        private void admin_sign_up_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new admin_form();
            Hide();
            form.Show();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
