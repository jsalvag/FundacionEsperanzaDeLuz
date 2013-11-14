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
        Modificar ventanamod = new Modificar();
        ExamenRutinario ventanaExa = new ExamenRutinario();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearHistoria ch = new crearHistoria();
            ch.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanamod.panel1.Visible = true;
            ventanamod.panel2.Visible = false;
            ventanamod.dLabor_btn.Visible = false;
            ventanamod.ShowDialog();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ventanamod.panel1.Visible = false;
            ventanamod.panel2.Visible = true;
            ventanamod.dLabor_btn.Visible = false;
            ventanamod.ShowDialog();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ventanamod.panel1.Visible = false;
            ventanamod.panel2.Visible = false;
            ventanamod.dLabor_btn.Visible = true;
            ventanamod.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void evaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaExa.ShowDialog();
        }
    }
}
