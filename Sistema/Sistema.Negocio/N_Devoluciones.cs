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
    public class N_Devoluciones
    {
        public static DataTable sp_Get_devoluciones()
        {
            D_Devoluciones admin = new D_Devoluciones();
            return admin.sp_Get_devoluciones();
        }


        public static string sp_devoluciones ( int IDr, string codigo, string motivo, string merma)
        {
            D_Devoluciones Datos = new D_Devoluciones();
            Devoluciones Obj = new Devoluciones();
            Obj.IDr = IDr;
            Obj.codigo = codigo;
            Obj.motivo = motivo;
            Obj.merma = merma;
            return Datos.sp_devoluciones(Obj);
        }

        public static DataTable sp_GetInventario(string Parametro, int canExi)
        {
            D_Devoluciones Datos = new D_Devoluciones();
            return Datos.sp_GetInventario(Parametro, canExi);
        }

        public static DataTable sp_GetInventarioMerma(string Parametro, int canExi, string merma)
        {
            D_Devoluciones Datos = new D_Devoluciones();
            return Datos.sp_GetInventarioMerma(Parametro, canExi, merma);
        }


        public static DataTable sp_GetInventarioTodo()
        {
            D_Devoluciones Datos = new D_Devoluciones();
            return Datos.sp_GetInventarioTodo();
        }

    }
}
