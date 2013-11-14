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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dLabor_btn_Click(object sender, EventArgs e)
        {
            DatosLaborales regDatos = new DatosLaborales();
            regDatos.ShowDialog();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
