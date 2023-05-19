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

namespace University_Library_Management
{
    public partial class student_info : Form
    {
        public student_info()
        {
            InitializeComponent();
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
                MessageBox.Show("Connection Successful");
                var selectedRowId = "nour@gmail.com";
                string sqlSelectQuery = "SELECT ISBN,START_DATE,END_DATE FROM \"BORROW\" WHERE EMAIL =@selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, conn);
                command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                MessageBox.Show("Executing Query...");
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                MessageBox.Show("Selected Successfully!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Data was not retrieved");
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
                MessageBox.Show("Connection Successful");
                var selectedRowId = "nour@gmail.com";
                string sqlSelectQuery = "SELECT \"START\", \"END\" FROM VISIT WHERE EMAIL = @selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, conn);
                command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                MessageBox.Show("Executing Query...");
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                conn.Close();
                MessageBox.Show("Selected Successfully!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Data was not retrieved True");
            }

        }
        
        private void student_info_Load(object sender, EventArgs e)
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
                MessageBox.Show("Connection Successful");
                var selectedRowId = "nour@gmail.com";
                string sqlSelectQuery = "SELECT * FROM \"USER\" WHERE EMAIL = @selectedRowId";
                SqlCommand command = new SqlCommand(sqlSelectQuery, conn);
                command.Parameters.AddWithValue("@selectedRowId", selectedRowId);
                MessageBox.Show("Query executed");

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();



                    textBox4.Text = reader[1].ToString();

                }
                loadFirstGrid();
                loadSecondGrid();
            
                conn.Close();
                MessageBox.Show("Done reading");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Data was not retrieved");
            }
    
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            

        }
    }
}
