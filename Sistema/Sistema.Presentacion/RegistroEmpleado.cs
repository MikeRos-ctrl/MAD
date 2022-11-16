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

        string Nombre_Actual = "";
        string claveCajero = "";
        int nomina = 0;


        public RegistroEmpleado(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
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
            string registered_by_ = registeredBy.Text;
            string Contrasena_ = Contrasena.Text;
            string NomCompleto_ = NomCompleto.Text;
            string CURP_ = CURP.Text;
            string nNomina_ = nNomina.Text;
            string Correo_ = Correo.Text;
            string nacimiento = fNacimiento.Text;


            if (clave.CompareTo("") == 0 || registered_by_.CompareTo("") == 0 || Contrasena_.CompareTo("") == 0 
                || NomCompleto_.CompareTo("") == 0 || CURP_.CompareTo("") == 0 || nNomina_.CompareTo("") == 0
                || Correo_.CompareTo("") == 0 || nacimiento.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Cajero.sp_GestionarCajero(clave, registered_by_, NomCompleto_,
                    CURP_, nacimiento, nNomina_, Correo_, Contrasena_, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioAdmin frm = new InicioAdmin(registered_by_);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {

            registeredBy.AppendText(Nombre_Actual);
            claveCajero = Guid.NewGuid().ToString("X").Substring(1, 6);
            ClaveUsu.AppendText(claveCajero);

            Random rnd = new Random();
            nomina = rnd.Next(100000000, 1000000000);
            string nominaStr = nomina.ToString();
            nNomina.AppendText(nominaStr);

            //nomina = Guid.NewGuid().ToString("n").Substring(0, 12);



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();
        }
    }
}
