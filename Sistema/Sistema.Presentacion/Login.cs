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

            if(correo.CompareTo("")== 0 || contra.CompareTo("") == 0)
            {
                MessageBox.Show("faltan llenar campos -.-");
            }

            else
            {
                DataTable table = new DataTable();
                table = N_Administrador.Login_Administrador(correo);

                if (table.Rows.Count == 0)//usuario no existe
                {
                    MessageBox.Show("Usuario inexistente");
                }
                else
                {
                    string user_contra = Convert.ToString(table.Rows[0][0]);//contraseña

                    if (user_contra.CompareTo(contra) == 0)
                    {
                        MessageBox.Show("Todo esta bien y ingresar seccion");
                        InicioAdmin frm = new InicioAdmin();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
