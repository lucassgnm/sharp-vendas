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
    public partial class Form1 : Form
    {
        private Timer tm;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Interval = 5 * 1000; // 10 seconds
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once
            this.Hide();
            Form f = new frmPrincipal();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
