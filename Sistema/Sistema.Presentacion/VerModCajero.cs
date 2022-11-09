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
    public partial class VerModCajero : Form
    {
        string Nombre_Actual = "";

        public VerModCajero(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            VerCajero xd = new VerCajero(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void Dgv_ModCajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerModCajero_Load(object sender, EventArgs e)
        {

            try
            {
                Dgv_ModCajero.DataSource = N_Cajero.sp_Get_ModCajero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
