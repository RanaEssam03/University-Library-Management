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
    public partial class view_books : Form
    {
        SqlConnection _conn;
        String _email;
        public view_books(string email="")
        {
            InitializeComponent();
            _email = email;

            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            this._conn = new SqlConnection(connString1);


        }

        private void view_books_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT BOOK.ISBN, TITLE, AUTHOR ,CATEGORY, AMOUNT, AVG(RATING) AS RATING FROM BOOK Left JOIN BOOK_RATING " +
                    "ON BOOK.ISBN = BOOK_RATING.ISBN " +
                "GROUP BY BOOK.ISBN , TITLE , AUTHOR , CATEGORY , AMOUNT";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catalog.DataSource = dt;
                _conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void catalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

            try {
                _conn.Open();

                string searchText = searchBox.Text;

                string sqlQuery = "SELECT BOOK.ISBN, TITLE, AUTHOR ,CATEGORY, AMOUNT, AVG(RATING) AS RATING FROM BOOK Left JOIN BOOK_RATING " +
                    "ON BOOK.ISBN = BOOK_RATING.ISBN " +
                "where  TITLE  Like \'%"+  searchText +"%\' OR BOOK.ISBN Like \'%"+  searchText +"%\' OR Author Like \'%"+  searchText + "%\' OR CATEGORY Like \'%" +  searchText +"%\'   "+
                "GROUP BY BOOK.ISBN , TITLE , AUTHOR , CATEGORY , AMOUNT";
                SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
                cmd.Parameters.AddWithValue("@text", searchText);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
             
                catalog.DataSource = dt;
                _conn.Close();
            }
            catch (Exception ex)
            {
                _conn.Close();

                MessageBox.Show(ex.Message);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new student_main_screen(_email);
            Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new BookRate(_email);
            Hide();
            form.Show();
        }
    }
}
