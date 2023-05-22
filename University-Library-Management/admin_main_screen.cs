using System;
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
    public partial class admin_main_screen : Form
    {
        private SqlConnection _connection;
        public admin_main_screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form view_visit = new view_visit();
            Hide();
            view_visit.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void admin_main_screen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new view_and_edit_books();
            Hide();
            form.Show();
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            Form form = new view_borrow();
            Hide();
            form.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form form = new admin_sign_in();
            Hide();
            form.Show();
        }
    }
}
