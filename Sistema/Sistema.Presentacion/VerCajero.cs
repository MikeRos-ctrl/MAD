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
    public partial class VerCajero : Form
    {
        public VerCajero()
        {
            InitializeComponent();
        }

        private void Dgv_rCajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarCajero xd = new ModificarCajero();
            xd.Show();
        }
    }
}
