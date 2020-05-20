namespace SharpVendas
{
    partial class novaVendaListaVendedorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novaVendaListaVendedorFrm));
            this.dgvDadosVendedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosVendedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDadosVendedores
            // 
            this.dgvDadosVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.CPF,
            this.datanasc});
            this.dgvDadosVendedores.Location = new System.Drawing.Point(12, 12);
            this.dgvDadosVendedores.Name = "dgvDadosVendedores";
            this.dgvDadosVendedores.RowHeadersWidth = 51;
            this.dgvDadosVendedores.RowTemplate.Height = 24;
            this.dgvDadosVendedores.Size = new System.Drawing.Size(776, 426);
            this.dgvDadosVendedores.TabIndex = 1;
            this.dgvDadosVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosClientes_CellContentClick);
            this.dgvDadosVendedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDadosClientes_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.Width = 125;
            // 
            // datanasc
            // 
            this.datanasc.DataPropertyName = "dataadimis";
            this.datanasc.HeaderText = "Data de adimissão";
            this.datanasc.MinimumWidth = 6;
            this.datanasc.Name = "datanasc";
            this.datanasc.Width = 80;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(6, 21);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(305, 27);
            this.txtFiltrar.TabIndex = 2;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar resultados";
            // 
            // vendedorListaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDadosVendedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vendedorListaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de vendedor";
            this.Load += new System.EventHandler(this.frmListaVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosVendedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDadosVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasc;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}