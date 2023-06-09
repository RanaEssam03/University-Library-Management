﻿using System;
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
    public partial class choose_book : Form
    {
        private SqlConnection _connection;
        private bool _validISBN = false;
        public choose_book()
        {
            InitializeComponent();
            var datasource = @"nour-fcai-assignments.database.windows.net";//your server
            var database = "UniversityLibrarySystem"; //your database name
            var username = "admon"; //username of server to connect
            var password = "DB1234pass"; //password

            //your connection string 
            string connString1 = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            this._connection = new SqlConnection(connString1);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void edit_book_Click(object sender, EventArgs e)
        {
            if (_validISBN)
            {
                Form form = new edit_book(ISBNfield.Text);
                Hide();
                form.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                string sqlQuery = "SELECT * FROM [BOOK] WHERE ISBN = @isbn";
                SqlCommand Command = new SqlCommand(sqlQuery, _connection);
                Command.Parameters.AddWithValue("@isbn", ISBNfield.Text);

                SqlDataReader reader = Command.ExecuteReader();
                if (!reader.Read())
                {
                    _validISBN = false;
                    error_text.Text = "This ISBN is not found in the system";
                }
                _connection.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new view_and_edit_books();
            Hide();
            form.Show();
        }

        private void error_text_Click(object sender, EventArgs e)
        {

        }

        private void choose_book_Load(object sender, EventArgs e)
        {

        }
    }
}
