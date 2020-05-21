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
    public partial class produtoListaFrm : Form
    {
        public produtoListaFrm()
        {
            InitializeComponent();
            DAOproduto q = new DAOproduto();
            dgvDadosProdutos.DataSource = q.listaTodosProdutos();
        }

        private void produtoListaFrm_Load(object sender, EventArgs e)
        {

        }

        private void dgvDadosProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Produto getProduto()
        {
            Produto cl = new Produto();
            cl.id = Convert.ToInt32(dgvDadosProdutos.CurrentRow.Cells[0].Value);
            cl.descricao = dgvDadosProdutos.CurrentRow.Cells[1].Value.ToString();
            cl.valor = Convert.ToSingle(dgvDadosProdutos.CurrentRow.Cells[2].Value);
            cl.qtde = Convert.ToInt32(dgvDadosProdutos.CurrentRow.Cells[3].Value);
            return cl;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            dgvDadosProdutos.DataSource = null;
            DAOproduto q = new DAOproduto();
            dgvDadosProdutos.DataSource = q.listaTodosProdutosLike(txtFiltrar.Text);
        }
    }
}
