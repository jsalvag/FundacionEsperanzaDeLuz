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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            ci_txt.Clear();
            nom_txt.Clear();
            ape_txt.Clear();
            fNac_dtp.Value = DateTime.Now;
            lNac_txt.Clear();
            dir_txt.Clear();
            tlfF_txt.Clear();
            tlfM_txt.Clear();
            num_h_v.Value = 0;
            num_h_h.Value = 0;
            dir_ofi.Clear();
            tlf_ofi.Clear();
            representa_cbx.Text = "";
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dLabor_btn_Click(object sender, EventArgs e)
        {
            DatosLaborales ventDLab = new DatosLaborales();
            ventDLab.Limpiar();
            ventDLab.ShowDialog();
        }
    }
}
