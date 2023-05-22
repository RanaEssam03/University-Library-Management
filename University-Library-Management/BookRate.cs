using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace University_Library_Management
{
    public partial class BookRate : Form
    {
        private SqlConnection _connection;
        string email;
        public BookRate(string email)
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
            this.email = email;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookRate_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                Rate.Items.Add(i);
            }
            Email.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = ISBN.Text;
            string comment = Comment.Text;
            string rate = Rate.Text;

            string sqlQuery = "SELECT * FROM BOOK WHERE ISBN = @ISBN";
            SqlCommand Command = new SqlCommand(sqlQuery, _connection);
            Command.Parameters.AddWithValue("@ISBN", isbn);
            _connection.Open();
            MessageBox.Show("HEREEe");
            SqlDataReader reader = Command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Invalid ISBN");

                return;
            }

            if (rate == "")
            {

                MessageBox.Show("Rating is required");

                return;
            }

            _connection.Close();
            try
            {
                _connection.Open();
                string sqlInsert = "INSERT INTO BOOK_RATING (EMAIL, ISBN, COMMENT, RATING)" +
                    "VALUES(@email, @isbn, @comment, @rating)";
                SqlCommand sqlCommand = new SqlCommand(sqlInsert, _connection);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@isbn", isbn);
                sqlCommand.Parameters.AddWithValue("@comment", comment);
                sqlCommand.Parameters.AddWithValue("@rating", rate);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Done!");
                Form form = new view_books();
                _connection.Close();

                Hide();
                form.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
