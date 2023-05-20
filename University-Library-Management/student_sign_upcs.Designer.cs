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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm_password_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_input
            // 
            this.email_input.BackColor = System.Drawing.SystemColors.Menu;
            this.email_input.Location = new System.Drawing.Point(383, 150);
            this.email_input.Margin = new System.Windows.Forms.Padding(2);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(201, 20);
            this.email_input.TabIndex = 0;
            this.email_input.TextChanged += new System.EventHandler(this.email_input_TextChanged);
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.SystemColors.Menu;
            this.password_input.Location = new System.Drawing.Point(383, 188);
            this.password_input.Margin = new System.Windows.Forms.Padding(2);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(201, 20);
            this.password_input.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(429, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_name_input
            // 
            this.first_name_input.BackColor = System.Drawing.SystemColors.Menu;
            this.first_name_input.Location = new System.Drawing.Point(383, 70);
            this.first_name_input.Margin = new System.Windows.Forms.Padding(2);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(201, 20);
            this.first_name_input.TabIndex = 3;
            // 
            // last_name_input
            // 
            this.last_name_input.BackColor = System.Drawing.SystemColors.Menu;
            this.last_name_input.Location = new System.Drawing.Point(383, 109);
            this.last_name_input.Margin = new System.Windows.Forms.Padding(2);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(201, 20);
            this.last_name_input.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(198, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(198, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(198, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(198, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // confirm_password_input
            // 
            this.confirm_password_input.BackColor = System.Drawing.SystemColors.Menu;
            this.confirm_password_input.Location = new System.Drawing.Point(383, 228);
            this.confirm_password_input.Margin = new System.Windows.Forms.Padding(2);
            this.confirm_password_input.Name = "confirm_password_input";
            this.confirm_password_input.Size = new System.Drawing.Size(201, 20);
            this.confirm_password_input.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(198, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm Password";
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Location = new System.Drawing.Point(633, 233);
            this.passwordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(78, 13);
            this.passwordError.TabIndex = 11;
            this.passwordError.Text = "Password Error";
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.Location = new System.Drawing.Point(633, 155);
            this.emailError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(57, 13);
            this.emailError.TabIndex = 12;
            this.emailError.Text = "Email Erorr";
            this.emailError.Click += new System.EventHandler(this.emailError_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(414, 326);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an acount? ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(2, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "<-Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(424, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sign Up ";
            // 
            // student_sign_upcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirm_password_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_name_input);
            this.Controls.Add(this.first_name_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email_input);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "student_sign_upcs";
            this.ShowIcon = false;
            this.Text = "Sign Up";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirm_password_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}