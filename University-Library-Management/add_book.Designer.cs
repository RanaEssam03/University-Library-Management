namespace University_Library_Management
{
    partial class add_book
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
            this.title_field = new System.Windows.Forms.TextBox();
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.ISBNfield = new System.Windows.Forms.TextBox();
            this.authorField = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.publicationYear = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // title_field
            // 
            this.title_field.Location = new System.Drawing.Point(182, 121);
            this.title_field.Name = "title_field";
            this.title_field.Size = new System.Drawing.Size(316, 22);
            this.title_field.TabIndex = 1;
            this.title_field.TextChanged += new System.EventHandler(this.title_field_TextChanged);
            // 
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(111, 70);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(38, 16);
            this.ISBNlabel.TabIndex = 2;
            this.ISBNlabel.Text = "ISBN";
            this.ISBNlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ISBNfield
            // 
            this.ISBNfield.Location = new System.Drawing.Point(182, 64);
            this.ISBNfield.Name = "ISBNfield";
            this.ISBNfield.Size = new System.Drawing.Size(316, 22);
            this.ISBNfield.TabIndex = 3;
            this.ISBNfield.TextChanged += new System.EventHandler(this.ISBNfield_TextChanged);
            // 
            // authorField
            // 
            this.authorField.Location = new System.Drawing.Point(182, 174);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(316, 22);
            this.authorField.TabIndex = 4;
            this.authorField.TextChanged += new System.EventHandler(this.authorField_TextChanged);
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(182, 221);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(316, 22);
            this.category.TabIndex = 5;
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(182, 273);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(316, 22);
            this.amountField.TabIndex = 6;
            // 
            // publicationYear
            // 
            this.publicationYear.Location = new System.Drawing.Point(182, 319);
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Size = new System.Drawing.Size(316, 22);
            this.publicationYear.TabIndex = 7;
            this.publicationYear.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(111, 221);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(62, 16);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(111, 273);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(52, 16);
            this.amount_label.TabIndex = 10;
            this.amount_label.Text = "Amount";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(111, 319);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(36, 16);
            this.Year.TabIndex = 11;
            this.Year.Text = "Year";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(250, 421);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(151, 36);
            this.add.TabIndex = 12;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // error_text
            // 
            this.error_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_text.AutoSize = true;
            this.error_text.ForeColor = System.Drawing.Color.Red;
            this.error_text.Location = new System.Drawing.Point(319, 383);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 16);
            this.error_text.TabIndex = 13;
            this.error_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 14;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 478);
            this.Controls.Add(this.back);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publicationYear);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.category);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.ISBNfield);
            this.Controls.Add(this.ISBNlabel);
            this.Controls.Add(this.title_field);
            this.Controls.Add(this.label1);
            this.Name = "add_book";
            this.Text = "add_book";
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_field;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.TextBox ISBNfield;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.DateTimePicker publicationYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label error_text;
        private System.Windows.Forms.Button back;
    }
}