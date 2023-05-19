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
    public partial class student_update_info : Form
    {
      
        private string _email;
        private SqlConnection _conn;

        public student_update_info(string email)
        {
         
            this.Set_email(email);
            InitializeComponent();

            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            this._conn = new SqlConnection(connString1);


            string sqlQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @email";
            SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
            cmd.Parameters.AddWithValue("@email", email);
            _conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            EmailText.Text = email;
            if(reader.Read()) { 
                     first_name.Text = reader[2].ToString();
                     last_name.Text = reader[3].ToString();
                        
                   
                        year.Text = reader[5].ToString();
                 
                        this.password.Text = reader[1].ToString();   

            }
            _conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new student_update_password(_email);
            Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstNameError.Text = string.Empty;
            lastNameError.Text = string.Empty;
            yearError.Text = string.Empty;
            if(first_name.Text == string.Empty)
            {
                firstNameError.Text = "Can't Be Empty";

            }
            if(last_name.Text == string.Empty)
            {
                lastNameError.Text = "Can't Be Empty";
            }
            if(year.Text != "1" && year.Text != "2" && year.Text != "3" && year.Text != "4" && year.Text != "5" && year.Text != string.Empty)
            {
                yearError.Text = "Invalid Year";
            }
            else
            {
                if(first_name.Text != string.Empty && last_name.Text != string.Empty)
                {
                    string sqlQuery = "UPDATE \"USER\" SET FIRST_NAME = @fname , LAST_NAME= @lname , YEAR = year Where EMAIL = @email ";
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
                    cmd.Parameters.AddWithValue("@fname", first_name.Text);
                    cmd.Parameters.AddWithValue("@lname", last_name.Text);
                    cmd.Parameters.AddWithValue("@email", _email);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                    MessageBox.Show("Updated Successfully!");


                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void student_update_info_Load(object sender, EventArgs e)
        {
            firstNameError.Text = string.Empty;
            lastNameError.Text = string.Empty;
            yearError.Text = string.Empty;

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        public string Get_email()
        {
            return _email;
        }

        public void Set_email(string value)
        {
            _email = value;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
