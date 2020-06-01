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
    public partial class funcionariosRelFrm : Form
    {
        public funcionariosRelFrm()
        {
            InitializeComponent();
        }

        private void funcionariosRelFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'SharpVendasDataSet.Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.VendedorTableAdapter.Fill(this.SharpVendasDataSet.Vendedor);
            // TODO: esta linha de código carrega dados na tabela 'SharpVendasDataSet.Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.VendedorTableAdapter.Fill(this.SharpVendasDataSet.Vendedor);
            // TODO: esta linha de código carrega dados na tabela 'SharpVendasDataSet.Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.VendedorTableAdapter.Fill(this.SharpVendasDataSet.Vendedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
