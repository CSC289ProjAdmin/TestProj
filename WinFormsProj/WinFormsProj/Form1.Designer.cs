﻿namespace WinFormsProj {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WinFormsProjDBDataSet = new WinFormsProj.WinFormsProjDBDataSet();
            this.FirstTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstTableTableAdapter = new WinFormsProj.WinFormsProjDBDataSetTableAdapters.FirstTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WinFormsProjDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FirstTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormsProj.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 613);
            this.reportViewer1.TabIndex = 0;
            // 
            // WinFormsProjDBDataSet
            // 
            this.WinFormsProjDBDataSet.DataSetName = "WinFormsProjDBDataSet";
            this.WinFormsProjDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FirstTableBindingSource
            // 
            this.FirstTableBindingSource.DataMember = "FirstTable";
            this.FirstTableBindingSource.DataSource = this.WinFormsProjDBDataSet;
            // 
            // FirstTableTableAdapter
            // 
            this.FirstTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 613);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WinFormsProjDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FirstTableBindingSource;
        private WinFormsProjDBDataSet WinFormsProjDBDataSet;
        private WinFormsProjDBDataSetTableAdapters.FirstTableTableAdapter FirstTableTableAdapter;
    }
}

