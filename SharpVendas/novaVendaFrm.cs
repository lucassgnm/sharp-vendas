using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpVendas.models_controllers;
using static SharpVendas.SharpVendasDataSet;

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

        public int newid;

        public object SharpVendasDataSetTableAdapters { get; private set; }

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
            txtDataNascCliente.Text = c1.datanasc.ToString("dd/MM/yyyy");
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
            frmQtd frm = new frmQtd();
            frm.ShowDialog();
            int qtd = Convert.ToInt32(frm.getQtd());
            float vlrun = p1.valor;
            float total = vlrun * qtd;
            ListViewItem ltvi = ltvItems.Items.Add(p1.id.ToString());
            ltvi.SubItems.Add(p1.descricao);
            ltvi.SubItems.Add(Convert.ToString(qtd));
            ltvi.SubItems.Add(Convert.ToString(vlrun));
            ltvi.SubItems.Add(Convert.ToString(total));
        }

        private Venda getVenda()
        {
            float total = 0;
            for (int i = 0; i < ltvItems.Items.Count; i++)
            {
                total += Convert.ToSingle(ltvItems.Items[i].SubItems[4].Text);
            }

            Venda v = new Venda();
            v.idcliente = Convert.ToInt32(txtClienteId.Text);
            v.idvendedor = Convert.ToInt32(txtVendedorId.Text);
            v.datavenda = DateTime.Now;
            v.total = total;
            return v;
        }

        public List<ItemVenda> getItemVenda()
        {
            List<ItemVenda> itens = new List<ItemVenda>();
            for (int i = 0; i < ltvItems.Items.Count; i++)
            {
                ItemVenda iv = new ItemVenda();
                iv.idvenda = Convert.ToInt32(txtId.Text);
                iv.idproduto = Convert.ToInt32(ltvItems.Items[i].SubItems[0].Text);
                iv.qtde = Convert.ToInt32(ltvItems.Items[i].SubItems[2].Text);
                iv.valorun = Convert.ToSingle(ltvItems.Items[i].SubItems[3].Text);
                iv.valortotal = Convert.ToSingle(ltvItems.Items[i].SubItems[4].Text);
                itens.Add(iv);
            }
            return itens;
        }

        private void novaVendaFrm_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                produtoListaFrm frm = new produtoListaFrm();
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    setDadosItemVenda(frm.getProduto());
                }
            }
        }

        private void btnIncluirProd_Click(object sender, EventArgs e)
        {
            produtoListaFrm frm = new produtoListaFrm();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                setDadosItemVenda(frm.getProduto());
            }        
        }

        private void novaVendaFrm_Load(object sender, EventArgs e)
        {
                this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(novaVendaFrm_KeyPress);
        }

        private void ltvItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            if (getItemVenda().Count() != 0 && txtVendedorId.Text != "" && txtClienteId.Text != "")
            {
                new novaVendaDAO().inserirVenda(getVenda());
                new itemVendaDAO().inserirItemVenda(getItemVenda());
                this.DialogResult = DialogResult.OK;
                //precisa atualizar o dataset
                novaVendaRel nv = new novaVendaRel(newid);
                nv.ShowDialog();
            } else
            {
                MessageBox.Show("Pelo menos um item/cliente/vendedor deve ser inserido antes de finalizar a venda.");
            }
        }
    }
}
