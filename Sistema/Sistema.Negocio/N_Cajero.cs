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

       

        public static DataTable Login_Cajeros(string correo)
        {
            D_Cajero Datos = new D_Cajero();
            return Datos.Login_Cajeros(correo);
        }

        public static string Eliminar_Cajero (string clave)
        {
            D_Cajero xd= new D_Cajero();
            return xd.Eliminar_Cajero(clave);
        }

        public static string Insert_Cajero(string clave, string registered_by,string nombre,string curp,
            string fecha_nacimiento,string nomina,string correo,string contra)
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

            return admin.Insert_Cajero(Obj);
        }

        public static DataTable Get_Cajero()
        {
            D_Cajero admin = new D_Cajero();
            return admin.Get_Cajero();
        }

        public static string Update_Cajero(string clave, string nombre,string curp,
              string fecha_nacimiento, string nomina, string correo, string contra)
        {
            D_Cajero admin = new D_Cajero();
            Cajero Obj = new Cajero();
            Obj.clave = clave;
            Obj.nombre = nombre;
            Obj.curp = curp;
            Obj.fecha_nacimiento = fecha_nacimiento;
            Obj.nomina = nomina;
            Obj.correo = correo;
            Obj.contra = contra;


            return admin.Update_Cajero(Obj);
        }

        public static DataTable Get_ModCajero()
        {
            D_Cajero admin = new D_Cajero();
            return admin.Get_ModCajero();
        }
    }
}
