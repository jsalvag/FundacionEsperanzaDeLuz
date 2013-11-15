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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
            fecha_lbl.Text = DateTime.Now.ToShortDateString();
        }

        private void guardarExamenRutina_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
