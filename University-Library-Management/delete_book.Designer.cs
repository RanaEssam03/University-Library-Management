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
            this.label2 = new System.Windows.Forms.Label();
            this.error_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter book ISBN";
            // 
            // ISBNfield
            // 
            this.ISBNfield.Location = new System.Drawing.Point(200, 142);
            this.ISBNfield.Name = "ISBNfield";
            this.ISBNfield.Size = new System.Drawing.Size(404, 22);
            this.ISBNfield.TabIndex = 15;
            this.ISBNfield.TextChanged += new System.EventHandler(this.ISBNfield_TextChanged);
            // 
            // edit_book
            // 
            this.edit_book.BackColor = System.Drawing.Color.Maroon;
            this.edit_book.ForeColor = System.Drawing.SystemColors.Control;
            this.edit_book.Location = new System.Drawing.Point(319, 223);
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(119, 34);
            this.edit_book.TabIndex = 17;
            this.edit_book.Text = "Delete";
            this.edit_book.UseVisualStyleBackColor = false;
            this.edit_book.Click += new System.EventHandler(this.edit_book_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Location = new System.Drawing.Point(364, 186);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 16);
            this.error_text.TabIndex = 20;
            this.error_text.Click += new System.EventHandler(this.label3_Click);
            // 
            // delete_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBNfield);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error_text;
    }
}