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
    public partial class frmListaCliente : Form
    {
        public frmListaCliente()
        {
            InitializeComponent();
            DAOcliente q = new DAOcliente();
            dgvDadosClientes.DataSource = q.listaTodosClientes();
        }

        private void dgbDadosClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Cliente getCliente()
        {
            Cliente cl = new Cliente();
            cl.id = Convert.ToInt32(dgvDadosClientes.CurrentRow.Cells[0].Value);
            cl.nome = dgvDadosClientes.CurrentRow.Cells[1].Value.ToString();
            cl.cpf = dgvDadosClientes.CurrentRow.Cells[2].Value.ToString();
            cl.rg = dgvDadosClientes.CurrentRow.Cells[3].Value.ToString();
            cl.datanasc = Convert.ToDateTime(dgvDadosClientes.CurrentRow.Cells[4].Value.ToString());
            return cl;
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
