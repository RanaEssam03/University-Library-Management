namespace University_Library_Management
{
    partial class Form1
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
            this.StudentButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.Show_Students = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentButton
            // 
            this.StudentButton.Location = new System.Drawing.Point(476, 213);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(163, 89);
            this.StudentButton.TabIndex = 3;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AdminButton.Location = new System.Drawing.Point(221, 213);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(175, 88);
            this.AdminButton.TabIndex = 4;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Show_Students
            // 
            this.Show_Students.Location = new System.Drawing.Point(925, 64);
            this.Show_Students.Name = "Show_Students";
            this.Show_Students.Size = new System.Drawing.Size(123, 23);
            this.Show_Students.TabIndex = 1;
            this.Show_Students.Text = "Show_studnets";
            this.Show_Students.UseVisualStyleBackColor = true;
            this.Show_Students.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(666, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show_Students);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button Show_Students;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

