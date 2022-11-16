using Sistema.Entidades;
using System.Data;
using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class N_Recibos
    {
        public static string sp_Recibo(int IdRecibo, string codigo, string Cajero, string caja, string produc,
                                    string forma_pago, string departamento, string cantidad, string subtotal, int total, DateTime fecha_creacion)
        {
            D_Recibos Datos = new D_Recibos();
            Recibos Obj = new Recibos();
            Obj.IdRecibo = IdRecibo;
            Obj.codigo = codigo;
            Obj.Cajero = Cajero;
            Obj.caja = caja;
            Obj.produc = produc;
            Obj.forma_pago = forma_pago;
            Obj.departamento = departamento;
            Obj.cantidad = cantidad;
            Obj.subtotal = subtotal;
            Obj.total = total;
            Obj.fecha_creacion = fecha_creacion;
            return Datos.sp_Recibo(Obj);
        }



        public static DataTable sp_GetRecibo(string Id)
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_GetRecibo(Id);
        }

        public static DataTable sp_GetReporteCajero(string cajero, string departamento, string fecha1, string fecha2)
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_GetReporteCajero(cajero, departamento, fecha1, fecha2);
        }

        public static DataTable sp_GetReporteVentas(string caja, string departamento, string fecha1, string fecha2)
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_GetReporteVentas(caja, departamento, fecha1, fecha2);
        }

        public static DataTable sp_GetReporteCajeroTodos()
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_GetReporteCajeroTodos();
        }

        public static DataTable sp_GetReporteVentasTodas()
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_GetReporteVentasTodas();
        }

        public static DataTable sp_GetnumRe()
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_GetnumRe();
        }

        public static DataTable sp_Departamento()
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_Departamento();
        }

        public static DataTable sp_Cajero()
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_Cajero();
        }
        public static DataTable sp_Caja()
        {
            D_Recibos admin = new D_Recibos();
            return admin.sp_Caja();
        }


    }
}
