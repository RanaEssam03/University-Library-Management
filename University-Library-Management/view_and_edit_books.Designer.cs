namespace University_Library_Management
{
    partial class view_and_edit_books
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
            this.catalog = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.add_book = new System.Windows.Forms.Button();
            this.edit_book = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.delete_book = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // catalog
            // 
            this.catalog.AllowDrop = true;
            this.catalog.AllowUserToAddRows = false;
            this.catalog.AllowUserToDeleteRows = false;
            this.catalog.AllowUserToOrderColumns = true;
            this.catalog.AllowUserToResizeColumns = false;
            this.catalog.AllowUserToResizeRows = false;
            this.catalog.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog.GridColor = System.Drawing.SystemColors.Desktop;
            this.catalog.Location = new System.Drawing.Point(158, 78);
            this.catalog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.catalog.Name = "catalog";
            this.catalog.RowHeadersWidth = 51;
            this.catalog.RowTemplate.Height = 24;
            this.catalog.Size = new System.Drawing.Size(550, 222);
            this.catalog.TabIndex = 3;
            this.catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBox.Location = new System.Drawing.Point(262, 37);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(289, 28);
            this.searchBox.TabIndex = 4;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Maroon;
            this.search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(594, 32);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(104, 31);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add_book
            // 
            this.add_book.BackColor = System.Drawing.Color.Maroon;
            this.add_book.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_book.ForeColor = System.Drawing.SystemColors.Menu;
            this.add_book.Location = new System.Drawing.Point(232, 316);
            this.add_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(108, 28);
            this.add_book.TabIndex = 6;
            this.add_book.Text = "Add book";
            this.add_book.UseVisualStyleBackColor = false;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // edit_book
            // 
            this.edit_book.BackColor = System.Drawing.Color.Maroon;
            this.edit_book.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_book.ForeColor = System.Drawing.SystemColors.Menu;
            this.edit_book.Location = new System.Drawing.Point(424, 316);
            this.edit_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(106, 28);
            this.edit_book.TabIndex = 7;
            this.edit_book.Text = "Edit Book";
            this.edit_book.UseVisualStyleBackColor = false;
            this.edit_book.Click += new System.EventHandler(this.edit_book_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(2, 2);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 28);
            this.back.TabIndex = 23;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete_book
            // 
            this.delete_book.BackColor = System.Drawing.Color.Maroon;
            this.delete_book.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_book.ForeColor = System.Drawing.SystemColors.Menu;
            this.delete_book.Location = new System.Drawing.Point(602, 316);
            this.delete_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(86, 28);
            this.delete_book.TabIndex = 0;
            this.delete_book.Text = "Delete";
            this.delete_book.UseVisualStyleBackColor = false;
            this.delete_book.Click += new System.EventHandler(this.delete_book_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(768, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 126);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // view_and_edit_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 366);
            this.Controls.Add(this.delete_book);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit_book);
            this.Controls.Add(this.add_book);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.catalog);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "view_and_edit_books";
            this.Text = "view_and_edit_books";
            this.Load += new System.EventHandler(this.view_and_edit_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catalog;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button add_book;
        public System.Windows.Forms.Button edit_book;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete_book;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}