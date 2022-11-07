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

        private string name = "";

        public InicioAdmin(string Nombre)
        {
            InitializeComponent();
            this.name = Nombre;

        }



        private void InicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_usurio_Click(object sender, EventArgs e)
        { 

            RegistroEmpleado who = new RegistroEmpleado(this.name);
            who.Show();
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login xd = new Login();
            xd.Show();
        }


        private void btn_rVentas_Click(object sender, EventArgs e)
        {
            ReporteVentas xd = new ReporteVentas(this.name);

            xd.Show();
            this.Hide();
        }

        private void btn_rCajero_Click(object sender, EventArgs e)
        {
 
            ReporteCajero xd = new ReporteCajero(this.name);
            xd.Show();
            this.Hide();
        }

        private void btn_verCajero_Click(object sender, EventArgs e)
        {

     
            VerCajero xd = new VerCajero(this.name);
            xd.Show();
            this.Hide();

        }

        private void btn_productos_Click(object sender, EventArgs e)
        {

            Producto xd = new Producto(this.name);
            xd.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
