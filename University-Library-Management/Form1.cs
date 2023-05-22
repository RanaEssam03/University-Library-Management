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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_Library_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {

            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;


            SqlConnection conn = new SqlConnection(connString1);

            try
            {
                //open connection
                conn.Open();

                //MessageBox.Show("Connection Successful...");

                string sqlQuerySelect = "SELECT * FROM \"USER\"" ;

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);


                conn.Close();
                //MessageBox.Show("Selected Successfully!");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form std_form = new admin_form();
            Hide();
            std_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_form std_form = new student_form();
            Hide();
            std_form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    } }
