namespace University_Library_Management
{
    partial class add_visit
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
            this.email = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.Label();
            this.add_vis = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(513, 107);
            this.email_input.Multiline = true;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(280, 33);
            this.email_input.TabIndex = 1;
            this.email_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(370, 107);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 22);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(370, 172);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(89, 22);
            this.start_date.TabIndex = 7;
            this.start_date.Text = "Start Date";
            this.start_date.Click += new System.EventHandler(this.start_date_Click);
            // 
            // add_vis
            // 
            this.add_vis.BackColor = System.Drawing.Color.Maroon;
            this.add_vis.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_vis.ForeColor = System.Drawing.SystemColors.Menu;
            this.add_vis.Location = new System.Drawing.Point(586, 350);
            this.add_vis.Name = "add_vis";
            this.add_vis.Size = new System.Drawing.Size(126, 45);
            this.add_vis.TabIndex = 12;
            this.add_vis.Text = "Add";
            this.add_vis.UseVisualStyleBackColor = false;
            this.add_vis.Click += new System.EventHandler(this.add_vis_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(654, 298);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 13;
            this.error.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "dd-MM-yyyy";
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(513, 172);
            this.dt1.MinDate = new System.DateTime(2023, 5, 20, 2, 35, 7, 0);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(114, 22);
            this.dt1.TabIndex = 14;
            this.dt1.Value = new System.DateTime(2023, 5, 20, 2, 35, 7, 0);
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "End Date";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "dd-MM-yyyy";
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(513, 231);
            this.dt2.MinDate = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(114, 22);
            this.dt2.TabIndex = 16;
            this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 35);
            this.back.TabIndex = 17;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(974, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 242);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // add_visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.add_vis);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.email);
            this.Controls.Add(this.email_input);
            this.Name = "add_visit";
            this.Text = "add_visit";
            this.Load += new System.EventHandler(this.add_visit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.Button add_vis;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}