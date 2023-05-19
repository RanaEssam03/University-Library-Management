namespace University_Library_Management
{
    partial class student_sign_upcs
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
            this.email_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(260, 182);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(267, 22);
            this.email_input.TabIndex = 0;
            this.email_input.TextChanged += new System.EventHandler(this.email_input_TextChanged);
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(260, 228);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(267, 22);
            this.password_input.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_name_input
            // 
            this.first_name_input.Location = new System.Drawing.Point(132, 111);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(135, 22);
            this.first_name_input.TabIndex = 3;
            // 
            // last_name_input
            // 
            this.last_name_input.Location = new System.Drawing.Point(322, 111);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(100, 22);
            this.last_name_input.TabIndex = 4;
            // 
            // student_sign_upcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.last_name_input);
            this.Controls.Add(this.first_name_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email_input);
            this.Name = "student_sign_upcs";
            this.Text = "student_sign_upcs";
            this.Load += new System.EventHandler(this.student_sign_upcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.TextBox last_name_input;
    }
}