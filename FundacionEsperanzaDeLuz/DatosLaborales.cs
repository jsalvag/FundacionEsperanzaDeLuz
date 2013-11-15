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
    public partial class DatosLaborales : Form
    {
        public DatosLaborales()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            grado_cbx.Text = "";
            institucion_txt.Clear();
            titulo_txt.Clear();
            expe_txt.Clear();
            cursos_txt.Clear();
            fIngreso_dtp.Value = DateTime.Now;
            cargo_cbx.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatosLaborales_Load(object sender, EventArgs e)
        {

        }
    }
}
