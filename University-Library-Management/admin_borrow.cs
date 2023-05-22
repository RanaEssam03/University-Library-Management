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

namespace University_Library_Management
{
    
    public partial class admin_borrow : Form
    {
        private SqlConnection _connection;
        private string isbn;
        private bool _validEmail = true;
        private bool _validISBN = true;

        public admin_borrow()
        {
            this.isbn = isbn;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            email_borrow.Text = ((System.Windows.Forms.TextBox)sender).Text;
            Regex rg = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            _validEmail = rg.IsMatch(email_borrow.Text);
            if (!_validEmail)
                error_text.Text = "Email invalid";
            else
                error_text.Text = "";

            if (_validEmail)
            {
                _connection.Open();
                string sqlQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @email AND ROLE = 'Student'";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@email", email_borrow.Text);
                SqlDataReader reader = Command.ExecuteReader();
                if (!reader.Read())
                {
                    _validISBN = false;
                    error_text.Text = "This Email is not found in the system";
                }
               
                _connection.Close();
            }
        }

        private void dt1_borrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void add_vis_Click(object sender, EventArgs e)
        {

            if (_validEmail && _validISBN)
            {
                try {
                    _connection.Open();
                    string sqlQuery2 = "INSERT INTO BORROW ([EMAIL],[ISBN],[START_DATE],[END_DATE]) VALUES (@email,@isbn,@start,@end)";
                    SqlCommand Command2 = new SqlCommand(sqlQuery2, _connection);
                    Command2.Parameters.AddWithValue("@email", email_borrow.Text);
                    Command2.Parameters.AddWithValue("@isbn", ISBNfield.Text);
                    Command2.Parameters.AddWithValue("@start", dt1_borrow.Value);
                    Command2.Parameters.AddWithValue("@end", dt2_borrow.Value);
                    Command2.ExecuteNonQuery();                    
                    _connection.Close();
                    Form admin_main = new admin_main_screen();
                    Hide();
                    admin_main.Show();
                    _connection.Open();
                    string sqlQuery = "UPDATE BOOK SET AMOUNT = AMOUNT - 1 WHERE ISBN = @isbn";
                    SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                    Command.Parameters.AddWithValue("@isbn", ISBNfield.Text);
                    Command.ExecuteNonQuery();
                    _connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"^[0-9]{13}$");
            _validISBN = rg.IsMatch(ISBNfield.Text);
            if (!_validISBN)
                error_text.Text = "ISBN invalid";
            else
                error_text.Text = "";

            if (_validISBN)
            {
                _connection.Open();
                string sqlQuery = "SELECT AMOUNT FROM [BOOK] WHERE ISBN = @isbn";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@isbn", ISBNfield.Text);

                SqlDataReader reader = Command.ExecuteReader();
                if (!reader.Read())
                {
                    _validISBN = false;
                    error_text.Text = "This ISBN is not found in the system";
                }
                else
                {
                    int amount = reader.GetInt32(0);
                    if(amount < 1)
                    {
                        error_text.Text = "This book is not available";
                        _validISBN = false;
                    }

                }
                _connection.Close();
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new view_borrow();
            Hide();
            form.Show();
        }
    }
}
