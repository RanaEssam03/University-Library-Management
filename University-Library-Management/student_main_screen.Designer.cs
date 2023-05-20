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
            this.personalInfo.BackColor = System.Drawing.SystemColors.Desktop;
            this.personalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personalInfo.Location = new System.Drawing.Point(150, 99);
            this.personalInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(252, 169);
            this.personalInfo.TabIndex = 0;
            this.personalInfo.Text = "Persoanl Info";
            this.personalInfo.UseVisualStyleBackColor = false;
            this.personalInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.BackColor = System.Drawing.SystemColors.Desktop;
            this.viewBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewBooks.Location = new System.Drawing.Point(504, 99);
            this.viewBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(234, 169);
            this.viewBooks.TabIndex = 1;
            this.viewBooks.Text = "View Books";
            this.viewBooks.UseVisualStyleBackColor = false;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // student_main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 366);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.personalInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "student_main_screen";
            this.ShowIcon = false;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.student_main_screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalInfo;
        private System.Windows.Forms.Button viewBooks;
    }
}