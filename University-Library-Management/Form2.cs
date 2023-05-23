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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityLibrarySystemDataSet1.VISIT' table. You can move, or remove it, as needed.
            this.vISITTableAdapter.Fill(this.universityLibrarySystemDataSet1.VISIT);
            // TODO: This line of code loads data into the 'universityLibrarySystemDataSet1.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.universityLibrarySystemDataSet1.USER);
            // TODO: This line of code loads data into the 'universityLibrarySystemDataSet1.BORROW' table. You can move, or remove it, as needed.
            this.bORROWTableAdapter.Fill(this.universityLibrarySystemDataSet1.BORROW);
            // TODO: This line of code loads data into the 'universityLibrarySystemDataSet1.BOOK_RATING' table. You can move, or remove it, as needed.
            this.bOOK_RATINGTableAdapter1.Fill(this.universityLibrarySystemDataSet1.BOOK_RATING);
            // TODO: This line of code loads data into the 'universityLibrarySystemDataSet1.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.universityLibrarySystemDataSet1.BOOK);
            // TODO: This line of code loads data into the 'universityLibrarySystemDataSet11.BOOK_RATING' table. You can move, or remove it, as needed.
            this.bOOK_RATINGTableAdapter.Fill(this.universityLibrarySystemDataSet11.BOOK_RATING);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer4.RefreshReport();
        }



        private void rdlViewer1_Load(object sender, EventArgs e)
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
