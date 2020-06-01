namespace SharpVendas
{
    partial class funcionariosRelFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(funcionariosRelFrm));
            this.VendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SharpVendasDataSet = new SharpVendas.SharpVendasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VendedorTableAdapter = new SharpVendas.SharpVendasDataSetTableAdapters.VendedorTableAdapter();
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharpVendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VendedorBindingSource
            // 
            this.VendedorBindingSource.DataMember = "Vendedor";
            this.VendedorBindingSource.DataSource = this.SharpVendasDataSet;
            // 
            // SharpVendasDataSet
            // 
            this.SharpVendasDataSet.DataSetName = "SharpVendasDataSet";
            this.SharpVendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VendedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SharpVendas.funcionariosRel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // VendedorTableAdapter
            // 
            this.VendedorTableAdapter.ClearBeforeFill = true;
            // 
            // ProdutoBindingSource
            // 
            this.ProdutoBindingSource.DataSource = typeof(SharpVendas.models_controllers.Produto);
            // 
            // funcionariosRelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "funcionariosRelFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de funcionários";
            this.Load += new System.EventHandler(this.funcionariosRelFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharpVendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private System.Windows.Forms.BindingSource VendedorBindingSource;
        private SharpVendasDataSet SharpVendasDataSet;
        private SharpVendasDataSetTableAdapters.VendedorTableAdapter VendedorTableAdapter;
    }
}