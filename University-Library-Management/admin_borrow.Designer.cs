namespace University_Library_Management
{
    partial class admin_borrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email_borrow = new System.Windows.Forms.TextBox();
            this.email_std = new System.Windows.Forms.Label();
            this.isbn_book = new System.Windows.Forms.Label();
            this.ISBNfield = new System.Windows.Forms.TextBox();
            this.dt2_borrow = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt1_borrow = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.Label();
            this.error_text = new System.Windows.Forms.Label();
            this.add_vis = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_borrow
            // 
            this.email_borrow.Location = new System.Drawing.Point(496, 70);
            this.email_borrow.Multiline = true;
            this.email_borrow.Name = "email_borrow";
            this.email_borrow.Size = new System.Drawing.Size(260, 33);
            this.email_borrow.TabIndex = 0;
            this.email_borrow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_std
            // 
            this.email_std.AutoSize = true;
            this.email_std.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_std.Location = new System.Drawing.Point(363, 70);
            this.email_std.Name = "email_std";
            this.email_std.Size = new System.Drawing.Size(57, 22);
            this.email_std.TabIndex = 1;
            this.email_std.Text = "Email";
            this.email_std.Click += new System.EventHandler(this.label1_Click);
            // 
            // isbn_book
            // 
            this.isbn_book.AutoSize = true;
            this.isbn_book.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn_book.Location = new System.Drawing.Point(363, 131);
            this.isbn_book.Name = "isbn_book";
            this.isbn_book.Size = new System.Drawing.Size(54, 22);
            this.isbn_book.TabIndex = 2;
            this.isbn_book.Text = "ISBN";
            // 
            // ISBNfield
            // 
            this.ISBNfield.Location = new System.Drawing.Point(496, 131);
            this.ISBNfield.Multiline = true;
            this.ISBNfield.Name = "ISBNfield";
            this.ISBNfield.Size = new System.Drawing.Size(260, 33);
            this.ISBNfield.TabIndex = 3;
            this.ISBNfield.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dt2_borrow
            // 
            this.dt2_borrow.CustomFormat = "dd-MM-yyyy";
            this.dt2_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2_borrow.Location = new System.Drawing.Point(496, 239);
            this.dt2_borrow.MinDate = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            this.dt2_borrow.Name = "dt2_borrow";
            this.dt2_borrow.Size = new System.Drawing.Size(96, 22);
            this.dt2_borrow.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "End Date";
            // 
            // dt1_borrow
            // 
            this.dt1_borrow.CustomFormat = "dd-MM-yyyy";
            this.dt1_borrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1_borrow.Location = new System.Drawing.Point(496, 186);
            this.dt1_borrow.MinDate = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            this.dt1_borrow.Name = "dt1_borrow";
            this.dt1_borrow.Size = new System.Drawing.Size(96, 22);
            this.dt1_borrow.TabIndex = 18;
            this.dt1_borrow.Value = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            this.dt1_borrow.ValueChanged += new System.EventHandler(this.dt1_borrow_ValueChanged);
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(363, 186);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(89, 22);
            this.start_date.TabIndex = 17;
            this.start_date.Text = "Start Date";
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Location = new System.Drawing.Point(633, 319);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 16);
            this.error_text.TabIndex = 22;
            this.error_text.Click += new System.EventHandler(this.error_Click);
            // 
            // add_vis
            // 
            this.add_vis.BackColor = System.Drawing.Color.Maroon;
            this.add_vis.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_vis.ForeColor = System.Drawing.SystemColors.Menu;
            this.add_vis.Location = new System.Drawing.Point(560, 349);
            this.add_vis.Name = "add_vis";
            this.add_vis.Size = new System.Drawing.Size(97, 44);
            this.add_vis.TabIndex = 21;
            this.add_vis.Text = "Add";
            this.add_vis.UseVisualStyleBackColor = false;
            this.add_vis.Click += new System.EventHandler(this.add_vis_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 45);
            this.back.TabIndex = 23;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(1012, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 242);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // admin_borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.add_vis);
            this.Controls.Add(this.dt2_borrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt1_borrow);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.ISBNfield);
            this.Controls.Add(this.isbn_book);
            this.Controls.Add(this.email_std);
            this.Controls.Add(this.email_borrow);
            this.Name = "admin_borrow";
            this.Text = "admin_borrow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_borrow;
        private System.Windows.Forms.Label email_std;
        private System.Windows.Forms.Label isbn_book;
        private System.Windows.Forms.TextBox ISBNfield;
        private System.Windows.Forms.DateTimePicker dt2_borrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt1_borrow;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.Label error_text;
        private System.Windows.Forms.Button add_vis;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}