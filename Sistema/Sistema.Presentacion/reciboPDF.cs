using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Negocio;

//namespace Sistema.Presentacion
//{
//    class PDFrecibo
//    {
//        static public void reporte_tarifas(List<N_Recibos> recibo)
//        {
//            Document pdfDocument = new Document(); //Creacion del documento PDF
//            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

//            BackgroundArtifact bg = new BackgroundArtifact();
//            bg.BackgroundImage = File.OpenRead("Recibo.jpg");
//            page1.Artifacts.Add(bg);


//            TextFragment IdRecibo = generadorTexto(10, recibo[i].IdRecibo.ToString(), 65, 600 - (i * pos));
//            //TextFragment mes = generadorTexto(10, textoMes(tarifas[i].mes), 130, 600 - (i * pos));
//            //TextFragment zona = generadorTexto(10, tarifas[i].zona.ToString() + i.ToString(), 195, 600 - (i * pos));
//            //TextFragment cuota = generadorTexto(10, tarifas[i].cuota.ToString(), 260, 600 - (i * pos));

//            TextBuilder txtBuilder = new TextBuilder(page1);
//            txtBuilder.AppendText(IdRecibo);
//            txtBuilder.AppendText(mes);
//            txtBuilder.AppendText(zona);
//            txtBuilder.AppendText(cuota);


//            int pos = 25;
//            for (int i = 0; i < recibo.Count; i++)
//            {


//                TextFragment basico = generadorTexto(10, tarifas[i].basico.ToString(), 370, 600 - (i * pos));
//                TextFragment intermedio = generadorTexto(10, tarifas[i].intermedio.ToString(), 435, 600 - (i * pos));
//                TextFragment excedente = generadorTexto(10, tarifas[i].excedente.ToString(), 500, 600 - (i * pos));

//                TextBuilder txtBuilder2 = new TextBuilder(page1);
//                txtBuilder2.AppendText(basico);
//                txtBuilder2.AppendText(intermedio);
//                txtBuilder2.AppendText(excedente);
//            }

//            string pdfName = "Recibos/Ticket de compra - " + IdRecibo[0].ToString() + ".pdf";
//            pdfDocument.Save(pdfName);
//        }



//        static public void reciboPDF(Recibos recibos, Cajero cajero, Departamento departamento, Descuento descuento, Venta venta, Producto producto)
//        {
//            Document pdfDocument = new Document(); //Creacion del documento PDF
//            Page page1 = pdfDocument.Pages.Add(); //Generar una nueva pagina y devolver la instancia de dicha pagina

//            BackgroundArtifact bg = new BackgroundArtifact();
//            bg.BackgroundImage = File.OpenRead("recibo.png");
//            page1.Artifacts.Add(bg);

//            //---------------------------------------------------
//            string nombre_completo = cliente.nombre;
//            string location = contrato.municipio + ", NUEVO LEON";
//            string domicilio = contrato.cod_postal + ", " + contrato.colonia + ", " + contrato.calle + ", " + contrato.num_ext;
//            string rfc = cliente.rfc;
//            string num_ref = contrato.num_ref.ToString();
//            TextFragment txtName = generadorTexto(12, nombre_completo, 100, 705, "negro");
//            TextFragment txtLocation = generadorTexto(6, location, 110, 695, "negro");
//            TextFragment txtDomicilio = generadorTexto(8, domicilio, 110, 685, "negro");
//            TextFragment txtRfc = generadorTexto(12, rfc, 80, 665, "negro");
//            TextFragment txtNumRef = generadorTexto(10, num_ref, 140, 645, "negro");

//            TextBuilder txtBuilder = new TextBuilder(page1);
//            txtBuilder.AppendText(txtName);
//            txtBuilder.AppendText(txtLocation);
//            txtBuilder.AppendText(txtDomicilio);
//            txtBuilder.AppendText(txtRfc);
//            txtBuilder.AppendText(txtNumRef);

//            ////----------------------------------------------------
//            string f_vencimiento = "24 - " + textoMes(recibo.mes);
//            string mes_fac = textoMes(recibo.mes);
//            string localidad_expedicion = contrato.municipio;
//            string tarifa = contrato.tipo + " - CAT: " + contrato.categoria;
//            string zona = contrato.zona;
//            TextFragment txtFVencimiento = generadorTexto(10, f_vencimiento, 420, 705, "negro");
//            TextFragment txtMesFac = generadorTexto(10, mes_fac, 440, 685, "negro");
//            TextFragment txtExpedicion = generadorTexto(10, localidad_expedicion, 475, 665, "negro");
//            TextFragment txtTarifa = generadorTexto(10, tarifa, 380, 645, "negro");
//            TextFragment txtZona = generadorTexto(10, zona, 375, 620, "negro");

//            TextBuilder txtBuilder2 = new TextBuilder(page1);
//            txtBuilder2.AppendText(txtFVencimiento);
//            txtBuilder2.AppendText(txtMesFac);
//            txtBuilder2.AppendText(txtExpedicion);
//            txtBuilder2.AppendText(txtTarifa);
//            txtBuilder2.AppendText(txtZona);

//            ////----------------------------------------------------
//            TextFragment txtMedidor = generadorTexto(10, contrato.medidor.ToString(), 100, 620);

//            TextBuilder txtBuilder4 = new TextBuilder(page1);
//            txtBuilder4.AppendText(txtMedidor);

//            ////----------------------------------------------------
//            TextFragment txtLecturaAnterior;
//            TextFragment txtConsumo;
//            if (lectura_ant == null)
//            {
//                txtLecturaAnterior = generadorTexto(10, "0", 155, 535);
//                txtConsumo = generadorTexto(10, lectura.consumo.ToString(), 190, 495);
//            }
//            else
//            {
//                txtLecturaAnterior = generadorTexto(10, lectura_ant.consumo.ToString(), 155, 535);
//                txtConsumo = generadorTexto(10, (lectura.consumo - lectura_ant.consumo).ToString(), 190, 495);
//            }
//            TextFragment txtLectura = generadorTexto(10, lectura.consumo.ToString(), 145, 515);
//            TextFragment txtMeses = generadorTexto(10, recibo.meses_adeudo.ToString(), 450, 535);

//            TextBuilder txtBuilder5 = new TextBuilder(page1);
//            txtBuilder5.AppendText(txtLecturaAnterior);
//            txtBuilder5.AppendText(txtLectura);
//            txtBuilder5.AppendText(txtConsumo);
//            txtBuilder5.AppendText(txtMeses);

//            ////----------------------------------------------------
//            TextFragment sub1 = generadorTexto(12, "$ " + recibo.subtotal1.ToString("0.00"), 500, 250, "negro");
//            TextFragment sub2 = generadorTexto(12, "$ " + recibo.subtotal2.ToString("0.00"), 500, 225, "negro");
//            TextFragment cuota = generadorTexto(12, "$ " + _tarifa.cuota.ToString("0.00"), 500, 200, "negro");
//            TextFragment total = generadorTexto(12, "$ " + recibo.subtotal3.ToString("0.00"), 500, 175, "negro");
//            TextFragment iva = generadorTexto(12, "$ " + recibo.iva.ToString("0.00"), 500, 150, "negro");

//            TextBuilder txtBuilder3 = new TextBuilder(page1);
//            txtBuilder3.AppendText(sub1);
//            txtBuilder3.AppendText(sub2);
//            txtBuilder3.AppendText(cuota);
//            txtBuilder3.AppendText(total);
//            txtBuilder3.AppendText(iva);

//            TextFragment deuda = generadorTexto(12, "$ " + recibo.pendiente_pago.ToString("0.00"), 500, 125, "negro");
//            TextFragment totalPagar = generadorTexto(12, "$ " + recibo.total_pago.ToString("0.00"), 500, 100, "negro");
//            int temp = (int)recibo.total_pago;
//            float centavos = (recibo.total_pago - temp) * 10;
//            TextFragment totalLetras = generadorTexto(9, NumeroALetras(recibo.total_pago) + "PESOS CON " + NumeroALetras(centavos) + " CENTAVOS", 200, 75, "negro");

//            TextBuilder txtBuilder6 = new TextBuilder(page1);
//            txtBuilder6.AppendText(deuda);
//            txtBuilder6.AppendText(totalPagar);
//            txtBuilder6.AppendText(totalLetras);
//            //----------------------------------------------------

//            string pdfName = "Recibos/" + "GpiiRecibo-" + cliente.id + "_" + contrato.num_ref + "_" + recibo.mes + "_" + recibo.año + ".pdf";
//            pdfDocument.Save(pdfName);
//        }

//    }
//}
