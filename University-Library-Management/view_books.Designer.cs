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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Desktop;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(768, 55);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(171, 38);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBox.Location = new System.Drawing.Point(299, 63);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(384, 22);
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
            this.catalog.Location = new System.Drawing.Point(232, 130);
            this.catalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catalog.Name = "catalog";
            this.catalog.RowHeadersWidth = 51;
            this.catalog.RowTemplate.Height = 24;
            this.catalog.Size = new System.Drawing.Size(733, 273);
            this.catalog.TabIndex = 2;
            this.catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "<-Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Library_Management.Properties.Resources.stanford_university_small;
            this.pictureBox1.Location = new System.Drawing.Point(1035, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 155);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1046, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Rate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "view_books";
            this.ShowIcon = false;
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView catalog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}