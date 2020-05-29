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
    public partial class novaVendaRel : Form
    {
        public novaVendaRel(int iv)
        {
            InitializeComponent();
            id = iv;
        }
        int id;

        private void novaVendaRel_Load(object sender, EventArgs e)
        {
            UltimaVendaBindingSource.DataSource =
                new itemVendaDAO().listaUltimaVenda(id);
            this.reportViewer1.RefreshReport();
        }
    }
}
