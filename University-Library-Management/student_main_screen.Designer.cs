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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInfo
            // 
            this.personalInfo.BackColor = System.Drawing.Color.Maroon;
            this.personalInfo.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personalInfo.Location = new System.Drawing.Point(12, 142);
            this.personalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(421, 155);
            this.personalInfo.TabIndex = 0;
            this.personalInfo.Text = "Persoanl Info";
            this.personalInfo.UseVisualStyleBackColor = false;
            this.personalInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.BackColor = System.Drawing.Color.Maroon;
            this.viewBooks.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewBooks.Location = new System.Drawing.Point(772, 142);
            this.viewBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(395, 155);
            this.viewBooks.TabIndex = 1;
            this.viewBooks.Text = "View Books";
            this.viewBooks.UseVisualStyleBackColor = false;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(547, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 155);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // student_main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.personalInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "student_main_screen";
            this.ShowIcon = false;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.student_main_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalInfo;
        private System.Windows.Forms.Button viewBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}