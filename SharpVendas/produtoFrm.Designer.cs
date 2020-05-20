namespace SharpVendas
{
    partial class produtoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(produtoFrm));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gbrRG = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbrCPF = new System.Windows.Forms.GroupBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.gbrNome = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.grbCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbrRG.SuspendLayout();
            this.gbrCPF.SuspendLayout();
            this.gbrNome.SuspendLayout();
            this.grbCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(319, 202);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 41);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(473, 202);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 41);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(165, 202);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 41);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(5, 202);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 41);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gbrRG
            // 
            this.gbrRG.Controls.Add(this.txtValor);
            this.gbrRG.Location = new System.Drawing.Point(319, 93);
            this.gbrRG.Name = "gbrRG";
            this.gbrRG.Size = new System.Drawing.Size(137, 57);
            this.gbrRG.TabIndex = 12;
            this.gbrRG.TabStop = false;
            this.gbrRG.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(6, 21);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 22);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // gbrCPF
            // 
            this.gbrCPF.Controls.Add(this.txtQtde);
            this.gbrCPF.Location = new System.Drawing.Point(12, 93);
            this.gbrCPF.Name = "gbrCPF";
            this.gbrCPF.Size = new System.Drawing.Size(106, 57);
            this.gbrCPF.TabIndex = 11;
            this.gbrCPF.TabStop = false;
            this.gbrCPF.Text = "Quantidade";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(6, 21);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(81, 22);
            this.txtQtde.TabIndex = 0;
            // 
            // gbrNome
            // 
            this.gbrNome.Controls.Add(this.txtDescricao);
            this.gbrNome.Location = new System.Drawing.Point(165, 12);
            this.gbrNome.Name = "gbrNome";
            this.gbrNome.Size = new System.Drawing.Size(445, 57);
            this.gbrNome.TabIndex = 10;
            this.gbrNome.TabStop = false;
            this.gbrNome.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 21);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(433, 22);
            this.txtDescricao.TabIndex = 0;
            // 
            // grbCodigo
            // 
            this.grbCodigo.Controls.Add(this.txtCodigo);
            this.grbCodigo.Location = new System.Drawing.Point(11, 12);
            this.grbCodigo.Name = "grbCodigo";
            this.grbCodigo.Size = new System.Drawing.Size(113, 57);
            this.grbCodigo.TabIndex = 9;
            this.grbCodigo.TabStop = false;
            this.grbCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // produtoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 254);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gbrRG);
            this.Controls.Add(this.gbrCPF);
            this.Controls.Add(this.gbrNome);
            this.Controls.Add(this.grbCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "produtoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.produtoFrm_Load);
            this.gbrRG.ResumeLayout(false);
            this.gbrRG.PerformLayout();
            this.gbrCPF.ResumeLayout(false);
            this.gbrCPF.PerformLayout();
            this.gbrNome.ResumeLayout(false);
            this.gbrNome.PerformLayout();
            this.grbCodigo.ResumeLayout(false);
            this.grbCodigo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox gbrRG;
        private System.Windows.Forms.GroupBox gbrCPF;
        private System.Windows.Forms.GroupBox gbrNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox grbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
    }
}