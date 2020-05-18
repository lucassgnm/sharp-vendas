using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpVendas.models_controllers;

namespace SharpVendas
{
    public partial class clienteFrm : Form
    {
        public clienteFrm()
        {
            InitializeComponent();
            botaoInserir();
        }

        private void setDadosCliente(Cliente cl)
        {
            txtNome.Text = cl.nome;
            txtCodigo.Text = cl.id.ToString();
            txtCPF.Text = cl.cpf;
            txtRG.Text = cl.rg;
            txtDataNasc.Text = cl.datanasc.ToShortDateString();
        }

        private Cliente getDadosClientes()
        {
            Cliente c1 = new Cliente();
            if (!btnInserir.Enabled)
            {
                c1.id = Convert.ToInt32(txtCodigo.Text);
            }
            c1.nome = txtNome.Text;
            c1.datanasc = Convert.ToDateTime(txtDataNasc.Text);
            c1.cpf = txtCPF.Text;
            c1.rg = txtRG.Text;
            return c1;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DAOcliente query = new DAOcliente();
            query.inserirCliente(getDadosClientes());
            limparTela();
            botaoInserir();
            MessageBox.Show("Cliente gravado!");
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
            txtRG.Text = "";
            txtNome.Clear();
            txtCodigo.Clear();
            txtDataNasc.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clienteListaFrm frm = new clienteListaFrm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setDadosCliente(frm.getCliente());
                botaoAlterarExcluir();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new DAOcliente().alterar(getDadosClientes());
            botaoInserir();
            limparTela();
            MessageBox.Show("Cliente alterado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            new DAOcliente().excluir(getDadosClientes());
            botaoInserir();
            limparTela();
            MessageBox.Show("Cliente excluído!");
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
