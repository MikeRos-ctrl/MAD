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
    public partial class InicioCajero : Form
    {
        public InicioCajero()
        {
            InitializeComponent();
        }

        private void btn_devoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Devueltos xd = new Devueltos();
            xd.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin xd = new InicioAdmin();
            xd.Show();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario xd = new Inventario();
            xd.Show();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaRecibo xd = new ConsultaRecibo();
            xd.Show();
        }
    }
}
