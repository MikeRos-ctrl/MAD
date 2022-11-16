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
    public partial class Departamento : Form
    {

        string Nombre_Actual = "";
 


        public Departamento(string Nombre)
        {
            InitializeComponent();
            Nombre_Actual = Nombre;

        }

        //private void btn_eliminar_Click(object sender, EventArgs e)
        //{
        //    string id_ = idDepa.Text;
        //    string NomCompleto_ = Depa.Text;
        //    string Registered_by_ = Registeredby.Text;

        //    freedom = id_;

        //    if (id_.CompareTo("") == 0 || NomCompleto_.CompareTo("") == 0)
        //    {
        //        MessageBox.Show("No ha selecionado ninguna casilla -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        DialogResult Opcion;
        //        Opcion = MessageBox.Show("Deseas eliminar el Cajero con el id " + "[" + freedom.ToString() + "]" + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        //        if (Opcion == DialogResult.OK)
        //        {
        //            string respuesta = N_Departamento.sp_GestionarDepartamentos(freedom, Registered_by_, NomCompleto_, "D");
        //            if (respuesta.Equals("OK"))
        //            {
        //                MessageBox.Show("Cajero Eliminado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                Departamento_Load(sender, e);

        //            }

        //            else
        //            {
        //                MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                Departamento_Load(sender, e);
        //            }
        //        }
        //    }
            
        //}

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string id_ = idDepa.Text;
            string NomCompleto_ = Depa.Text;
            string Registered_by_ = Registeredby.Text;

            if (NomCompleto_.CompareTo("") == 0)
            {
                MessageBox.Show("Favor de llenar el nombre del Departamento -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Departamento.sp_GestionarDepartamentosInserto( Registered_by_, NomCompleto_, "I");
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Nuevo Registro Insertado c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Departamento_Load(sender, e);

                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Departamento_Load(sender, e);
                }

            }
           
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Departamento_Load(sender, e);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string id_ = idDepa.Text;
            string NomCompleto_ = Depa.Text;
            string Registered_by_ = Registeredby.Text;
            if (id_.CompareTo("") == 0 || NomCompleto_.CompareTo("") == 0 || Registered_by_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan Datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Departamento.sp_GestionarDepartamentos(id_, Registered_by_, NomCompleto_, "U");


                if (respuesta.Equals("OK"))
                {

                    MessageBox.Show("Datos Actualizados c:", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Departamento_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Departamento_Load(sender, e);
                }
            }

        }

        private void Departamento_Load(object sender, EventArgs e)
        {

            idDepa.Clear();
            Depa.Clear();
            Registeredby.Clear();
            Registeredby.AppendText(Nombre_Actual);

            try
            {
                Dgv_rDepartamento.DataSource = N_Departamento.sp_Get_Departamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            InicioAdmin xd = new InicioAdmin(Nombre_Actual);
            xd.Show();
            this.Hide();
        }

        private void Dgv_rDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Depa.Text = Dgv_rDepartamento.CurrentRow.Cells[2].Value.ToString();
            idDepa.Text = Dgv_rDepartamento.CurrentRow.Cells[0].Value.ToString();
            Registeredby.Text = Dgv_rDepartamento.CurrentRow.Cells[1].Value.ToString();
        }

        private void Dgv_rDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_bajalogica_Click(object sender, EventArgs e)
        {
            string id_ = idDepa.Text;
            string NomCompleto_ = Depa.Text;
            string Registered_by_ = Registeredby.Text;
            if (id_.CompareTo("") == 0 || NomCompleto_.CompareTo("") == 0 || Registered_by_.CompareTo("") == 0)
            {
                MessageBox.Show("Faltan Datos -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Departamento.sp_GestionarDepartamentos(id_, Registered_by_, NomCompleto_, "B");


                if (respuesta.Equals("OK"))
                {

                    MessageBox.Show("Eliminación logica hecha", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Departamento_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Departamento_Load(sender, e);
                }
            }

        }
    }
}
