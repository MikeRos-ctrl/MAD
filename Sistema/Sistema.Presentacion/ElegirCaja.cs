using System;
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
    public partial class ElegirCaja : Form
    {
        string Nombre_Actual = "";
        string Clave_Actual = "";

        public ElegirCaja(string Nombre, string Clave)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Clave_Actual = Clave;
        }

        private void ElegirCaja_Load(object sender, EventArgs e)
        {
            cmb_Caja.Items.Add("Caja 1");
            cmb_Caja.Items.Add("Caja 2");
            cmb_Caja.Items.Add("Caja 3");
            cmb_Caja.Items.Add("Caja 4");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string Elcaja = cmb_Caja.Text;



            if (Elcaja.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de Elegir Caja -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Elcaja);
                xd.Show();
                this.Hide();
            }



        }
    }
}
