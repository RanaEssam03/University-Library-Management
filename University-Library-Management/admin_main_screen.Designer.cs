namespace University_Library_Management
{
    partial class admin_main_screen
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
            this.view_visit = new System.Windows.Forms.Button();
            this.add_visit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_visit
            // 
            this.view_visit.Location = new System.Drawing.Point(177, 152);
            this.view_visit.Name = "view_visit";
            this.view_visit.Size = new System.Drawing.Size(157, 74);
            this.view_visit.TabIndex = 0;
            this.view_visit.Text = "View Visit";
            this.view_visit.UseVisualStyleBackColor = true;
            this.view_visit.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_visit
            // 
            this.add_visit.Location = new System.Drawing.Point(477, 152);
            this.add_visit.Name = "add_visit";
            this.add_visit.Size = new System.Drawing.Size(157, 74);
            this.add_visit.TabIndex = 1;
            this.add_visit.Text = "Add Visit";
            this.add_visit.UseVisualStyleBackColor = true;
            this.add_visit.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin_main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_visit);
            this.Controls.Add(this.view_visit);
            this.Name = "admin_main_screen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.admin_main_screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_visit;
        private System.Windows.Forms.Button add_visit;
    }
}