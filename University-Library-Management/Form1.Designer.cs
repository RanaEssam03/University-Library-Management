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
            this.SuspendLayout();
            // 
            // StudentButton
            // 
            this.StudentButton.Location = new System.Drawing.Point(667, 190);
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
            this.AdminButton.Location = new System.Drawing.Point(333, 191);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(175, 88);
            this.AdminButton.TabIndex = 4;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.StudentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button AdminButton;
    }
}

