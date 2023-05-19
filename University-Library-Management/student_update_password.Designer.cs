namespace University_Library_Management
{
    partial class student_update_password
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
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.confirmNewPassword = new System.Windows.Forms.TextBox();
            this.oldPsswordError = new System.Windows.Forms.Label();
            this.newPasswordError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentPassword
            // 
            this.currentPassword.Location = new System.Drawing.Point(346, 122);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(211, 22);
            this.currentPassword.TabIndex = 0;
            this.currentPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(346, 176);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(211, 22);
            this.newPassword.TabIndex = 1;
            // 
            // confirmNewPassword
            // 
            this.confirmNewPassword.Location = new System.Drawing.Point(346, 225);
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.Size = new System.Drawing.Size(211, 22);
            this.confirmNewPassword.TabIndex = 2;
            // 
            // oldPsswordError
            // 
            this.oldPsswordError.AutoSize = true;
            this.oldPsswordError.ForeColor = System.Drawing.SystemColors.Highlight;
            this.oldPsswordError.Location = new System.Drawing.Point(593, 128);
            this.oldPsswordError.Name = "oldPsswordError";
            this.oldPsswordError.Size = new System.Drawing.Size(44, 16);
            this.oldPsswordError.TabIndex = 3;
            this.oldPsswordError.Text = "label1";
            this.oldPsswordError.Click += new System.EventHandler(this.label1_Click);
            // 
            // newPasswordError
            // 
            this.newPasswordError.AutoSize = true;
            this.newPasswordError.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newPasswordError.Location = new System.Drawing.Point(421, 268);
            this.newPasswordError.Name = "newPasswordError";
            this.newPasswordError.Size = new System.Drawing.Size(44, 16);
            this.newPasswordError.TabIndex = 4;
            this.newPasswordError.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm New Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updatePassword
            // 
            this.updatePassword.Location = new System.Drawing.Point(391, 323);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(130, 40);
            this.updatePassword.TabIndex = 8;
            this.updatePassword.Text = "Update Password";
            this.updatePassword.UseVisualStyleBackColor = true;
            this.updatePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // student_update_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPasswordError);
            this.Controls.Add(this.oldPsswordError);
            this.Controls.Add(this.confirmNewPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.currentPassword);
            this.Name = "student_update_password";
            this.Text = "student_update_password";
            this.Load += new System.EventHandler(this.student_update_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox confirmNewPassword;
        private System.Windows.Forms.Label oldPsswordError;
        private System.Windows.Forms.Label newPasswordError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updatePassword;
    }
}