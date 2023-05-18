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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string sqlInsert = "INSERT INTO \"USER\"(EMAIL, PASSWORD, FIRST_NAME, LAST_NAME, ROLE)" +
                    "VALUES(@email, @password, @first_name, @last_name, \'Student\')";
                SqlCommand sqlCommand = new SqlCommand(sqlInsert, conn);
                sqlCommand.Parameters.AddWithValue("@email", email_input.Text);
                sqlCommand.Parameters.AddWithValue("@password", password_input.Text);
                sqlCommand.Parameters.AddWithValue("@first_name", first_name_input.Text);
                sqlCommand.Parameters.AddWithValue("@last_name", last_name_input.Text) ;
                
                sqlCommand.ExecuteNonQuery();
                Hide();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
