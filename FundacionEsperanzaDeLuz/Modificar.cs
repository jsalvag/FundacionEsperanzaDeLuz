﻿using System;
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
    public partial class Modificar : Form
    {
        
        public Modificar()
        {
            InitializeComponent();
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dLabor_btn_Click(object sender, EventArgs e)
        {
            DatosLaborales vntDLab = new DatosLaborales();
            vntDLab.ShowDialog();
        }
        public void Limpiar()
        {
            ci_cbx.Text = "";
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
    }
}
