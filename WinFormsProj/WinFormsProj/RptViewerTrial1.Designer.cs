namespace WinFormsProj {
    partial class RptViewerTrial1 {
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
            this.FirstTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WinFormsProjDBDataSet = new WinFormsProj.WinFormsProjDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FirstTableTableAdapter = new WinFormsProj.WinFormsProjDBDataSetTableAdapters.FirstTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinFormsProjDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstTableBindingSource
            // 
            this.FirstTableBindingSource.DataMember = "FirstTable";
            this.FirstTableBindingSource.DataSource = this.WinFormsProjDBDataSet;
            // 
            // WinFormsProjDBDataSet
            // 
            this.WinFormsProjDBDataSet.DataSetName = "WinFormsProjDBDataSet";
            this.WinFormsProjDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FirstTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormsProj.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 398);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // FirstTableTableAdapter
            // 
            this.FirstTableTableAdapter.ClearBeforeFill = true;
            // 
            // RptViewerTrial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 398);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptViewerTrial1";
            this.Text = "RptViewerTrial1";
            this.Load += new System.EventHandler(this.RptViewerTrial1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinFormsProjDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource FirstTableBindingSource;
        private WinFormsProjDBDataSet WinFormsProjDBDataSet;
        private WinFormsProjDBDataSetTableAdapters.FirstTableTableAdapter FirstTableTableAdapter;
    }
}