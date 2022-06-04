
namespace PointOfSaleApp.Forms
{
    partial class PrintReportPerDay
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
            this.dailyReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // dailyReportViewer
            // 
            this.dailyReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailyReportViewer.LocalReport.ReportEmbeddedResource = "PointOfSaleApp.Reports.PerDayReport.rdlc";
            this.dailyReportViewer.Location = new System.Drawing.Point(0, 0);
            this.dailyReportViewer.Name = "dailyReportViewer";
            this.dailyReportViewer.ServerReport.BearerToken = null;
            this.dailyReportViewer.Size = new System.Drawing.Size(800, 450);
            this.dailyReportViewer.TabIndex = 0;
            // 
            // PrintReportPerDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dailyReportViewer);
            this.Name = "PrintReportPerDay";
            this.Text = "POSi - Print Report Per Day";
            this.Load += new System.EventHandler(this.PrintReportPerDay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer dailyReportViewer;
    }
}