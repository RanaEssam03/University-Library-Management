namespace University_Library_Management
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.universityLibrarySystemDataSet1 = new University_Library_Management.UniversityLibrarySystemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.universityLibrarySystemDataSet11 = new University_Library_Management.UniversityLibrarySystemDataSet1();
            this.bOOKRATINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOK_RATINGTableAdapter = new University_Library_Management.UniversityLibrarySystemDataSet1TableAdapters.BOOK_RATINGTableAdapter();
            this.universityLibrarySystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new University_Library_Management.UniversityLibrarySystemDataSetTableAdapters.BOOKTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bOOKRATINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOK_RATINGTableAdapter1 = new University_Library_Management.UniversityLibrarySystemDataSetTableAdapters.BOOK_RATINGTableAdapter();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bORROWTableAdapter = new University_Library_Management.UniversityLibrarySystemDataSetTableAdapters.BORROWTableAdapter();
            this.USERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new University_Library_Management.UniversityLibrarySystemDataSetTableAdapters.USERTableAdapter();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VISITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vISITBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vISITTableAdapter = new University_Library_Management.UniversityLibrarySystemDataSetTableAdapters.VISITTableAdapter();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibrarySystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibrarySystemDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKRATINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibrarySystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKRATINGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VISITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // universityLibrarySystemDataSet1
            // 
            this.universityLibrarySystemDataSet1.DataSetName = "UniversityLibrarySystemDataSet";
            this.universityLibrarySystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bOOKBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "University_Library_Management.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(166, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // universityLibrarySystemDataSet11
            // 
            this.universityLibrarySystemDataSet11.DataSetName = "UniversityLibrarySystemDataSet1";
            this.universityLibrarySystemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKRATINGBindingSource
            // 
            this.bOOKRATINGBindingSource.DataMember = "BOOK_RATING";
            this.bOOKRATINGBindingSource.DataSource = this.universityLibrarySystemDataSet11;
            // 
            // bOOK_RATINGTableAdapter
            // 
            this.bOOK_RATINGTableAdapter.ClearBeforeFill = true;
            // 
            // universityLibrarySystemDataSet1BindingSource
            // 
            this.universityLibrarySystemDataSet1BindingSource.DataSource = this.universityLibrarySystemDataSet1;
            this.universityLibrarySystemDataSet1BindingSource.Position = 0;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.universityLibrarySystemDataSet1BindingSource;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "borrow";
            reportDataSource2.Value = this.bORROWBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "University_Library_Management.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(694, 54);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.uSERBindingSource1;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "University_Library_Management.Report5.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(166, 334);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(396, 246);
            this.reportViewer3.TabIndex = 2;
            // 
            // bOOKRATINGBindingSource1
            // 
            this.bOOKRATINGBindingSource1.DataMember = "BOOK_RATING";
            this.bOOKRATINGBindingSource1.DataSource = this.universityLibrarySystemDataSet1BindingSource;
            // 
            // bOOK_RATINGTableAdapter1
            // 
            this.bOOK_RATINGTableAdapter1.ClearBeforeFill = true;
            // 
            // bORROWBindingSource
            // 
            this.bORROWBindingSource.DataMember = "BORROW";
            this.bORROWBindingSource.DataSource = this.universityLibrarySystemDataSet1BindingSource;
            // 
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // USERBindingSource
            // 
            this.USERBindingSource.DataMember = "USER";
            this.USERBindingSource.DataSource = this.universityLibrarySystemDataSet1;
            // 
            // uSERBindingSource1
            // 
            this.uSERBindingSource1.DataMember = "USER";
            this.uSERBindingSource1.DataSource = this.universityLibrarySystemDataSet1BindingSource;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.vISITBindingSource1;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "University_Library_Management.Report7.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(694, 334);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(396, 246);
            this.reportViewer4.TabIndex = 3;
            // 
            // VISITBindingSource
            // 
            this.VISITBindingSource.DataMember = "VISIT";
            this.VISITBindingSource.DataSource = this.universityLibrarySystemDataSet1;
            // 
            // vISITBindingSource1
            // 
            this.vISITBindingSource1.DataMember = "VISIT";
            this.vISITBindingSource1.DataSource = this.universityLibrarySystemDataSet1BindingSource;
            // 
            // vISITTableAdapter
            // 
            this.vISITTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Menu;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 38);
            this.back.TabIndex = 23;
            this.back.Text = "<-Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1224, 677);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityLibrarySystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibrarySystemDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKRATINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityLibrarySystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKRATINGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VISITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vISITBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UniversityLibrarySystemDataSet universityLibrarySystemDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private UniversityLibrarySystemDataSet1 universityLibrarySystemDataSet11;
        private System.Windows.Forms.BindingSource bOOKRATINGBindingSource;
        private UniversityLibrarySystemDataSet1TableAdapters.BOOK_RATINGTableAdapter bOOK_RATINGTableAdapter;
        private System.Windows.Forms.BindingSource universityLibrarySystemDataSet1BindingSource;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private UniversityLibrarySystemDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource bOOKRATINGBindingSource1;
        private UniversityLibrarySystemDataSetTableAdapters.BOOK_RATINGTableAdapter bOOK_RATINGTableAdapter1;
        private System.Windows.Forms.BindingSource bORROWBindingSource;
        private UniversityLibrarySystemDataSetTableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private System.Windows.Forms.BindingSource USERBindingSource;
        private System.Windows.Forms.BindingSource uSERBindingSource1;
        private UniversityLibrarySystemDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource VISITBindingSource;
        private System.Windows.Forms.BindingSource vISITBindingSource1;
        private UniversityLibrarySystemDataSetTableAdapters.VISITTableAdapter vISITTableAdapter;
        private System.Windows.Forms.Button back;
    }
}