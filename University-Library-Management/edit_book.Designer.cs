namespace University_Library_Management
{
    partial class edit_book
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
            this.Year = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publicationYear = new System.Windows.Forms.DateTimePicker();
            this.amountField = new System.Windows.Forms.NumericUpDown();
            this.category = new System.Windows.Forms.TextBox();
            this.authorField = new System.Windows.Forms.TextBox();
            this.title_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(169, 284);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(36, 16);
            this.Year.TabIndex = 21;
            this.Year.Text = "Year";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(169, 238);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(52, 16);
            this.amount_label.TabIndex = 20;
            this.amount_label.Text = "Amount";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(169, 186);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(62, 16);
            this.categoryLabel.TabIndex = 19;
            this.categoryLabel.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Author";
            // 
            // publicationYear
            // 
            this.publicationYear.Location = new System.Drawing.Point(240, 284);
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Size = new System.Drawing.Size(316, 22);
            this.publicationYear.TabIndex = 17;
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(240, 238);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(316, 22);
            this.amountField.TabIndex = 16;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(240, 186);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(316, 22);
            this.category.TabIndex = 15;
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // authorField
            // 
            this.authorField.Location = new System.Drawing.Point(240, 139);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(316, 22);
            this.authorField.TabIndex = 14;
            this.authorField.TextChanged += new System.EventHandler(this.authorField_TextChanged);
            // 
            // title_field
            // 
            this.title_field.Location = new System.Drawing.Point(240, 86);
            this.title_field.Name = "title_field";
            this.title_field.Size = new System.Drawing.Size(316, 22);
            this.title_field.TabIndex = 13;
            this.title_field.TextChanged += new System.EventHandler(this.title_field_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 22;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(240, 364);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(115, 37);
            this.edit.TabIndex = 23;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // error_text
            // 
            this.error_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_text.AutoSize = true;
            this.error_text.ForeColor = System.Drawing.Color.Red;
            this.error_text.Location = new System.Drawing.Point(237, 335);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 16);
            this.error_text.TabIndex = 24;
            this.error_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publicationYear);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.category);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.title_field);
            this.Controls.Add(this.label1);
            this.Name = "edit_book";
            this.Text = "edit_book";
            ((System.ComponentModel.ISupportInitialize)(this.amountField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker publicationYear;
        private System.Windows.Forms.NumericUpDown amountField;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox title_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label error_text;
    }
}