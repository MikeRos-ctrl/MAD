﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class ReporteVentas : Form
    {

        string Nombre_Actual = "";

        public ReporteVentas(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();

        }

        private void labelReporteventa_Click(object sender, EventArgs e)
        {

        }



    }
}
