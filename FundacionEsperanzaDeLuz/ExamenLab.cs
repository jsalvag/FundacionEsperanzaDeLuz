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
    public partial class ExamenLab : Form
    {
        public ExamenLab()
        {
            InitializeComponent();
            fExLab_dtp.Value = DateTime.Now;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ExamenLab_Load(object sender, EventArgs e)
        {

        }

        private void guardarExamenLab_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
