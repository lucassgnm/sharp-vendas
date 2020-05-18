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
    public partial class vendedorListaFrm : Form
    {
        public vendedorListaFrm()
        {
            InitializeComponent();
            DAOvendedor q = new DAOvendedor();
            dgvDadosVendedores.DataSource = q.listaTodosVendedores();
        }

        private void dgvDadosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDadosClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Vendedor getVendedor()
        {
            Vendedor v1 = new Vendedor();
            v1.id = Convert.ToInt32(dgvDadosVendedores.CurrentRow.Cells[0].Value);
            v1.nome = dgvDadosVendedores.CurrentRow.Cells[1].Value.ToString();
            v1.cpf = dgvDadosVendedores.CurrentRow.Cells[2].Value.ToString();
            v1.dataadimis = Convert.ToDateTime(dgvDadosVendedores.CurrentRow.Cells[3].Value.ToString());
            return v1;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            dgvDadosVendedores.DataSource = null;
            DAOvendedor q = new DAOvendedor();
            dgvDadosVendedores.DataSource = q.listaTodosVendedoresLike(txtFiltrar.Text);
        }

        private void frmListaVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
