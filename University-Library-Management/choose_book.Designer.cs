namespace University_Library_Management
{
    partial class choose_book
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
            this.ISBNfield = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_book = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ISBNfield
            // 
            this.ISBNfield.Location = new System.Drawing.Point(193, 112);
            this.ISBNfield.Name = "ISBNfield";
            this.ISBNfield.Size = new System.Drawing.Size(404, 22);
            this.ISBNfield.TabIndex = 0;
            this.ISBNfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter book ISBN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // edit_book
            // 
            this.edit_book.BackColor = System.Drawing.Color.Maroon;
            this.edit_book.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_book.ForeColor = System.Drawing.SystemColors.Menu;
            this.edit_book.Location = new System.Drawing.Point(317, 184);
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(149, 34);
            this.edit_book.TabIndex = 8;
            this.edit_book.Text = "Edit Book";
            this.edit_book.UseVisualStyleBackColor = false;
            this.edit_book.Click += new System.EventHandler(this.edit_book_Click);
            // 
            // error_text
            // 
            this.error_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_text.AutoSize = true;
            this.error_text.ForeColor = System.Drawing.Color.Red;
            this.error_text.Location = new System.Drawing.Point(190, 147);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 16);
            this.error_text.TabIndex = 14;
            this.error_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_text.Click += new System.EventHandler(this.error_text_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 31);
            this.back.TabIndex = 15;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // choose_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.back);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.edit_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNfield);
            this.Name = "choose_book";
            this.Text = "choose_book";
            this.Load += new System.EventHandler(this.choose_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ISBNfield;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button edit_book;
        private System.Windows.Forms.Label error_text;
        private System.Windows.Forms.Button back;
    }
}