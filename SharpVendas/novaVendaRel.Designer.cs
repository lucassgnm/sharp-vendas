namespace SharpVendas
{
    partial class novaVendaRel
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
            this.ConsUltimaVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SharpVendasDataSet = new SharpVendas.SharpVendasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsUltimaVendaTableAdapter = new SharpVendas.SharpVendasDataSetTableAdapters.ConsUltimaVendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsUltimaVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharpVendasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsUltimaVendaBindingSource
            // 
            this.ConsUltimaVendaBindingSource.DataMember = "ConsUltimaVenda";
            this.ConsUltimaVendaBindingSource.DataSource = this.SharpVendasDataSet;
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
            reportDataSource1.Value = this.ConsUltimaVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SharpVendas.novaVendaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1025, 659);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConsUltimaVendaTableAdapter
            // 
            this.ConsUltimaVendaTableAdapter.ClearBeforeFill = true;
            // 
            // novaVendaRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 659);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "novaVendaRel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "novaVendaRel";
            this.Load += new System.EventHandler(this.novaVendaRel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsUltimaVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SharpVendasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsUltimaVendaBindingSource;
        private SharpVendasDataSet SharpVendasDataSet;
        private SharpVendasDataSetTableAdapters.ConsUltimaVendaTableAdapter ConsUltimaVendaTableAdapter;
    }
}