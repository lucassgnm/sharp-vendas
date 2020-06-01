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
    public partial class frmOpcRel : Form
    {
        public frmOpcRel()
        {
            InitializeComponent();
        }

        private void brnRelCliente_Click(object sender, EventArgs e)
        {
            new clientesRelFrm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new funcionariosRelFrm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new estoqueRelFrm().ShowDialog();
        }
    }
}
