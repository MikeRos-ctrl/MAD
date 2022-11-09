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
    public class N_Administrador
    {
        public static DataTable Get_Administradores(string clave)
        {
            D_Administrador admin = new D_Administrador();
            return admin.Get_Administradores(clave);
        }

        public static DataTable Login_Administador(string correo)
        {
            D_Administrador Datos = new D_Administrador();
            return Datos.Login_Administador(correo);
        }

    }
}
