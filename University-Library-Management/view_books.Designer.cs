namespace University_Library_Management
{
    partial class view_books
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
            this.search = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.catalog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(753, 63);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(399, 63);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(285, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // catalog
            // 
            this.catalog.AllowDrop = true;
            this.catalog.AllowUserToAddRows = false;
            this.catalog.AllowUserToDeleteRows = false;
            this.catalog.AllowUserToOrderColumns = true;
            this.catalog.AllowUserToResizeColumns = false;
            this.catalog.AllowUserToResizeRows = false;
            this.catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog.Location = new System.Drawing.Point(221, 130);
            this.catalog.Name = "catalog";
            this.catalog.RowHeadersWidth = 51;
            this.catalog.RowTemplate.Height = 24;
            this.catalog.Size = new System.Drawing.Size(733, 273);
            this.catalog.TabIndex = 2;
            this.catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_CellContentClick);
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.search);
            this.Name = "view_books";
            this.Text = "view_books";
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView catalog;
    }
}