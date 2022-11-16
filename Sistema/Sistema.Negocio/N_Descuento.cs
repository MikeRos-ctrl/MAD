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
    public class N_Descuento
    {

        public static DataTable sp_Codigo_Vali(string idDescuento)
        {
            D_Descuento Datos = new D_Descuento();
            return Datos.sp_Codigo_Vali(idDescuento);
        }


        public static DataTable sp_Get_CostoConDescuento()
        {
            D_Descuento admin = new D_Descuento();
            return admin.sp_Get_CostoConDescuento();
        }



        public static string sp_GestionarDescuentoTodo(string idDescuento, string descuento_, string IdCodigo, string fecha,
                                         string fechaAux, string Op)
        {
            D_Descuento admin = new D_Descuento();
            Descuento Obj = new Descuento();
            Obj.idDescuento = idDescuento;
            Obj.IdCodigo = IdCodigo;
            Obj.descuento_ = descuento_;
            Obj.fecha = fecha;
            Obj.fechaAux = fechaAux;
            Obj.Op = Op;

            return admin.sp_GestionarDescuento(Obj);
        }

        public static string sp_GestionarDescuento(string descuento_, string IdCodigo, string fecha,
                                         string fechaAux, string Op)
        {
            D_Descuento admin = new D_Descuento();
            Descuento Obj = new Descuento();
            Obj.descuento_ = descuento_;
            Obj.IdCodigo = IdCodigo;
            Obj.fecha = fecha;
            Obj.fechaAux = fechaAux;
            Obj.Op = Op;

            return admin.sp_GestionarDescuento(Obj);
        }
    }
}
