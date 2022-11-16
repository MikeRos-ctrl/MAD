using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Sistema.Negocio;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Presentacion
{
    public partial class ConsultaRecibo : Form
    {
        string Nombre_Actual = "";
        string Nombre_Caja = "";
        string Numero_Pedidos = "";
        string Clave_Actual = "";
        //string tienemerma = "";

        string id_ = ""; 
        string Codigo_ = "";
        string hora_ = "";
        string codigo_ = "";

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


             ClaveCa.Text = Clave_Actual;

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
            producto.Text = Dgv_cRecibos.CurrentRow.Cells[4].Value.ToString();
            caja.Text = Dgv_cRecibos.CurrentRow.Cells[5].Value.ToString();
            tipopago.Text = Dgv_cRecibos.CurrentRow.Cells[7].Value.ToString();
            subtotal.Text = Dgv_cRecibos.CurrentRow.Cells[11].Value.ToString();
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

        private void btn_recibo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Imprimiendo copia de recibo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string Numero_ = cb_numRecibos.Text;
            string creacionhora_ = hora.Text;
            string clave_ = ClaveCa.Text;
            DataTable table = new DataTable();
            table = N_Recibos.sp_GetRecibo(cb_numRecibos.Text);
            Numero_Pedidos = Convert.ToString(table.Rows.Count);
            string Caja_ = Convert.ToString(table.Rows[0][5]);
            string Cajero_ = Convert.ToString(table.Rows[0][6]);
            string Pago = Convert.ToString(table.Rows[0][7]);
            string creacion_ = Convert.ToString(table.Rows[0][14]);
            string Total_ = Convert.ToString(table.Rows[0][13]);

            Document PDF = new Document(); //Creacion del documento PDF
            Page page1 = PDF.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina
            BackgroundArtifact bg = new BackgroundArtifact();
            bg.BackgroundImage = File.OpenRead("Recibo.jpg");
            page1.Artifacts.Add(bg);

            string Idrecibos = Numero_;
            TextFragment txtIdrecibo = new TextFragment(Idrecibos);
            txtIdrecibo.Position = new Position(70, 665);
            txtIdrecibo.TextState.FontSize = 15;
            txtIdrecibo.TextState.Font = FontRepository.FindFont("Arial");
            txtIdrecibo.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            string Cajero = Cajero_;
            TextFragment txtcajero = new TextFragment(Cajero);
            txtcajero.Position = new Position(225, 715);
            txtcajero.TextState.FontSize = 15;
            txtcajero.TextState.Font = FontRepository.FindFont("Arial");
            txtcajero.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            string Clave = clave_;
            TextFragment txtclave = new TextFragment(Clave);
            txtclave.Position = new Position(260, 690);
            txtclave.TextState.FontSize = 15;
            txtclave.TextState.Font = FontRepository.FindFont("Arial");
            txtclave.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            string Fecha = creacion_;
            TextFragment txtfecha = new TextFragment(Fecha);
            txtfecha.Position = new Position(400, 665);
            txtfecha.TextState.FontSize = 15;
            txtfecha.TextState.Font = FontRepository.FindFont("Arial");
            txtfecha.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            string Metodopago = Pago;
            TextFragment txtpago = new TextFragment(Metodopago);
            txtpago.Position = new Position(240, 200);
            txtpago.TextState.FontSize = 18;
            txtpago.TextState.Font = FontRepository.FindFont("Arial");
            txtpago.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder txtBuilder = new TextBuilder(page1);
            txtBuilder.AppendText(txtIdrecibo);
            txtBuilder.AppendText(txtcajero);
            txtBuilder.AppendText(txtclave);
            txtBuilder.AppendText(txtfecha);
            txtBuilder.AppendText(txtpago);
            PDF.Save("Recibos reImpresos\\Copia ticket de compra - " + Idrecibos + ".pdf");

            //edit1
            var fileRecibo = @"Recibos reImpresos\\Copia ticket de compra - " + Idrecibos + ".pdf";
            Document editPDF = new Document(fileRecibo);
            Page pdfPage2 = (Page)editPDF.Pages[1];


            string Caja = Caja_;
            TextFragment txtcaja = new TextFragment(Caja);
            txtcaja.Position = new Position(270, 140);
            txtcaja.TextState.FontSize = 18;
            txtcaja.TextState.Font = FontRepository.FindFont("Arial");
            txtcaja.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            //altura 275 total
            string Total = "$" + Total_;
            TextFragment txttotal = new TextFragment(Total);
            txttotal.Position = new Position(495, 275);
            txttotal.TextState.FontSize = 18;
            txttotal.TextState.Font = FontRepository.FindFont("Arial");
            txttotal.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder txtBuilderS = new TextBuilder(pdfPage2);
            txtBuilderS.AppendText(txtcaja);
            txtBuilderS.AppendText(txttotal);
            editPDF.Save("Recibos reImpresos\\Copia ticket de compra - " + Idrecibos + ".pdf");


            var fileRecibo2 = @"Recibos reImpresos\\Copia ticket de compra - " + Idrecibos + ".pdf";
            Document editPDF2 = new Document(fileRecibo2);
            Page pdfPage3 = (Page)editPDF2.Pages[1];


            int pos = 60;
            for (int i = 0; i < int.Parse(Numero_Pedidos); i++)
            {
                string cantab = Convert.ToString(table.Rows[i][9]);
                string preuni = Convert.ToString(table.Rows[i][10]);
                string desc = Convert.ToString(table.Rows[i][12]);
                string importe = Convert.ToString(table.Rows[i][11]);
                string Um = Convert.ToString(table.Rows[i][8]);
                string produc = Convert.ToString(table.Rows[i][4]);
                string depa = Convert.ToString(table.Rows[i][3]);

                string Cantidad = cantab;
                TextFragment txtcantidad = new TextFragment(Cantidad);
                txtcantidad.Position = new Position(60, 575 - (i * pos));
                txtcantidad.TextState.FontSize = 12;
                txtcantidad.TextState.Font = FontRepository.FindFont("Arial");
                txtcantidad.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                string PrecioUni = "$" + preuni;
                TextFragment txtpreciouni = new TextFragment(PrecioUni);
                txtpreciouni.Position = new Position(155, 575 - (i * pos));
                txtpreciouni.TextState.FontSize = 12;
                txtpreciouni.TextState.Font = FontRepository.FindFont("Arial");
                txtpreciouni.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                string Descuento = desc;
                TextFragment txtdesc = new TextFragment(Descuento);
                txtdesc.Position = new Position(300, 575 - (i * pos));
                txtdesc.TextState.FontSize = 12;
                txtdesc.TextState.Font = FontRepository.FindFont("Arial");
                txtdesc.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                string Importe = "$" + importe;
                TextFragment txtimport = new TextFragment(Importe);
                txtimport.Position = new Position(495, 575 - (i * pos));
                txtimport.TextState.FontSize = 12;
                txtimport.TextState.Font = FontRepository.FindFont("Arial");
                txtimport.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                string Producto = depa + "   |   " + produc + "   |   " + Um;
                TextFragment txtpro = new TextFragment(Producto);
                txtpro.Position = new Position(60, 600 - (i * pos));
                txtpro.TextState.FontSize = 12;
                txtpro.TextState.Font = FontRepository.FindFont("Arial");
                txtpro.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);


                TextBuilder txtBuilderT = new TextBuilder(pdfPage3);
                txtBuilderT.AppendText(txtcantidad);
                txtBuilderT.AppendText(txtpreciouni);
                txtBuilderT.AppendText(txtdesc);
                txtBuilderT.AppendText(txtimport);
                txtBuilderT.AppendText(txtpro);

            }
            editPDF2.Save("Recibos reImpresos\\Copia ticket de compra - " + Idrecibos.ToString() + ".pdf");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("h:mm:ss");
        }
    }
}
