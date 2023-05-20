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
    public partial class student_form : Form
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_sign_upcs std_form = new student_sign_upcs();
            Hide();
            std_form.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new student_sign_in();
            Hide();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
