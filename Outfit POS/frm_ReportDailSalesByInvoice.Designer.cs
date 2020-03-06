namespace Outfit_POS
{
    partial class frm_ReportDailSalesByInvoice
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
            this.DailySalesByInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportC = new Outfit_POS.dsReportC();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesByInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportC)).BeginInit();
            this.SuspendLayout();
            // 
            // DailySalesByInvoiceBindingSource
            // 
            this.DailySalesByInvoiceBindingSource.DataMember = "DailySalesByInvoice";
            this.DailySalesByInvoiceBindingSource.DataSource = this.dsReportC;
            // 
            // dsReportC
            // 
            this.dsReportC.DataSetName = "dsReportC";
            this.dsReportC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDRByInvoice";
            reportDataSource1.Value = this.DailySalesByInvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POSMainForm.rptDailySalesReportByInvoiceNo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(657, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_ReportDailSalesByInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 432);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ReportDailSalesByInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe diario de ventas por factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDailSalesByInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesByInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DailySalesByInvoiceBindingSource;
        private dsReportC dsReportC;
    }
}