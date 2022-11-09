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
    public partial class VerModProducto : Form
    {
        string Nombre_Actual = "";

        public VerModProducto(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
        }

        private void VerModProducto_Load(object sender, EventArgs e)
        {
            try
            {
                Dgv_ModProducto.DataSource = N_Producto.sp_Get_ModProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Producto xd = new Producto(Nombre_Actual);
            xd.Show();
            this.Hide();
        }
    }
}
