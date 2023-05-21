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
    public partial class add_book : Form
    {
        private SqlConnection _connection;
        private bool _validTitle = false;
        private string _title = string.Empty;
        private bool _validISBN = false;
        private string _isbn = string.Empty;
        private bool _validAuthor = false;
        private bool _validCategory = false;
        public add_book()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void authorField_TextChanged(object sender, EventArgs e)
        {
            authorField.Text = ((TextBox)sender).Text;  
            Regex rg = new Regex(@"^[a-zA-Z ]+$");
            _validAuthor = rg.IsMatch(authorField.Text);
            if (!_validAuthor)
                error_text.Text = "Author name can't contain numbers or symbols.";
            else
                error_text.Text = "";
        }

        private void ISBNfield_TextChanged(object sender, EventArgs e)
        {
            ISBNfield.Text = ((TextBox)sender).Text;
            Regex rg = new Regex(@"^[0-9]{13}$");
            _validISBN = rg.IsMatch(ISBNfield.Text);
            if (!_validISBN)
                error_text.Text = "ISBN invalid";
            else
                error_text.Text = "";

            if( _validISBN )
            {
                _connection.Open();
                string sqlQuery = "SELECT * FROM [BOOK] WHERE ISBN = @isbn";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@isbn", ISBNfield.Text);

                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    _validISBN = false;
                    error_text.Text = "This ISBN is already assigned to another book";
                }
                _connection.Close();
            }
        }

        private void category_TextChanged(object sender, EventArgs e)
        {
            category.Text = ((TextBox)sender).Text;
            Regex rg = new Regex(@"^[a-zA-Z ]+$");
            _validCategory = rg.IsMatch(authorField.Text);
            if (!_validCategory)
                error_text.Text = "Category name can't contain numbers or symbols";
            else
                error_text.Text = "";
        }

        private void title_field_TextChanged(object sender, EventArgs e)
        {
            title_field.Text = ((TextBox)sender).Text;
            Regex rg = new Regex(@"^[a-zA-Z ]+$");
            _validTitle = rg.IsMatch(title_field.Text);
            if (!_validTitle)
                error_text.Text = "Title name can't contain numbers or symbols";
            else
                error_text.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if( _validISBN && _validAuthor && _validCategory && _validTitle) 
            {
                _connection.Open();
                try
                {
                    string sqlInsert = "INSERT INTO [BOOK] (ISBN, TITLE, AUTHOR, CATEGORY, PUBLICATION_YEAR, AMOUNT)" +
                        "VALUES(@isbn, @title, @author, @category, @year, @amount)";
                    SqlCommand sqlCommand = new SqlCommand(sqlInsert, _connection);
                    sqlCommand.Parameters.AddWithValue("@isbn", ISBNfield.Text);
                    sqlCommand.Parameters.AddWithValue("@title", title_field.Text);
                    sqlCommand.Parameters.AddWithValue("@author", authorField.Text);
                    sqlCommand.Parameters.AddWithValue("@category", category.Text);
                    sqlCommand.Parameters.AddWithValue("@year", publicationYear.Value);
                    sqlCommand.Parameters.AddWithValue("@amount", amountField.Value);
                    

                    sqlCommand.ExecuteNonQuery();
                    _connection.Close();

                    Form form = new view_and_edit_books();
                    Hide();
                    form.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                _connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new view_and_edit_books();
            Hide();
            form.Show();
        }
    }
}
