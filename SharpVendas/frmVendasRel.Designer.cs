namespace SharpVendas
{
    partial class frmVendasRel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendasRel));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SharpVendasDataSet = new SharpVendas.SharpVendasDataSet();
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendaTableAdapter = new SharpVendas.SharpVendasDataSetTableAdapters.VendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SharpVendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SharpVendas.vendasRel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(979, 715);
            this.reportViewer1.TabIndex = 0;
            // 
            // SharpVendasDataSet
            // 
            this.SharpVendasDataSet.DataSetName = "SharpVendasDataSet";
            this.SharpVendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataMember = "Venda";
            this.VendaBindingSource.DataSource = this.SharpVendasDataSet;
            // 
            // VendaTableAdapter
            // 
            this.VendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendasRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 715);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendasRel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frmVendasRel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SharpVendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendaBindingSource;
        private SharpVendasDataSet SharpVendasDataSet;
        private SharpVendasDataSetTableAdapters.VendaTableAdapter VendaTableAdapter;
    }
}