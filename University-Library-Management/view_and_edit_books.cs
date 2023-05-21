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
    public partial class view_and_edit_books : Form
    {
        SqlConnection _conn;
        public view_and_edit_books()
        {
            InitializeComponent();

            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            this._conn = new SqlConnection(connString1);


        }

        private void view_and_edit_books_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT ISBN, TITLE, AUTHOR ,CATEGORY, AMOUNT FROM BOOK";
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
            catch (Exception) { }

        }

        private void catalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                _conn.Open();

                string searchText = searchBox.Text;

                string sqlQuery = "SELECT ISBN, TITLE, AUTHOR ,CATEGORY, AMOUNT FROM BOOK " +
                "where  TITLE  Like \'%" + searchText + "%\' OR ISBN Like \'%" + searchText + "%\' OR Author Like \'%" + searchText + "%\' OR CATEGORY Like \'%" + searchText + "%\'   ";
                SqlCommand cmd = new SqlCommand(sqlQuery, _conn);
                cmd.Parameters.AddWithValue("@text", searchText);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                catalog.DataSource = dt;
                _conn.Close();
            }
            catch (Exception) { }

        }

        private void add_book_Click(object sender, EventArgs e)
        {
            Form form = new add_book();
            Hide();
            form.Show();
        }
    }
}
