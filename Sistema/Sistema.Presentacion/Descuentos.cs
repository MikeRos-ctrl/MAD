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
    public partial class Descuentos : Form
    {

        string Nombre_Actual = "";

        public Descuentos(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {

            nud_Descuento.ResetText();

            idDescu.Clear();

            cbox_Codigo.DataSource = N_Producto.sp_Get_Producto();
            cbox_Codigo.ValueMember = "Codigo del producto";
            cbox_Codigo.DisplayMember = "Codigo del producto";

            try
            {
                Dgv_rDescuento.DataSource = N_Descuento.sp_Get_CostoConDescuento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string Descuento_ = nud_Descuento.Text;
            string id_ = idDescu.Text;
            string codigo = cbox_Codigo.Text;
            string Finicio_ = dtp_fInicio.Text;
            string Ffin_ = dtp_fFin.Text;



            if (Descuento_.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar el nombre del Departamento -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable table = new DataTable();
                table = N_Descuento.sp_Codigo_Vali(id_);
                if (table.Rows.Count != 0)  // Validacion, si ya Existe
                {

                    MessageBox.Show("Este producto ya tiene descuento", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                { 

                    string respuesta = N_Descuento.sp_GestionarDescuento(Descuento_, codigo, Finicio_, Ffin_, "I");

                    if (respuesta.Equals("OK"))
                    {

                        MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Descuentos_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Descuentos_Load(sender, e);
                    }

                }

            }







        }

        private void nud_Descuento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idDescu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string id_ = idDescu.Text;
            string Descuento_ = nud_Descuento.Text;
            string codigo = cbox_Codigo.Text;
            string Finicio_ = dtp_fInicio.Text;
            string Ffin_ = dtp_fFin.Text;

            if (id_.CompareTo("") == 0 || Descuento_.CompareTo("") == 0 
                || Finicio_.CompareTo("") == 0 || Ffin_.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar el nombre del Departamento -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Descuento.sp_GestionarDescuentoTodo(id_, Descuento_, codigo, Finicio_, Ffin_, "U");
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Descuentos_Load(sender, e);

                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Descuentos_Load(sender, e);
                }

            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Producto xd = new Producto(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void Dgv_rDescuento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Dgv_rDescuento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nud_Descuento.Text = Dgv_rDescuento.CurrentRow.Cells[2].Value.ToString();
            idDescu.Text = Dgv_rDescuento.CurrentRow.Cells[0].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbox_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
        private void Dgv_Carrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Dgv_Carrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
