﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library_Management
{
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new admin_sign_in();
            Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new admin_sign_up();
            Hide();
            form.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            Hide();
            form.Show();
        }
    }
}
