using Sistema.Datos;
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
        public static DataTable Get_Administradores()
        {
            D_Administrador admin = new D_Administrador();
            return admin.Get_Administradores();
        }

        public static DataTable Login_Administrador(string correo)
        {
            D_Administrador Datos = new D_Administrador();
            return Datos.Login_Administador(correo);
        }
    }
}
