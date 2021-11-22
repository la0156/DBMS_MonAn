
namespace GUI_MonAn
{
    partial class Bill
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
            this.DBMS_MONANTinhTien = new GUI_MonAn.DBMS_MONANTinhTien();
            this.TinhTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TinhTienTableAdapter = new GUI_MonAn.DBMS_MONANTinhTienTableAdapters.TinhTienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBMS_MONANTinhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TinhTien";
            reportDataSource1.Value = this.TinhTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_MonAn.TinhTien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1386, 882);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBMS_MONANTinhTien
            // 
            this.DBMS_MONANTinhTien.DataSetName = "DBMS_MONANTinhTien";
            this.DBMS_MONANTinhTien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TinhTienBindingSource
            // 
            this.TinhTienBindingSource.DataMember = "TinhTien";
            this.TinhTienBindingSource.DataSource = this.DBMS_MONANTinhTien;
            // 
            // TinhTienTableAdapter
            // 
            this.TinhTienTableAdapter.ClearBeforeFill = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 885);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBMS_MONANTinhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TinhTienBindingSource;
        private DBMS_MONANTinhTien DBMS_MONANTinhTien;
        private DBMS_MONANTinhTienTableAdapters.TinhTienTableAdapter TinhTienTableAdapter;
    }
}