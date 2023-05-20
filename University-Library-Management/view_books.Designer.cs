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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Desktop;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(576, 45);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 31);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBox.Location = new System.Drawing.Point(224, 51);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(289, 20);
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
            this.catalog.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog.GridColor = System.Drawing.SystemColors.Desktop;
            this.catalog.Location = new System.Drawing.Point(174, 106);
            this.catalog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.catalog.Name = "catalog";
            this.catalog.RowHeadersWidth = 51;
            this.catalog.RowTemplate.Height = 24;
            this.catalog.Size = new System.Drawing.Size(550, 222);
            this.catalog.TabIndex = 2;
            this.catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "<-Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(884, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "view_books";
            this.ShowIcon = false;
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView catalog;
        private System.Windows.Forms.Button button1;
    }
}