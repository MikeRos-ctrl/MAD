using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class N_Producto
    {
   

        public static DataTable Get_existencia_producto(string Descripcion)
        {
            D_Producto Datos = new D_Producto();
            return Datos.Get_existencia_producto(Descripcion);
        }


        public static DataTable sp_Get_PuntoRe()
        {
            D_Producto admin = new D_Producto();
            return admin.sp_Get_PuntoRe();
        }


        public static DataTable sp_Get_Producto()
        {
            D_Producto admin = new D_Producto();
            return admin.sp_Get_Producto();
        }

        public static string sp_GestionarProducto(string codigo, string registered_by, string departamento, string descripcion, 
                                                 string precio_unitario, string unidad_de_medida, string costo, int existencia, 
                                                 string punto_de_reorden, string Op)
        {
            D_Producto admin = new D_Producto();
            Producto Obj = new Producto();
            Obj.codigo = codigo;
            Obj.registered_by = registered_by;
            Obj.departamento = departamento;
            Obj.descripcion = descripcion;
            Obj.precio_unitario = precio_unitario;
            Obj.unidad_de_medida = unidad_de_medida;
            Obj.costo = costo;
            Obj.existencia = existencia;
            Obj.punto_de_reorden = punto_de_reorden;
            Obj.Op = Op;

            return admin.sp_GestionarProducto(Obj);
        }

        public static string sp_GestionarProduPu(string codigo, string registered_by, int existencia)
        {
            D_Producto admin = new D_Producto();
            Producto Obj = new Producto();
            Obj.codigo = codigo;
            Obj.registered_by = registered_by;
            Obj.existencia = existencia;


            return admin.sp_GestionarProduPu(Obj);
        }

        public static DataTable sp_Get_ModProducto()
        {
            D_Producto admin = new D_Producto();
            return admin.sp_Get_ModProducto();
        }
    }

   
}
