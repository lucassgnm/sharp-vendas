namespace SharpVendas
{
    partial class clienteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clienteFrm));
            this.grbCodigo = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbrNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbrCPF = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.gbrRG = new System.Windows.Forms.GroupBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.gbrDataNasc = new System.Windows.Forms.GroupBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.grbCodigo.SuspendLayout();
            this.gbrNome.SuspendLayout();
            this.gbrCPF.SuspendLayout();
            this.gbrRG.SuspendLayout();
            this.gbrDataNasc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCodigo
            // 
            this.grbCodigo.Controls.Add(this.txtCodigo);
            this.grbCodigo.Location = new System.Drawing.Point(12, 12);
            this.grbCodigo.Name = "grbCodigo";
            this.grbCodigo.Size = new System.Drawing.Size(113, 57);
            this.grbCodigo.TabIndex = 0;
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
            // gbrNome
            // 
            this.gbrNome.Controls.Add(this.txtNome);
            this.gbrNome.Location = new System.Drawing.Point(166, 12);
            this.gbrNome.Name = "gbrNome";
            this.gbrNome.Size = new System.Drawing.Size(445, 57);
            this.gbrNome.TabIndex = 1;
            this.gbrNome.TabStop = false;
            this.gbrNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(433, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbrCPF
            // 
            this.gbrCPF.Controls.Add(this.txtCPF);
            this.gbrCPF.Location = new System.Drawing.Point(12, 93);
            this.gbrCPF.Name = "gbrCPF";
            this.gbrCPF.Size = new System.Drawing.Size(137, 57);
            this.gbrCPF.TabIndex = 2;
            this.gbrCPF.TabStop = false;
            this.gbrCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 17);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(125, 22);
            this.txtCPF.TabIndex = 0;
            // 
            // gbrRG
            // 
            this.gbrRG.Controls.Add(this.txtRG);
            this.gbrRG.Location = new System.Drawing.Point(239, 93);
            this.gbrRG.Name = "gbrRG";
            this.gbrRG.Size = new System.Drawing.Size(137, 57);
            this.gbrRG.TabIndex = 3;
            this.gbrRG.TabStop = false;
            this.gbrRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(6, 17);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(125, 22);
            this.txtRG.TabIndex = 0;
            this.txtRG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // gbrDataNasc
            // 
            this.gbrDataNasc.Controls.Add(this.txtDataNasc);
            this.gbrDataNasc.Location = new System.Drawing.Point(452, 93);
            this.gbrDataNasc.Name = "gbrDataNasc";
            this.gbrDataNasc.Size = new System.Drawing.Size(153, 57);
            this.gbrDataNasc.TabIndex = 4;
            this.gbrDataNasc.TabStop = false;
            this.gbrDataNasc.Text = "Data de nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(6, 21);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(124, 22);
            this.txtDataNasc.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(6, 202);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 41);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(166, 202);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 41);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(474, 202);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 41);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(320, 202);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 41);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // clienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 254);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gbrDataNasc);
            this.Controls.Add(this.gbrRG);
            this.Controls.Add(this.gbrCPF);
            this.Controls.Add(this.gbrNome);
            this.Controls.Add(this.grbCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clienteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.grbCodigo.ResumeLayout(false);
            this.grbCodigo.PerformLayout();
            this.gbrNome.ResumeLayout(false);
            this.gbrNome.PerformLayout();
            this.gbrCPF.ResumeLayout(false);
            this.gbrCPF.PerformLayout();
            this.gbrRG.ResumeLayout(false);
            this.gbrRG.PerformLayout();
            this.gbrDataNasc.ResumeLayout(false);
            this.gbrDataNasc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbrNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbrCPF;
        private System.Windows.Forms.GroupBox gbrRG;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.GroupBox gbrDataNasc;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
    }
}