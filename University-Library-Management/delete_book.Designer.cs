namespace University_Library_Management
{
    partial class delete_book
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
            this.label1 = new System.Windows.Forms.Label();
            this.ISBNfield = new System.Windows.Forms.TextBox();
            this.edit_book = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter book ISBN";
            // 
            // ISBNfield
            // 
            this.ISBNfield.BackColor = System.Drawing.SystemColors.Menu;
            this.ISBNfield.Location = new System.Drawing.Point(150, 115);
            this.ISBNfield.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ISBNfield.Name = "ISBNfield";
            this.ISBNfield.Size = new System.Drawing.Size(304, 20);
            this.ISBNfield.TabIndex = 15;
            this.ISBNfield.TextChanged += new System.EventHandler(this.ISBNfield_TextChanged);
            // 
            // edit_book
            // 
            this.edit_book.BackColor = System.Drawing.Color.Maroon;
            this.edit_book.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_book.ForeColor = System.Drawing.SystemColors.Control;
            this.edit_book.Location = new System.Drawing.Point(239, 181);
            this.edit_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(89, 28);
            this.edit_book.TabIndex = 17;
            this.edit_book.Text = "Delete";
            this.edit_book.UseVisualStyleBackColor = false;
            this.edit_book.Click += new System.EventHandler(this.edit_book_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(11, 11);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(56, 25);
            this.back.TabIndex = 18;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Location = new System.Drawing.Point(273, 151);
            this.error_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 13);
            this.error_text.TabIndex = 20;
            this.error_text.Click += new System.EventHandler(this.label3_Click);
            // 
            // delete_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(600, 233);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNfield);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "delete_book";
            this.Text = "delete_book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ISBNfield;
        public System.Windows.Forms.Button edit_book;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label error_text;
    }
}