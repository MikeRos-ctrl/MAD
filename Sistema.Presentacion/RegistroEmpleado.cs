using Sistema.Negocio;
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
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClaveUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CURP_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string clave = ClaveUsu.Text;
            string Contrasena_ = Contrasena.Text;
            string NomCompleto_ = NomCompleto.Text;
            string CURP_ = CURP.Text;
            string nNomina_ = nNomina.Text;
            string Correo_ = Correo.Text;
            string nacimiento = fNacimiento.Text;
            string ingreso = fIngreso.Text;

            string respuesta = N_Cajero.Insert_Cajero(clave,"moller",NomCompleto_,
                CURP_,nacimiento,ingreso,nNomina_,Correo_,Contrasena_);

            if (respuesta.Equals("OK"))
            {
                MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            else
            {
                MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin xd = new InicioAdmin();
            xd.Show();
        }
    }
}
