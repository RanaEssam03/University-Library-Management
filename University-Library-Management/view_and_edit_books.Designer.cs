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
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).BeginInit();
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
            this.catalog.Location = new System.Drawing.Point(28, 95);
            this.catalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalog.Name = "catalog";
            this.catalog.RowHeadersWidth = 51;
            this.catalog.RowTemplate.Height = 24;
            this.catalog.Size = new System.Drawing.Size(733, 273);
            this.catalog.TabIndex = 3;
            this.catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_CellContentClick);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBox.Location = new System.Drawing.Point(178, 52);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(384, 22);
            this.searchBox.TabIndex = 4;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Desktop;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(568, 44);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(171, 38);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add_book
            // 
            this.add_book.Location = new System.Drawing.Point(393, 389);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(169, 34);
            this.add_book.TabIndex = 6;
            this.add_book.Text = "Add book";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // edit_book
            // 
            this.edit_book.Location = new System.Drawing.Point(178, 389);
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(169, 34);
            this.edit_book.TabIndex = 7;
            this.edit_book.Text = "Edit Book";
            this.edit_book.UseVisualStyleBackColor = true;
            this.edit_book.Click += new System.EventHandler(this.edit_book_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(28, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // view_and_edit_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit_book);
            this.Controls.Add(this.add_book);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.catalog);
            this.Name = "view_and_edit_books";
            this.Text = "view_and_edit_books";
            this.Load += new System.EventHandler(this.view_and_edit_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).EndInit();
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
    }
}