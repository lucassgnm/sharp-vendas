using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SharpVendas
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new novaVendaFrm().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new clienteFrm().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmVendedor().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new produtoFrm().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmVendasRel().ShowDialog();
        }
    }
}
