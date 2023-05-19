namespace University_Library_Management
{
    partial class student_main_screen
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
            this.personalInfo = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personalInfo
            // 
            this.personalInfo.Location = new System.Drawing.Point(202, 183);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(160, 57);
            this.personalInfo.TabIndex = 0;
            this.personalInfo.Text = "Persoanl Info";
            this.personalInfo.UseVisualStyleBackColor = true;
            this.personalInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.Location = new System.Drawing.Point(415, 182);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(172, 58);
            this.viewBooks.TabIndex = 1;
            this.viewBooks.Text = "View Books";
            this.viewBooks.UseVisualStyleBackColor = true;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // student_main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.personalInfo);
            this.Name = "student_main_screen";
            this.Text = "student_main_screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalInfo;
        private System.Windows.Forms.Button viewBooks;
    }
}