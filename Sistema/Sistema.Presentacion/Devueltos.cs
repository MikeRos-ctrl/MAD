using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sistema.Negocio;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.IO;


namespace Sistema.Presentacion
{
    public partial class Devueltos : Form
    {
        string Nombre_Actual = "";
        string Nombre_Caja = "";
        string Clave_Actual = "";

        public Devueltos(string Nombre, string Clave, string Caja)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Nombre_Caja = Caja;
            Clave_Actual = Clave;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
        }

        private void Devueltos_Load(object sender, EventArgs e)
        {

            try
            {

                Dgv_Devoluciones.DataSource = N_Devoluciones.sp_Get_devoluciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
