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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }


        private void btn_inventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario xd = new Inventario();
            xd.Show();
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_usurio_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroEmpleado xd = new RegistroEmpleado();
            xd.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login xd = new Login();
            xd.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarProducto xd = new EditarProducto();
            xd.Show();
        }

        private void btn_rVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteVentas xd = new ReporteVentas();
            xd.Show();
        }

        private void btn_rCajero_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteCajero xd = new ReporteCajero();
            xd.Show();
        }
        private void btn_logusuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginCajero xd = new LoginCajero();
            xd.Show();
        }

    }
}
