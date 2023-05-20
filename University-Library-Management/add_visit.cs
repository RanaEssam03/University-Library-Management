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
    public partial class add_visit : Form
    {
        private SqlConnection _connection;
        public add_visit()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void start_date_Click(object sender, EventArgs e)
        {

        }

        private void add_visit_Load(object sender, EventArgs e)
        {

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_vis_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string sqlQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @email AND ROLE = 'Student'";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@email",email_input.Text);
                SqlDataReader reader = Command.ExecuteReader();
                
                if (reader.Read())
                {
                    _connection.Close();
                    _connection.Open();
                    string sqlQuery2 = "INSERT INTO VISIT ([EMAIL],[START],[END]) VALUES (@email,@start,@end)";
                    SqlCommand Command2 = new SqlCommand(sqlQuery2, _connection);
                    Command2.Parameters.AddWithValue("@email", email_input.Text);
                    Command2.Parameters.AddWithValue("@start", dt1.Value);
                    Command2.Parameters.AddWithValue("@end", dt2.Value);
                    Command2.ExecuteNonQuery();
                    Form admin_main = new admin_main_screen();
                    Hide();
                    admin_main.Show();
                    _connection.Close();
                }
                else
                {
                    _connection.Close();
                    error.Text = "Student Not Found";
                }
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
