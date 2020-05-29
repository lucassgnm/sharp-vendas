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
    public partial class frmVendasRel : Form
    {
        public frmVendasRel()
        {
            InitializeComponent();
        }

        private void frmVendasRel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'SharpVendasDataSet.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.VendaTableAdapter.Fill(this.SharpVendasDataSet.Venda);

            this.reportViewer1.RefreshReport();
        }
    }
}
