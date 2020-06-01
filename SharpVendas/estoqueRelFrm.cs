using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpVendas
{
    public partial class estoqueRelFrm : Form
    {
        public estoqueRelFrm()
        {
            InitializeComponent();
        }

        private void estoqueRelFrm_Load(object sender, EventArgs e)
        {
            SharpVendasDataSet.EnforceConstraints = false;
            SharpVendasDataSet.Clear();
            SharpVendasDataSet.Produto.Rows.Clear();
            // TODO: esta linha de código carrega dados na tabela 'SharpVendasDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutoTableAdapter.Fill(this.SharpVendasDataSet.Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
