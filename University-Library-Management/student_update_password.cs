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

namespace University_Library_Management
{
    public partial class student_update_password : Form
    {
        string _email;
        string _oldPassword;
        SqlConnection _conn;
        public student_update_password(string email)
        {
            InitializeComponent();
            this._email = email;

            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            this._conn = new SqlConnection(connString1);


            string sqlQuery = "SELECT PASSWORD FROM \"USER\" WHERE EMAIL = @email";
            SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
            _conn.Open();
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this._oldPassword = reader[0].ToString();
            }
            _conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oldPsswordError.Text = string.Empty;
            newPasswordError.Text = string.Empty;
            oldPsswordError.Text = string.Empty;
            if (currentPassword.Text != this._oldPassword)
            {
                oldPsswordError.Text = "Wrong Password";
            }
            if(newPassword.Text != confirmNewPassword.Text)
            {
                newPasswordError.Text = "Passwords do NOT match";
            }
            if(newPassword.Text ==  confirmNewPassword.Text && currentPassword.Text == this._oldPassword)
            {
                if(newPassword.Text.Length < 8)
                {
                    newPasswordError.Text = "At least 8 characters LONG or more";

                }
                else
                {
                    string sqlQuery = "UPDATE \"USER\" SET PASSWORD = @password Where EMAIL = @email ";
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
                    cmd.Parameters.AddWithValue("@password", newPassword.Text);
                    cmd.Parameters.AddWithValue("@email", _email);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                    MessageBox.Show("Updated Successfully!");
                    Form form = new student_update_info(_email);
                    Hide();
                    form.Show();

                }
            }

        }

        private void student_update_password_Load(object sender, EventArgs e)
        {
            oldPsswordError.Text = string.Empty;
            newPasswordError.Text = string.Empty;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new student_update_info(_email);
            Hide();
            form.Show();
        }
    }
}
