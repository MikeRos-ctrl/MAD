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
    public class N_Cajero
    {


        public static DataTable sp_Login_Cajeros(string correo)
        {
            D_Cajero Datos = new D_Cajero();
            return Datos.sp_Login_Cajeros(correo);
        }

        public static string sp_GestionarCajero(string clave, string registered_by,string nombre,string curp,
            string fecha_nacimiento,string nomina,string correo,string contra, string Op)
        {
            D_Cajero admin = new D_Cajero();
            Cajero Obj = new Cajero();
            Obj.clave = clave;
            Obj.registered_by = registered_by;
            Obj.nombre = nombre;
            Obj.curp = curp;
            Obj.fecha_nacimiento = fecha_nacimiento;
            Obj.nomina = nomina;
            Obj.correo = correo;
            Obj.contra = contra;
            Obj.Op = Op;

            return admin.sp_GestionarCajero(Obj);
        }

        public static DataTable sp_Get_Cajero()
        {
            D_Cajero admin = new D_Cajero();
            return admin.sp_Get_Cajero();
        }

        public static DataTable sp_Get_ModCajero()
        {
            D_Cajero admin = new D_Cajero();
            return admin.sp_Get_ModCajero();
        }
    }
}
