using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpVendas
{
    public partial class frmQtd : Form
    {
        public frmQtd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private String getQtd()
        {
            String res = txtQtd.Text;
            return res;
        }

        private void frmQtd_Load(object sender, EventArgs e)
        {

        }
    }
}
