
namespace GUI_MonAn
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuMonAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMSMONANDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMS_MONANDataSet = new GUI_MonAn.DBMS_MONANDataSet();
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMSMONANBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMS_MONANBill = new GUI_MonAn.DBMS_MONANBill();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuMonAnTableAdapter = new GUI_MonAn.DBMS_MONANDataSetTableAdapters.MenuMonAnTableAdapter();
            this.bILLTableAdapter = new GUI_MonAn.DBMS_MONANBillTableAdapters.BILLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menuMonAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSMONANDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_MONANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSMONANBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_MONANBill)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMonAnBindingSource
            // 
            this.menuMonAnBindingSource.DataMember = "MenuMonAn";
            this.menuMonAnBindingSource.DataSource = this.dBMSMONANDataSetBindingSource;
            // 
            // dBMSMONANDataSetBindingSource
            // 
            this.dBMSMONANDataSetBindingSource.DataSource = this.dBMS_MONANDataSet;
            this.dBMSMONANDataSetBindingSource.Position = 0;
            // 
            // dBMS_MONANDataSet
            // 
            this.dBMS_MONANDataSet.DataSetName = "DBMS_MONANDataSet";
            this.dBMS_MONANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.dBMSMONANBillBindingSource;
            // 
            // dBMSMONANBillBindingSource
            // 
            this.dBMSMONANBillBindingSource.DataSource = this.dBMS_MONANBill;
            this.dBMSMONANBillBindingSource.Position = 0;
            // 
            // dBMS_MONANBill
            // 
            this.dBMS_MONANBill.DataSetName = "DBMS_MONANBill";
            this.dBMS_MONANBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.reportViewer2);
            this.bunifuPanel1.Location = new System.Drawing.Point(398, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1117, 1055);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // reportViewer2
            // 
            reportDataSource3.Name = "ThongKe";
            reportDataSource3.Value = this.bILLBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "GUI_MonAn.ThongKe.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1110, 1049);
            this.reportViewer2.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.reportViewer1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(398, 1055);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource4.Name = "MenuMonAn";
            reportDataSource4.Value = this.menuMonAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_MonAn.MenuMonAn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 1055);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuMonAnTableAdapter
            // 
            this.menuMonAnTableAdapter.ClearBeforeFill = true;
            // 
            // bILLTableAdapter
            // 
            this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 1055);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuMonAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSMONANDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_MONANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMSMONANBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMS_MONANBill)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.BindingSource dBMSMONANBillBindingSource;
        private DBMS_MONANBill dBMS_MONANBill;
        private System.Windows.Forms.BindingSource dBMSMONANDataSetBindingSource;
        private DBMS_MONANDataSet dBMS_MONANDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource menuMonAnBindingSource;
        private DBMS_MONANDataSetTableAdapters.MenuMonAnTableAdapter menuMonAnTableAdapter;
        private System.Windows.Forms.BindingSource bILLBindingSource;
        private DBMS_MONANBillTableAdapters.BILLTableAdapter bILLTableAdapter;
    }
}