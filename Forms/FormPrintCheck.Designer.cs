namespace PrintCheck.Forms
{
    partial class FormPrintCheck
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printCheckDataSetPrint = new PrintCheck.PrintCheckDataSetPrint();
            this.printCheckDataSetPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAddCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_AddCheckTableAdapter = new PrintCheck.PrintCheckDataSetPrintTableAdapters.View_AddCheckTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddCheckBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPrint";
            reportDataSource1.Value = this.viewAddCheckBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrintCheck.Reports.ReportAddCheck.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(82, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(679, 288);
            this.reportViewer1.TabIndex = 0;
            // 
            // printCheckDataSetPrint
            // 
            this.printCheckDataSetPrint.DataSetName = "PrintCheckDataSetPrint";
            this.printCheckDataSetPrint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printCheckDataSetPrintBindingSource
            // 
            this.printCheckDataSetPrintBindingSource.DataSource = this.printCheckDataSetPrint;
            this.printCheckDataSetPrintBindingSource.Position = 0;
            // 
            // viewAddCheckBindingSource
            // 
            this.viewAddCheckBindingSource.DataMember = "View_AddCheck";
            this.viewAddCheckBindingSource.DataSource = this.printCheckDataSetPrintBindingSource;
            // 
            // view_AddCheckTableAdapter
            // 
            this.view_AddCheckTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrintCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPrintCheck";
            this.Text = "FormPrintCheck";
            this.Load += new System.EventHandler(this.FormPrintCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddCheckBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PrintCheckDataSetPrint printCheckDataSetPrint;
        private System.Windows.Forms.BindingSource printCheckDataSetPrintBindingSource;
        private System.Windows.Forms.BindingSource viewAddCheckBindingSource;
        private PrintCheckDataSetPrintTableAdapters.View_AddCheckTableAdapter view_AddCheckTableAdapter;
    }
}