using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class Producto : Form
    {


        string Nombre_Actual = "";
        string CodigoProducto = "";
        string freedom = "";

        public Producto(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            uMedida.Items.Clear();
            uMedida.Items.Add("Kg");
            uMedida.Items.Add("Gr");
            uMedida.Items.Add("L");
            uMedida.Items.Add("Ml");

            nud_Existencia.ResetText();
            nud_Costo.ResetText();
            nub_PreUni.ResetText();
            nub_pReorden.ResetText();

            Descripcion.Clear();
            Adminnom.Clear();
            Adminnom.AppendText(Nombre_Actual);

            cProducto.Clear();
            CodigoProducto = Guid.NewGuid().ToString();
            cProducto.AppendText(CodigoProducto);


            cbox_departamaneto.DataSource = N_Departamento.sp_Get_Departamentos();
            cbox_departamaneto.ValueMember = "Departamento";
            cbox_departamaneto.DisplayMember = "Departamento";

            try
            {
                Dgv_rProducto.DataSource = N_Producto.sp_Get_Producto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }

        private void Dgv_rProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cProducto.Text = Dgv_rProducto.CurrentRow.Cells[0].Value.ToString();
            Adminnom.Text = Dgv_rProducto.CurrentRow.Cells[2].Value.ToString();
            cbox_departamaneto.Text = Dgv_rProducto.CurrentRow.Cells[3].Value.ToString();
            Descripcion.Text = Dgv_rProducto.CurrentRow.Cells[1].Value.ToString();
            nub_PreUni.Text = Dgv_rProducto.CurrentRow.Cells[4].Value.ToString();
            uMedida.Text = Dgv_rProducto.CurrentRow.Cells[5].Value.ToString();
            nud_Costo.Text = Dgv_rProducto.CurrentRow.Cells[6].Value.ToString();
            nud_Existencia.Text = Dgv_rProducto.CurrentRow.Cells[7].Value.ToString();
            nub_pReorden.Text = Dgv_rProducto.CurrentRow.Cells[8].Value.ToString();

            
        }


        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void nud_Costo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string Existencia_ = nud_Existencia.Text;
            string Umedida_ = uMedida.Text;
            string Costo_ = nud_Costo.Text;
            string Pre_Uni_ = nub_PreUni.Text;
            string Preorden_ = nub_pReorden.Text;
            string Departamento_ = cbox_departamaneto.Text;
            string Descripcion_ = Descripcion.Text;
            string Departamento_Pro_ = cbox_departamaneto.Text;
            string Registered_by_ = Adminnom.Text;
            string Codigo_ = cProducto.Text;

            if (Existencia_.CompareTo("") == 0 || Umedida_.CompareTo("") == 0 || Costo_.CompareTo("") == 0 ||
              Pre_Uni_.CompareTo("") == 0 || Preorden_.CompareTo("") == 0 || Departamento_.CompareTo("") == 0 ||
              Descripcion_.CompareTo("") == 0 || Departamento_Pro_.CompareTo("") == 0 || Codigo_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan llenar datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Producto.sp_GestionarProducto(Codigo_, Registered_by_, Departamento_, Descripcion_,
                                                                   Pre_Uni_, Umedida_, Costo_, Convert.ToInt32(Existencia_), Preorden_, "U");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Datos Actualizados c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inventario_Load(sender, e);

                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Inventario_Load(sender, e);
                }

            }
        }

        private void btn_bajalogica_Click(object sender, EventArgs e)
        {
            string Existencia_ = nud_Existencia.Text;
            string Umedida_ = uMedida.Text;
            string Costo_ = nud_Costo.Text;
            string Pre_Uni_ = nub_PreUni.Text;
            string Preorden_ = nub_pReorden.Text;
            string Departamento_ = cbox_departamaneto.Text;
            string Descripcion_ = Descripcion.Text;
            string Departamento_Pro_ = cbox_departamaneto.Text;
            string Registered_by_ = Adminnom.Text;
            string Codigo_ = cProducto.Text;

            if (Codigo_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan llenar datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Producto.sp_GestionarProducto(Codigo_, Registered_by_, Departamento_, Descripcion_,
                                                                   Pre_Uni_, Umedida_, Costo_, Convert.ToInt32(Existencia_), Preorden_, "B");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inventario_Load(sender, e);

                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Inventario_Load(sender, e);
                }

            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            string Existencia_ = nud_Existencia.Text;
            string Umedida_ = uMedida.Text;
            string Costo_ = nud_Costo.Text;
            string Pre_Uni_ = nub_PreUni.Text;
            string Preorden_ = nub_pReorden.Text;
            string Departamento_ = cbox_departamaneto.Text;
            string Descripcion_ = Descripcion.Text;
            string Departamento_Pro_ = cbox_departamaneto.Text;
            string Registered_by_ = Adminnom.Text;
            string Codigo_ = cProducto.Text;

            if (Existencia_.CompareTo("") == 0 || Umedida_.CompareTo("") == 0 || Costo_.CompareTo("") == 0 ||
                Pre_Uni_.CompareTo("") == 0 || Preorden_.CompareTo("") == 0 || Departamento_.CompareTo("") == 0 ||
                Descripcion_.CompareTo("") == 0 || Departamento_Pro_.CompareTo("") == 0 || Codigo_.CompareTo("") == 0 )
            {
                MessageBox.Show("Faltan llenar datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Producto.sp_GestionarProducto(Codigo_, Registered_by_, Departamento_, Descripcion_, 
                                                                   Pre_Uni_, Umedida_, Costo_, Convert.ToInt32(Existencia_), Preorden_, "I");

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inventario_Load(sender, e);

                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Inventario_Load(sender, e);
                }

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Inventario_Load(sender, e);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string Existencia_ = nud_Existencia.Text;
            string Umedida_ = uMedida.Text;
            string Costo_ = nud_Costo.Text;
            string Pre_Uni_ = nub_PreUni.Text;
            string Preorden_ = nub_pReorden.Text;
            string Departamento_ = cbox_departamaneto.Text;
            string Descripcion_ = Descripcion.Text;
            string Departamento_Pro_ = cbox_departamaneto.Text;
            string Registered_by_ = Adminnom.Text;
            string Codigo_ = cProducto.Text;

            freedom = Codigo_;

            if (Existencia_.CompareTo("") == 0 || Umedida_.CompareTo("") == 0 || Costo_.CompareTo("") == 0 ||
                Pre_Uni_.CompareTo("") == 0 || Preorden_.CompareTo("") == 0 || Departamento_.CompareTo("") == 0 ||
                Descripcion_.CompareTo("") == 0 || Departamento_Pro_.CompareTo("") == 0 || Codigo_.CompareTo("") == 0)
            {
                MessageBox.Show("No ha selecionado ninguna casilla -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Deseas eliminar el Cajero con el id " + "[" + freedom.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string respuesta = N_Producto.sp_GestionarProducto(freedom, Registered_by_, Departamento_, Descripcion_,
                                                                   Pre_Uni_, Umedida_, Costo_, Convert.ToInt32(Existencia_), Preorden_, "D");
                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Cajero Eliminado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Inventario_Load(sender, e);

                    }

                    else
                    {
                        MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Inventario_Load(sender, e);
                    }
                }
            }
        }

        private void cbox_departamaneto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_rProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
        private void cProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_VerModCajero_Click(object sender, EventArgs e)
        {
            VerModProducto xd = new VerModProducto(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void dtn_gendescuento_Click(object sender, EventArgs e)
        {
            Descuentos xd = new Descuentos(Nombre_Actual);
            xd.Show();
            this.Hide();

        }
    }
}
