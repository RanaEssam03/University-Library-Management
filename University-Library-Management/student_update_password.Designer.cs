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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentPassword
            // 
            this.currentPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.currentPassword.Location = new System.Drawing.Point(444, 105);
            this.currentPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(190, 20);
            this.currentPassword.TabIndex = 0;
            this.currentPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.newPassword.Location = new System.Drawing.Point(444, 147);
            this.newPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(190, 20);
            this.newPassword.TabIndex = 1;
            // 
            // confirmNewPassword
            // 
            this.confirmNewPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.confirmNewPassword.Location = new System.Drawing.Point(444, 186);
            this.confirmNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.Size = new System.Drawing.Size(190, 20);
            this.confirmNewPassword.TabIndex = 2;
            // 
            // oldPsswordError
            // 
            this.oldPsswordError.AutoSize = true;
            this.oldPsswordError.ForeColor = System.Drawing.SystemColors.Highlight;
            this.oldPsswordError.Location = new System.Drawing.Point(683, 112);
            this.oldPsswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oldPsswordError.Name = "oldPsswordError";
            this.oldPsswordError.Size = new System.Drawing.Size(35, 13);
            this.oldPsswordError.TabIndex = 3;
            this.oldPsswordError.Text = "label1";
            this.oldPsswordError.Click += new System.EventHandler(this.label1_Click);
            // 
            // newPasswordError
            // 
            this.newPasswordError.AutoSize = true;
            this.newPasswordError.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newPasswordError.Location = new System.Drawing.Point(457, 223);
            this.newPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPasswordError.Name = "newPasswordError";
            this.newPasswordError.Size = new System.Drawing.Size(35, 13);
            this.newPasswordError.TabIndex = 4;
            this.newPasswordError.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(181, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(181, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(181, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm New Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updatePassword
            // 
            this.updatePassword.BackColor = System.Drawing.SystemColors.Desktop;
            this.updatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatePassword.Location = new System.Drawing.Point(495, 264);
            this.updatePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(98, 45);
            this.updatePassword.TabIndex = 8;
            this.updatePassword.Text = "Update Password";
            this.updatePassword.UseVisualStyleBackColor = false;
            this.updatePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "<-Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // student_update_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPasswordError);
            this.Controls.Add(this.oldPsswordError);
            this.Controls.Add(this.confirmNewPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.currentPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "student_update_password";
            this.ShowIcon = false;
            this.Text = "Update Password";
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
        private System.Windows.Forms.Button button1;
    }
}