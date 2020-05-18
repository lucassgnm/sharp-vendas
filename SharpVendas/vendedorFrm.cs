using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpVendas.models_controllers;

namespace SharpVendas
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DAOvendedor query = new DAOvendedor();
            query.inserirVendedor(getDadosVendedores());
            limparTela();
            botaoInserir();
            MessageBox.Show("Vendedor gravado!");
        }

        private void setDadosVendedor(Vendedor v1)
        {
            txtNome.Text = v1.nome;
            txtCodigo.Text = v1.id.ToString();
            txtCPF.Text = v1.cpf;
            txtDataAdimis.Text = v1.dataadimis.ToShortDateString();
        }

        private Vendedor getDadosVendedores()
        {
            Vendedor v1 = new Vendedor();
            if (!btnInserir.Enabled)
            {
                v1.id = Convert.ToInt32(txtCodigo.Text);
            }
            v1.nome = txtNome.Text;
            v1.dataadimis = Convert.ToDateTime(txtDataAdimis.Text);
            v1.cpf = txtCPF.Text;
            return v1;
        }

        private void botaoInserir()
        {
            btnInserir.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void botaoAlterarExcluir()
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void limparTela()
        {
            txtCPF.Text = "";
            txtNome.Clear();
            txtCodigo.Clear();
            txtDataAdimis.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            vendedorListaFrm frm = new vendedorListaFrm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setDadosVendedor(frm.getVendedor());
                botaoAlterarExcluir();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new DAOvendedor().alterar(getDadosVendedores());
            botaoInserir();
            limparTela();
            MessageBox.Show("Vendedor alterado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            new DAOvendedor().excluir(getDadosVendedores());
            botaoInserir();
            limparTela();
            MessageBox.Show("Vendedor excluido!");
        }
    }
}
