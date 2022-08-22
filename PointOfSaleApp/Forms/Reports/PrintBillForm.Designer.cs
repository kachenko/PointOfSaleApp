
namespace PointOfSaleApp.Forms
{
    partial class PrintBillForm
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
            this.billReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // billReportViewer
            // 
            this.billReportViewer.AutoSize = true;
            this.billReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billReportViewer.LocalReport.ReportEmbeddedResource = "PointOfSaleApp.Reports.BillPrint.rdlc";
            this.billReportViewer.Location = new System.Drawing.Point(0, 0);
            this.billReportViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.billReportViewer.Name = "billReportViewer";
            this.billReportViewer.ServerReport.BearerToken = null;
            this.billReportViewer.Size = new System.Drawing.Size(362, 490);
            this.billReportViewer.TabIndex = 0;
            // 
            // PrintBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(362, 490);
            this.Controls.Add(this.billReportViewer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POSi - Print Bill";
            this.Load += new System.EventHandler(this.PrintBillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer billReportViewer;
    }
}