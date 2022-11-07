using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class D_Cajero
    {


        public DataTable Get_Cajero()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Get_Cajero", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Login_Cajeros(string Correo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Login_Cajeros", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Correo;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

            public string Insert_Cajero(Cajero Obj)
           {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Insert_Cajero", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.clave;
                Comando.Parameters.Add("@registered_by", SqlDbType.VarChar).Value = Obj.registered_by;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@curp", SqlDbType.VarChar).Value = Obj.curp;
                Comando.Parameters.Add("@fecha_nacimiento", SqlDbType.VarChar).Value = Obj.fecha_nacimiento;
                Comando.Parameters.Add("@nomina", SqlDbType.VarChar).Value = Obj.nomina;
                Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Obj.correo;
                Comando.Parameters.Add("@contra", SqlDbType.VarChar).Value = Obj.contra;

                SqlCon.Open();
                //Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return Rpta;
            }

        public string Update_Cajero(Cajero Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Update_Cajero", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.clave;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@curp", SqlDbType.VarChar).Value = Obj.curp;
                Comando.Parameters.Add("@fecha_nacimiento", SqlDbType.VarChar).Value = Obj.fecha_nacimiento;
                Comando.Parameters.Add("@nomina", SqlDbType.VarChar).Value = Obj.nomina;
                Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Obj.correo;
                Comando.Parameters.Add("@contra", SqlDbType.VarChar).Value = Obj.contra;
                SqlCon.Open();
                //Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }


            return Rpta;
        }


        public DataTable Get_ModCajero()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Get_ModCajero", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public string Eliminar_Cajero(string clave)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Eliminar_Cajero", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                SqlCon.Open();
                //Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro :c";
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }


    }
}
