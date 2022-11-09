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
    public class N_Departamento
    {

      

        public static DataTable sp_Get_Departamentos()
        {
            D_Departamento admin = new D_Departamento();
            return admin.sp_Get_Departamentos();
        }


        public static string sp_GestionarDepartamentosInserto(string registered_by, string nombre, string Op)
        {
            D_Departamento admin = new D_Departamento();
            Departamento Obj = new Departamento();
            Obj.registered_by = registered_by;
            Obj.nombre = nombre;
            Obj.Op = Op;

            return admin.sp_GestionarDepartamentos(Obj);
        }

        public static string sp_GestionarDepartamentos(string id, string registered_by, string nombre, string Op)
        {
            D_Departamento admin = new D_Departamento();
            Departamento Obj = new Departamento();
            Obj.id = id;
            Obj.registered_by = registered_by;
            Obj.nombre = nombre;
            Obj.Op = Op;

            return admin.sp_GestionarDepartamentos(Obj);
        }

    }
}
