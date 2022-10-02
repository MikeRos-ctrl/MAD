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
        public static string Insert_Cajero(string clave, string registered_by,string nombre,string curp,
            string fecha_nacimiento,string fecha_ingreso,string nomina,string correo,string contra)
        {
            D_Cajero admin = new D_Cajero();
            Cajero Obj = new Cajero();
            Obj.clave = clave;
            Obj.registered_by = registered_by;
            Obj.nombre = nombre;
            Obj.curp = curp;
            Obj.fecha_nacimiento = fecha_nacimiento;
            Obj.fecha_ingreso = fecha_ingreso;
            Obj.nomina = nomina;
            Obj.correo = correo;
            Obj.contra = contra;

            return admin.Insert_Cajero(Obj);
        }
    }
}
