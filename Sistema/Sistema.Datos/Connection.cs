using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class Connection
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Connection Con = null;
    
        private Connection()
        {
            this.Base = "PruebaUwu";
            this.Servidor = "LAPTOP-GIBBNP5S";
            this.Usuario = "Mike_Ros";
            this.Clave = "Lethergo1";
            this.Seguridad = true;
        }

        public static Connection Get_Instancia()
        {
            if(Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }

                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }

            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
    }
}
