using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class N_Venta
    {
   

        public static DataTable sp_Busqueda_Ventas(string Parametro)
        {
            D_Venta Datos = new D_Venta();
            return Datos.sp_Busqueda_Ventas(Parametro);
        }

        public static DataTable sp_Carrito_Vali(string Codigo)
        {
            D_Venta Datos = new D_Venta();
            return Datos.sp_Carrito_Vali(Codigo);
        }

        public static DataTable sp_Get_Vcarrito()
        {
            D_Venta admin = new D_Venta();
            return admin.sp_Get_Vcarrito();
        }

        public static DataTable sp_Get_Ventas()
        {
            D_Venta admin = new D_Venta();
            return admin.sp_Get_Ventas();
        }


        public static string sp_vender (string codigo, string nombreP, int Cantidad, string Op)
        {
            D_Venta admin = new D_Venta();
            Venta Obj = new Venta();
            Obj.codigo = codigo;
            Obj.nombreP = nombreP;
            Obj.Cantidad = Cantidad;
            Obj.Op = Op;

            return admin.sp_vender(Obj);
        }

    }
}
