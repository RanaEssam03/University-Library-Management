namespace University_Library_Management
{
    partial class admin_sign_up
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.memberAlready = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(412, 74);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(399, 33);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(412, 129);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(399, 33);
            this.lastName.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(412, 190);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(399, 33);
            this.Email.TabIndex = 2;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(412, 254);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(399, 33);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(412, 314);
            this.confirmPassword.Multiline = true;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(399, 33);
            this.confirmPassword.TabIndex = 4;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.signUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signUp.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Location = new System.Drawing.Point(577, 16);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(110, 34);
            this.signUp.TabIndex = 5;
            this.signUp.Text = "Sign Up";
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(224, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(98, 22);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(224, 131);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(94, 22);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(224, 192);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 22);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(224, 256);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 22);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(219, 313);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(158, 22);
            this.confirmPasswordLabel.TabIndex = 10;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Maroon;
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.signUpButton.Location = new System.Drawing.Point(496, 388);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(202, 46);
            this.signUpButton.TabIndex = 11;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Location = new System.Drawing.Point(574, 356);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(0, 16);
            this.passwordError.TabIndex = 12;
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.Location = new System.Drawing.Point(858, 209);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(0, 16);
            this.emailError.TabIndex = 13;
            // 
            // memberAlready
            // 
            this.memberAlready.AutoSize = true;
            this.memberAlready.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberAlready.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memberAlready.Location = new System.Drawing.Point(536, 356);
            this.memberAlready.Name = "memberAlready";
            this.memberAlready.Size = new System.Drawing.Size(107, 15);
            this.memberAlready.TabIndex = 14;
            this.memberAlready.TabStop = true;
            this.memberAlready.Text = "Already an admin?";
            this.memberAlready.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.memberAlready_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "<-Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(990, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 215);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // admin_sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memberAlready);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "admin_sign_up";
            this.Text = "Admin Sign Up";
            this.Load += new System.EventHandler(this.admin_sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.LinkLabel memberAlready;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}