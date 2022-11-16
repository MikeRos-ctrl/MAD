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
    public class D_Descuento
    {
        public DataTable sp_Codigo_Vali(string idDescuento)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Codigo_Vali", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDescuento", SqlDbType.VarChar).Value = idDescuento;
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


    

        public DataTable sp_Get_CostoConDescuento()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_CostoConDescuento", SqlCon);
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



        public string sp_GestionarDescuento(Descuento Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_GestionarDescuento", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idDescuento", SqlDbType.Int).Value = Obj.idDescuento;
                Comando.Parameters.Add("@descuento_", SqlDbType.Float).Value = Obj.descuento_;
                Comando.Parameters.Add("@IdCodigo", SqlDbType.VarChar).Value = Obj.IdCodigo;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = Obj.fecha;
                Comando.Parameters.Add("@fechaAux", SqlDbType.Date).Value = Obj.fechaAux;
                Comando.Parameters.Add("@Op", SqlDbType.Char).Value = Obj.Op;
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

    }
}
