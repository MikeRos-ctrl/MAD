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
    public partial class ReporteVentas : Form
    {

        string Nombre_Actual = "";
        string Nombre_Caja = "";
        string Clave_Actual = "";

        public ReporteVentas(string Nombre, string Clave, string Caja)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Clave_Actual = Clave;
            Nombre_Caja = Caja;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
            this.Hide();

        }

        private void labelReporteventa_Click(object sender, EventArgs e)
        {

        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            cb_Departamento.DataSource = N_Recibos.sp_Departamento();
            cb_Departamento.ValueMember = "departamento";
            cb_Departamento.DisplayMember = "departamento";

            cb_Caja.DataSource = N_Recibos.sp_Caja();
            cb_Caja.ValueMember = "caja";
            cb_Caja.DisplayMember = "caja";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Dgv_rVentas.DataSource = N_Recibos.sp_GetReporteVentas(cb_Caja.Text, cb_Departamento.Text, dtp_fInicio.Text, dtp_fFin.Text);
            string depa = cb_Departamento.Text;
            string caja = cb_Caja.Text;
            string FI = dtp_fInicio.Text;
            string FF = dtp_fFin.Text;

            if (depa.CompareTo("") == 0 || caja.CompareTo("") == 0 || FI.CompareTo("") == 0 || FF.CompareTo("") == 0)
            {
                ReporteVentas_Load(sender, e);
            }
        }

        private void btn_buscartodas_Click(object sender, EventArgs e)
        {
            Dgv_rVentas.DataSource = N_Recibos.sp_GetReporteVentasTodas();
            ReporteVentas_Load(sender, e);
        }
    }
}
