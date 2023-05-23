namespace University_Library_Management
{
    partial class admin_main_screen
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
            this.view_visit = new System.Windows.Forms.Button();
            this.books_button = new System.Windows.Forms.Button();
            this.borrow = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // view_visit
            // 
            this.view_visit.BackColor = System.Drawing.Color.Maroon;
            this.view_visit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_visit.ForeColor = System.Drawing.SystemColors.Menu;
            this.view_visit.Location = new System.Drawing.Point(90, 188);
            this.view_visit.Name = "view_visit";
            this.view_visit.Size = new System.Drawing.Size(137, 69);
            this.view_visit.TabIndex = 0;
            this.view_visit.Text = "Visits";
            this.view_visit.UseVisualStyleBackColor = false;
            this.view_visit.Click += new System.EventHandler(this.button1_Click);
            // 
            // books_button
            // 
            this.books_button.BackColor = System.Drawing.Color.Maroon;
            this.books_button.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books_button.ForeColor = System.Drawing.SystemColors.Menu;
            this.books_button.Location = new System.Drawing.Point(565, 188);
            this.books_button.Name = "books_button";
            this.books_button.Size = new System.Drawing.Size(137, 69);
            this.books_button.TabIndex = 2;
            this.books_button.Text = "Books";
            this.books_button.UseVisualStyleBackColor = false;
            this.books_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.Maroon;
            this.borrow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow.ForeColor = System.Drawing.SystemColors.Menu;
            this.borrow.Location = new System.Drawing.Point(839, 188);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(137, 69);
            this.borrow.TabIndex = 3;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(10, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 29);
            this.back.TabIndex = 15;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(486, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 202);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(321, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 69);
            this.button1.TabIndex = 20;
            this.button1.Text = "Statistics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // admin_main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1032, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.books_button);
            this.Controls.Add(this.view_visit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "admin_main_screen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.admin_main_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_visit;
        private System.Windows.Forms.Button books_button;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}