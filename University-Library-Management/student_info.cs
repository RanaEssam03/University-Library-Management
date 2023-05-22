using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_Library_Management
{
    public partial class student_info : Form
    {
        string _email;
        public student_info(string email)
        {
            InitializeComponent();
            this._email = email;
        }

        private void loadFirstGrid()
        {
            var datasource = @"nour-fcai-assignments.database.windows.net";
            var database = "UniversityLibrarySystem";
            var username = "admon";
            var password = "DB1234pass";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string sqlSelectQuery = "SELECT ISBN,START_DATE,END_DATE FROM \"BORROW\" WHERE EMAIL =@selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, conn);
                command.Parameters.AddWithValue("@selectedRowId", _email);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }

            catch (Exception )
            {
             
            }
        }

        private void loadSecondGrid()
        {
            var datasource = @"nour-fcai-assignments.database.windows.net";
            var database = "UniversityLibrarySystem";
            var username = "admon";
            var password = "DB1234pass";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string sqlSelectQuery = "SELECT \"START\", \"END\" FROM VISIT WHERE EMAIL = @selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, conn);
                command.Parameters.AddWithValue("@selectedRowId", _email);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                conn.Close();
            }

            catch (Exception )
            {
              
            }

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void student_info_Load_1(object sender, EventArgs e)
        {
            var datasource = @"nour-fcai-assignments.database.windows.net";
            var database = "UniversityLibrarySystem";
            var username = "admon";
            var password = "DB1234pass";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);

            try
            {

                conn.Open();
                
                string sqlSelectQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, conn);
                command.Parameters.AddWithValue("@selectedRowId", _email);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();



                    textBox4.Text = Encryption.Hashstring(reader[1].ToString());

                }
                loadFirstGrid();
                loadSecondGrid();

                conn.Close();


            }
            catch (Exception )
            {
               
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new student_main_screen(_email);
            Hide();
            form.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new student_update_info(_email);
            Hide();
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}