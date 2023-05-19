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
        public student_main_screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            Form form = new view_books();
            Hide();
            form.ShowDialog();
        }
    }
}
