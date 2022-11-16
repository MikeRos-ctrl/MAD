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
    public partial class ConsultaRecibo : Form
    {
        string Nombre_Actual = "";
        string Nombre_Caja = "";
        string Clave_Actual = "";
        //string tienemerma = "";

        string id_ = ""; 
        string Codigo_ = "";

        public ConsultaRecibo(string Nombre, string Clave, string Caja)
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

        private void ConsultaRecibo_Load(object sender, EventArgs e)
        {

            codigo.Clear();
            producto.Clear();
            caja.Clear();
            tipopago.Clear();
            subtotal.Clear();

            cb_numRecibos.ResetText();

            cb_numRecibos.DataSource = N_Recibos.sp_GetnumRe();
            cb_numRecibos.ValueMember = "IdRecibo";
            cb_numRecibos.DisplayMember = "IdRecibo";

            Dgv_cRecibos.DataSource = N_Recibos.sp_GetRecibo(cb_numRecibos.Text);
            string dato = cb_numRecibos.Text;
            if (dato.CompareTo("") == 0)
            {
                ConsultaRecibo_Load(sender, e);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Dgv_cRecibos.DataSource = N_Recibos.sp_GetRecibo(cb_numRecibos.Text);
            string dato = cb_numRecibos.Text;

            if (dato.CompareTo("") == 0)
            {
                ConsultaRecibo_Load(sender, e);
            }

        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {

            string Merma = cb_tienemerma.Text;
            string motivo_ = motivo.Text;
            string id_ = ID.Text;
            string codigo_ = codigopro.Text;
            if (cb_tienemerma.Checked == true)
            {
                Merma = "Tiene merma";
            }
            else
            {
                Merma = "No tiene merma";
            }

            if (id_.CompareTo("") == 0 || motivo_.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = N_Devoluciones.sp_devoluciones(Int32.Parse(id_), codigo_, motivo_ ,Merma);

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Se ha devuelto el producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      ConsultaRecibo_Load(sender, e);
               ;
                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConsultaRecibo_Load(sender, e);
                }
            }


        }

        private void btn_devolvertodo_Click(object sender, EventArgs e)
        {
                string motivo_ = motivo.Text;
                string Merma = cb_tienemerma.Text;
                

            if (cb_tienemerma.Checked == true)
            {
                Merma = "Tiene merma";
            }
            else
            {
                Merma = "No tiene merma";
            }


            if (motivo_.CompareTo("") == 0)
            {
                MessageBox.Show("Datos vacios -.-", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string respuesta = "";

                foreach (DataGridViewRow row in Dgv_cRecibos.Rows)
                {

                    if (row.Cells["ID"].Value != null && row.Cells["Codigo del producto"].Value != null)
                    {

                        id_ = row.Cells["ID"].Value.ToString();
                        Codigo_ = row.Cells["Codigo del producto"].Value.ToString();

                        respuesta = N_Devoluciones.sp_devoluciones(Int32.Parse(id_), Codigo_, motivo_, Merma);

                    }


                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Se devolvieron todos los productos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConsultaRecibo_Load(sender, e);


                }
                else
                {
                    MessageBox.Show(respuesta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConsultaRecibo_Load(sender, e);
                }

            }




        }

        private void subtotal_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ConsultaRecibo_Load(sender, e);
        }

        private void Dgv_cRecibos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = Dgv_cRecibos.CurrentRow.Cells[0].Value.ToString();
            codigo.Text = Dgv_cRecibos.CurrentRow.Cells[1].Value.ToString();
            codigopro.Text = Dgv_cRecibos.CurrentRow.Cells[2].Value.ToString();
            producto.Text = Dgv_cRecibos.CurrentRow.Cells[3].Value.ToString();
            caja.Text = Dgv_cRecibos.CurrentRow.Cells[4].Value.ToString();
            tipopago.Text = Dgv_cRecibos.CurrentRow.Cells[5].Value.ToString();
            subtotal.Text = Dgv_cRecibos.CurrentRow.Cells[7].Value.ToString();
        }

        private void rb_tienemerma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_cRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }
    }
}
