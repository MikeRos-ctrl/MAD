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
  

    public partial class Inventario : Form
    {
        string Nombre_Actual = "";
        string Nombre_Caja = "";
        string Clave_Actual = "";


        public Inventario(string Nombre, string Clave, string Caja)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
            Nombre_Caja = Caja;
            Clave_Actual = Clave;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cb_Departamento.DataSource = N_Recibos.sp_Departamento();
            cb_Departamento.ValueMember = "departamento";
            cb_Departamento.DisplayMember = "departamento";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioCajero xd = new InicioCajero(Nombre_Actual, Clave_Actual, Nombre_Caja);
            xd.Show();
        }

        private void btn_recibo_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string merma_ = merma.Text;
            string depa = cb_Departamento.Text;
            int cantidad_ = 0;


            //merma.Text = "tiene merma";


       


            if (merma.Checked == true)
            {
                merma_ = "tiene merma";

                if (Agotados.Checked == true)
                {

                }
                else if (Agotados.Checked == false)
                {
                    cantidad_ = Int32.Parse(Existencia.Text);
                }

                Dgv_inventario.DataSource = N_Devoluciones.sp_GetInventarioMerma(cb_Departamento.Text, cantidad_, merma_);

            }
            else if (merma.Checked == false)
            {

                if (Agotados.Checked == true)
                {

                }
                else if (Agotados.Checked == false)
                {
                    cantidad_ = Int32.Parse(Existencia.Text);
                }

                Dgv_inventario.DataSource = N_Devoluciones.sp_GetInventario(cb_Departamento.Text, cantidad_);

            }





      
            if (depa.CompareTo("") == 0 || cantidad_.CompareTo(0) == 0)
            {

            

                Inventario_Load(sender, e);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscartodas_Click(object sender, EventArgs e)
        {

            Dgv_inventario.DataSource = N_Devoluciones.sp_GetInventarioTodo();
            Inventario_Load(sender, e);
        }
    }
}
