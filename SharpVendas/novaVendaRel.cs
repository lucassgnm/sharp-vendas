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
    public partial class novaVendaRel : Form
    {
        public novaVendaRel()
        {
            InitializeComponent();
        }

        private void novaVendaRel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'SharpVendasDataSet.ConsUltimaVenda'. Você pode movê-la ou removê-la conforme necessário.
            this.ConsUltimaVendaTableAdapter.Fill(this.SharpVendasDataSet.ConsUltimaVenda);

            this.reportViewer1.RefreshReport();
        }
    }
}
