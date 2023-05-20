namespace University_Library_Management
{
    partial class student_form
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
            this.sign_up_std = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sign_up_std
            // 
            this.sign_up_std.BackColor = System.Drawing.SystemColors.Desktop;
            this.sign_up_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_std.Location = new System.Drawing.Point(175, 160);
            this.sign_up_std.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sign_up_std.Name = "sign_up_std";
            this.sign_up_std.Size = new System.Drawing.Size(307, 126);
            this.sign_up_std.TabIndex = 0;
            this.sign_up_std.Text = "Sign Up";
            this.sign_up_std.UseVisualStyleBackColor = false;
            this.sign_up_std.Click += new System.EventHandler(this.button1_Click);
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.SystemColors.Desktop;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in.Location = new System.Drawing.Point(659, 160);
            this.sign_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(288, 126);
            this.sign_in.TabIndex = 1;
            this.sign_in.Text = "Sign In";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.sign_up_std);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "student_form";
            this.ShowIcon = false;
            this.Text = "Student Form";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign_up_std;
        private System.Windows.Forms.Button sign_in;
    }
}