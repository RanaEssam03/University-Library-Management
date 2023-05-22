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
            this.SuspendLayout();
            // 
            // view_visit
            // 
            this.view_visit.Location = new System.Drawing.Point(96, 168);
            this.view_visit.Name = "view_visit";
            this.view_visit.Size = new System.Drawing.Size(157, 74);
            this.view_visit.TabIndex = 0;
            this.view_visit.Text = "Visits";
            this.view_visit.UseVisualStyleBackColor = true;
            this.view_visit.Click += new System.EventHandler(this.button1_Click);
            // 
            // books_button
            // 
            this.books_button.Location = new System.Drawing.Point(292, 168);
            this.books_button.Name = "books_button";
            this.books_button.Size = new System.Drawing.Size(157, 74);
            this.books_button.TabIndex = 2;
            this.books_button.Text = "Books";
            this.books_button.UseVisualStyleBackColor = true;
            this.books_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // borrow
            // 
            this.borrow.Location = new System.Drawing.Point(486, 168);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(157, 74);
            this.borrow.TabIndex = 3;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = true;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // admin_main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.back);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.books_button);
            this.Controls.Add(this.view_visit);
            this.Name = "admin_main_screen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.admin_main_screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_visit;
        private System.Windows.Forms.Button books_button;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button back;
    }
}