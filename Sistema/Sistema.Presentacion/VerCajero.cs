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


    public partial class VerCajero : Form
    {


        string Nombre_Actual = "";
        string freedom = "";

        public VerCajero(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;


        }



        private void Dgv_rCajero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
            ClaveUsu.Text = Dgv_rCajero.CurrentRow.Cells[0].Value.ToString();
            NomCompleto.Text = Dgv_rCajero.CurrentRow.Cells[2].Value.ToString();
            CURP.Text = Dgv_rCajero.CurrentRow.Cells[4].Value.ToString();
            nNomina.Text = Dgv_rCajero.CurrentRow.Cells[6].Value.ToString();
            Correo.Text = Dgv_rCajero.CurrentRow.Cells[7].Value.ToString();
            Contrasena.Text = Dgv_rCajero.CurrentRow.Cells[8].Value.ToString();

        }



        private void btn_Modificar_Click(object sender, EventArgs e)
        {


            string clave = ClaveUsu.Text;
            string Contrasena_ = Contrasena.Text;
            string Registered_by_ = Adminnom.Text;
            string NomCompleto_ = NomCompleto.Text;
            string CURP_ = CURP.Text;
            string nNomina_ = nNomina.Text;
            string Correo_ = Correo.Text;
            string nacimiento = fNacimiento.Text;
          


            if ( Contrasena_.CompareTo("") == 0  || NomCompleto_.CompareTo("") == 0 || CURP_.CompareTo("") == 0 || nNomina_.CompareTo("") == 0
                || Correo_.CompareTo("") == 0 || nacimiento.CompareTo("") == 0 || Correo_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan Datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Cajero.sp_GestionarCajero(clave, Registered_by_, NomCompleto_,
                                                         CURP_, nacimiento, nNomina_, Correo_, Contrasena_, "U");


                if (respuesta.Equals("OK"))
                {

                    MessageBox.Show("Datos Actualizados c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerCajero_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerCajero_Load(sender, e);
                }
            }

        }

        private void VerCajero_Load(object sender, EventArgs e)
        {
            ClaveUsu.Clear();
            Contrasena.Clear();
            Adminnom.Clear();
            NomCompleto.Clear();
            CURP.Clear();

            nNomina.Clear();
            Correo.Clear();
            Adminnom.Clear();
            Adminnom.AppendText(Nombre_Actual);

            try
            {
                Dgv_rCajero.DataSource = N_Cajero.sp_Get_Cajero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            string clave = ClaveUsu.Text;
            string Contrasena_ = Contrasena.Text;
            string Registered_by_ = Adminnom.Text;
            string NomCompleto_ = NomCompleto.Text;
            string CURP_ = CURP.Text;
            string nNomina_ = nNomina.Text;
            string Correo_ = Correo.Text;
            string nacimiento = fNacimiento.Text;

            freedom = clave;


            if (Contrasena_.CompareTo("") == 0 || NomCompleto_.CompareTo("") == 0 || CURP_.CompareTo("") == 0 || nNomina_.CompareTo("") == 0
              || Correo_.CompareTo("") == 0 || nacimiento.CompareTo("") == 0 || Correo_.CompareTo("") == 0)
            {
                MessageBox.Show("No ha selecionado ninguna casilla -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar el Cajero con el id " + "[" + freedom.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_Cajero.sp_GestionarCajero(freedom, Registered_by_, NomCompleto_,
                                                             CURP_, nacimiento, nNomina_, Correo_, Contrasena_, "D");
                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Cajero Eliminado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VerCajero_Load(sender, e);

                    }

                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        VerCajero_Load(sender, e);
                    }
                }

            }
          

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

           
            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void btn_VerModCajero_Click(object sender, EventArgs e)
        {
            VerModCajero xd = new VerModCajero(Nombre_Actual);
            xd.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Adminnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_rCajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
