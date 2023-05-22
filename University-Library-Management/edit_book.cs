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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace University_Library_Management
{
    public partial class edit_book : Form
    {
        private string isbn;
        private SqlConnection _connection;
        private bool _validTitle = true;
        private bool _validCategory = true;
        private bool _validAuthor = true;

        public edit_book(string isbn)
        {
            InitializeComponent();
            this.isbn = isbn;
            var datasource = @"nour-fcai-assignments.database.windows.net";
            var database = "UniversityLibrarySystem";
            var username = "admon";
            var password = "DB1234pass";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            _connection = new SqlConnection(connString);

            try
            {
                _connection.Open();
                string sqlSelectQuery = "SELECT * FROM [BOOK] WHERE ISBN = @selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, _connection);
                command.Parameters.AddWithValue("@selectedRowId", isbn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    title_field.Text = reader[0].ToString();
                    authorField.Text = reader[2].ToString();
                    category.Text = reader[3].ToString();
                    publicationYear.Value = reader.GetDateTime(4);
                    amountField.Value = reader.GetInt32(5);
                }
                _connection.Close();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new choose_book();
            Hide();
            form.Show();
        }

        private void title_field_TextChanged(object sender, EventArgs e)
        {
            title_field.Text = ((System.Windows.Forms.TextBox)sender).Text;
            Regex rg = new Regex(@"^[a-zA-Z ]+$");
            _validTitle = rg.IsMatch(title_field.Text);
            if (!_validTitle)
                error_text.Text = "Title name can't contain numbers or symbols";
            else
                error_text.Text = "";
        }

        private void category_TextChanged(object sender, EventArgs e)
        {
            category.Text = ((System.Windows.Forms.TextBox)sender).Text;
            Regex rg = new Regex(@"^[a-zA-Z ]+$");
            _validCategory = rg.IsMatch(category.Text);
            if (!_validCategory)
                error_text.Text = "Category name can't contain numbers or symbols";
            else
                error_text.Text = "";
        }

        private void authorField_TextChanged(object sender, EventArgs e)
        {
            authorField.Text = ((System.Windows.Forms.TextBox)sender).Text;
            Regex rg = new Regex(@"^[a-zA-Z ]+$");
            _validAuthor = rg.IsMatch(authorField.Text);
            if (!_validAuthor)
                error_text.Text = "Author name can't contain numbers or symbols.";
            else
                error_text.Text = "";
        }   

        private void edit_Click(object sender, EventArgs e)
        {
            if(_validAuthor && _validCategory && _validTitle)
            {
                _connection.Open();
                try
                {
                    string sqlInsert = "UPDATE [BOOK]"
                        + "SET TITLE = @title, AUTHOR = @author, PUBLICATION_YEAR = @year, AMOUNT = @amount, CATEGORY = @category "
                        + "WHERE ISBN = @isbn";
                    SqlCommand sqlCommand = new SqlCommand(sqlInsert, _connection);
                    sqlCommand.Parameters.AddWithValue("@title", title_field.Text);
                    sqlCommand.Parameters.AddWithValue("@author", authorField.Text);
                    sqlCommand.Parameters.AddWithValue("@category", category.Text);
                    sqlCommand.Parameters.AddWithValue("@year", publicationYear.Value);
                    sqlCommand.Parameters.AddWithValue("@amount", amountField.Value);
                    sqlCommand.Parameters.AddWithValue("@isbn", isbn);


                    sqlCommand.ExecuteNonQuery();

                    Form form = new view_and_edit_books();
                    Hide();
                    form.Show();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                _connection.Close();
            }
        }
    }
}
