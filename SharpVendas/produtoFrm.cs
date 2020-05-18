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
    public partial class produtoFrm : Form
    {
        public produtoFrm()
        {
            InitializeComponent();
            AplicarEventos(txtValor);
            botaoInserir();
        }

        private void setDadosProduto(Produto p1)
        {
            txtCodigo.Text = p1.id.ToString();
            txtDescricao.Text = p1.descricao;
            txtValor.Text = p1.valor.ToString();
            txtQtde.Text = p1.qtde.ToString();
        }

        private Produto getDadosProdutos()
        {
            Produto p1 = new Produto();
            if (!btnInserir.Enabled)
            {
                p1.id = Convert.ToInt32(txtCodigo.Text);
            }
            p1.descricao = txtDescricao.Text;
            String newTxtValor = txtValor.Text.Replace("R$", "").Trim();
            p1.valor = Convert.ToDouble(txtQtde.Text);
            p1.qtde = Convert.ToInt32(txtQtde.Text);
            return p1;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            produtoListaFrm frm = new produtoListaFrm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setDadosProduto(frm.getProduto());
                botaoAlterarExcluir();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DAOproduto query = new DAOproduto();
            query.inserirProduto(getDadosProdutos());
            limparTela();
            botaoInserir();
            MessageBox.Show("Produto gravado!");
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
            txtCodigo.Clear();
            txtDescricao.Text = "";
            txtQtde.Clear();
            txtValor.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new DAOproduto().alterar(getDadosProdutos());
            botaoInserir();
            limparTela();
            MessageBox.Show("Produto alterado!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            new DAOproduto().excluir(getDadosProdutos());
            botaoInserir();
            limparTela();
            MessageBox.Show("Produto excluído!");
        }
    }
}
