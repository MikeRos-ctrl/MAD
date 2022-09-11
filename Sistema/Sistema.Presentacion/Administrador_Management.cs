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
    public partial class Administrador_Management : Form
    {
        public Administrador_Management()
        {
            InitializeComponent();
        }

        public object N_Administradores { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Dgv_Adinistradores.DataSource = N_Administrador.Get_Administradores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
