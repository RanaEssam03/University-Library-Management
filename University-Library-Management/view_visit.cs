﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_Library_Management
{
    public partial class view_visit : Form
    {
        private SqlConnection _connection;
        public view_visit()
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

        private void view_visit_Load(object sender, EventArgs e)
        {
            try
            {
                //open connection
                _connection.Open();
                string sqlQuery = "SELECT * FROM VISIT";
                SqlCommand command = new SqlCommand(sqlQuery, _connection);
                    
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                _connection.Close();
               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void add_visit_Click(object sender, EventArgs e)
        {
            Form add_visit = new add_visit();
            Hide();
            add_visit.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new admin_main_screen();
            Hide();
            form.Show();
        }
    }
}
