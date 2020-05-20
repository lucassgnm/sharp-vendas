namespace SharpVendas
{
    partial class novaVendaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(novaVendaFrm));
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVendedorId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataNascCliente = new System.Windows.Forms.TextBox();
            this.txtRgCliente = new System.Windows.Forms.TextBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.ltvItems = new System.Windows.Forms.ListView();
            this.btnIncluirProd = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(16, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 30);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda NO.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVendedorId);
            this.groupBox2.Location = new System.Drawing.Point(146, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedor NO.";
            // 
            // txtVendedorId
            // 
            this.txtVendedorId.Enabled = false;
            this.txtVendedorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedorId.Location = new System.Drawing.Point(16, 21);
            this.txtVendedorId.Name = "txtVendedorId";
            this.txtVendedorId.Size = new System.Drawing.Size(100, 30);
            this.txtVendedorId.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtClienteId);
            this.groupBox3.Location = new System.Drawing.Point(280, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente NO.";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteId.Location = new System.Drawing.Point(16, 21);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(100, 30);
            this.txtClienteId.TabIndex = 0;
            this.txtClienteId.TextChanged += new System.EventHandler(this.txtClienteId_TextChanged);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(296, 82);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(100, 29);
            this.btnBuscaCliente.TabIndex = 3;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtDataNascCliente);
            this.groupBox4.Controls.Add(this.txtRgCliente);
            this.groupBox4.Controls.Add(this.txtCpfCliente);
            this.groupBox4.Controls.Add(this.txtNomeCliente);
            this.groupBox4.Location = new System.Drawing.Point(432, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info. cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDataNascCliente
            // 
            this.txtDataNascCliente.Enabled = false;
            this.txtDataNascCliente.Location = new System.Drawing.Point(414, 71);
            this.txtDataNascCliente.Name = "txtDataNascCliente";
            this.txtDataNascCliente.Size = new System.Drawing.Size(161, 22);
            this.txtDataNascCliente.TabIndex = 3;
            // 
            // txtRgCliente
            // 
            this.txtRgCliente.Enabled = false;
            this.txtRgCliente.Location = new System.Drawing.Point(198, 71);
            this.txtRgCliente.Name = "txtRgCliente";
            this.txtRgCliente.Size = new System.Drawing.Size(210, 22);
            this.txtRgCliente.TabIndex = 2;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Enabled = false;
            this.txtCpfCliente.Location = new System.Drawing.Point(6, 71);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(186, 22);
            this.txtCpfCliente.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(6, 21);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(569, 22);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // ltvItems
            // 
            this.ltvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ltvItems.HideSelection = false;
            this.ltvItems.Location = new System.Drawing.Point(12, 140);
            this.ltvItems.Name = "ltvItems";
            this.ltvItems.Size = new System.Drawing.Size(1001, 462);
            this.ltvItems.TabIndex = 6;
            this.ltvItems.UseCompatibleStateImageBehavior = false;
            this.ltvItems.View = System.Windows.Forms.View.Details;
            this.ltvItems.SelectedIndexChanged += new System.EventHandler(this.ltvItems_SelectedIndexChanged);
            // 
            // btnIncluirProd
            // 
            this.btnIncluirProd.Location = new System.Drawing.Point(404, 625);
            this.btnIncluirProd.Name = "btnIncluirProd";
            this.btnIncluirProd.Size = new System.Drawing.Size(202, 33);
            this.btnIncluirProd.TabIndex = 7;
            this.btnIncluirProd.Text = "Incluir produto (F2)";
            this.btnIncluirProd.UseVisualStyleBackColor = true;
            this.btnIncluirProd.Click += new System.EventHandler(this.btnIncluirProd_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor Un.";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor total";
            this.columnHeader5.Width = 100;
            // 
            // novaVendaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 670);
            this.Controls.Add(this.btnIncluirProd);
            this.Controls.Add(this.ltvItems);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "novaVendaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova venda";
            this.Load += new System.EventHandler(this.novaVendaFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVendedorId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataNascCliente;
        private System.Windows.Forms.TextBox txtRgCliente;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ltvItems;
        private System.Windows.Forms.Button btnIncluirProd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}