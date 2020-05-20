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
    public partial class novaVendaFrm : Form
    {
        public novaVendaFrm()
        {
            InitializeComponent();
            novaVendaDAO query = new novaVendaDAO();
            newid = query.getLastId() + 1;
            txtId.Text = newid + "";
        }

        int newid;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void setDadosVendedor(Vendedor v1)
        {
            txtVendedorId.Text = v1.id.ToString();
        }

        private void setDadosCliente(Cliente c1)
        {
            txtClienteId.Text = c1.id.ToString();
            txtNomeCliente.Text = c1.nome;
            txtCpfCliente.Text = c1.cpf;
            txtRgCliente.Text = c1.rg;
            txtDataNascCliente.Text = c1.datanasc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novaVendaListaVendedorFrm frm = new novaVendaListaVendedorFrm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setDadosVendedor(frm.getVendedor());
            }
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            clienteListaFrm frm = new clienteListaFrm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setDadosCliente(frm.getCliente());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void setDadosItemVenda(Produto p1)
        {
            ListViewItem ltvi = ltvItems.Items.Add(p1.id.ToString());
            ltvi.SubItems.Add(p1.descricao);
        }

        private void novaVendaFrm_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                produtoListaFrm frm = new produtoListaFrm();
                frm.ShowDialog();
                
                if (frm.DialogResult == DialogResult.OK)
                {
                    frmQtd frm2 = new frmQtd();
                    frm2.ShowDialog();
                    setDadosItemVenda(frm.getProduto());
                }
            }
        }

        private void btnIncluirProd_Click(object sender, EventArgs e)
        {
            produtoListaFrm frm = new produtoListaFrm();
            frm.ShowDialog();
        }

        private void novaVendaFrm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(novaVendaFrm_KeyPress);
        }

        private void ltvItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
