using System;
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
    public partial class student_main_screen : Form
    {
        string _email;
        public student_main_screen(string email)
        {
            InitializeComponent();
            this._email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new student_info(_email);
            Hide();
            form.Show();
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            Form form = new view_books(_email);
            Hide();
            form.ShowDialog();
        }

        private void student_main_screen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new student_sign_in();
            Hide();
            form.ShowDialog();
        }
    }
}
