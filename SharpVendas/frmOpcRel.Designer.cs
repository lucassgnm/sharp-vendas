namespace SharpVendas
{
    partial class frmOpcRel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcRel));
            this.brnRelCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnRelCliente
            // 
            this.brnRelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRelCliente.Location = new System.Drawing.Point(12, 52);
            this.brnRelCliente.Name = "brnRelCliente";
            this.brnRelCliente.Size = new System.Drawing.Size(203, 140);
            this.brnRelCliente.TabIndex = 0;
            this.brnRelCliente.Text = "Relatório de clientes";
            this.brnRelCliente.UseVisualStyleBackColor = true;
            this.brnRelCliente.Click += new System.EventHandler(this.brnRelCliente_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(302, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 140);
            this.button2.TabIndex = 1;
            this.button2.Text = "Relatório de funcionários";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(575, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 140);
            this.button3.TabIndex = 2;
            this.button3.Text = "Relatório de estoque";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOpcRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brnRelCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcRel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha uma das opções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnRelCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}