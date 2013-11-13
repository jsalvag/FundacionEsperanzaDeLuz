using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundacionEsperanzaDeLuz
{
    public partial class Inicio : Form
    {
        Registro ventanareg = new Registro();
        public Inicio()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanareg.panel2.Visible = false;
            ventanareg.dLabor_btn.Visible = false;
            ventanareg.panel1.Visible = true;
            ventanareg.ShowDialog();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ventanareg.panel1.Visible = false;
            ventanareg.panel2.Visible = true;
            ventanareg.dLabor_btn.Visible = false;
            ventanareg.ShowDialog();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ventanareg.panel1.Visible = false;
            ventanareg.panel2.Visible = false;
            ventanareg.dLabor_btn.Visible = true;
            ventanareg.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
