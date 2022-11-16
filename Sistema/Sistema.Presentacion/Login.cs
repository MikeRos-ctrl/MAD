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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {


            string correo = txt_correo.Text;
            string contra = txt_contra.Text;
            //string clave = .DataSource;

           

            if (correo.CompareTo("")== 0 || contra.CompareTo("") == 0)
            {
                MessageBox.Show("faltan llenar campos -.-");
            }

            else
            {
                DataTable table = new DataTable();
                table = N_Administrador.Login_Administador(correo);
               
                //RegistroEmpleado who = new RegistroEmpleado();
                //who.registeredBy.Text = correo;


                if (table.Rows.Count == 0)//usuario no existe
                {
                    MessageBox.Show("Usuario inexistente");
                }
                else
                {
                    string user_contra = Convert.ToString(table.Rows[0][0]);//contraseña
                    string clave = Convert.ToString(table.Rows[0][1]);

                    if (user_contra.CompareTo(contra) == 0)
                    {
                        MessageBox.Show("Todo esta bien y ingresar seccion");
                        InicioAdmin frm = new InicioAdmin(clave);   
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta xd");
                    }
                }
            }
        }

        private void btn_aceptarCajero_Click(object sender, EventArgs e)
        {


            string correo = txt_correoCajero.Text;
            string contra = txt_contraCajero.Text;

            if (correo.CompareTo("") == 0 || contra.CompareTo("") == 0)
            {
                MessageBox.Show("faltan llenar campos -.-");
            }

            else
            {
                DataTable table = new DataTable();
                table = N_Cajero.sp_Login_Cajeros(correo);
             
                if (table.Rows.Count == 0)//usuario no existe
                {
                    MessageBox.Show("Usuario inexistente");
                }
                else
                {
                    string user_contra = Convert.ToString(table.Rows[0][0]);//contraseña
                    string correO = Convert.ToString(table.Rows[0][1]);
                    string clave = Convert.ToString(table.Rows[0][2]);


                    if (user_contra.CompareTo(contra) == 0)
                    {
                        MessageBox.Show("Todo esta bien y ingresar seccion");

                        ElegirCaja xd = new ElegirCaja(correO, clave);
                        xd.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta xd");
                    }
                }
            }

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
