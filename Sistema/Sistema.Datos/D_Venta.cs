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
    public class D_Venta
    {
       
    
        public DataTable sp_Busqueda_Ventas(string Codigo)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Busqueda_Ventas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Parametro", SqlDbType.VarChar).Value = Codigo;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
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

            public DataTable sp_Carrito_Vali(string Codigo)
            {
                    SqlDataReader Resultado;
                    DataTable Tabla = new DataTable();
                    SqlConnection SqlCon = new SqlConnection();
                    try
                    {
                        SqlCon = Connection.Get_Instancia().CrearConexion();
                        SqlCommand Comando = new SqlCommand("sp_Carrito_Vali", SqlCon);
                        Comando.CommandType = CommandType.StoredProcedure;
                        Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Codigo;
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

 

        public DataTable sp_Get_Vcarrito()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Vcarrito", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Table.Columns.Add("Codigo", typeof(string));
                Table.Columns.Add("Producto", typeof(string));
                Table.Columns.Add("Departamento", typeof(string));
                Table.Columns.Add("Cantidad", typeof(string));
                Table.Columns.Add("Precio Unitario", typeof(string));
                Table.Columns.Add("Subtotal", typeof(string));
                Table.Columns.Add("Descuento del producto", typeof(string));
                Table.Columns.Add("Total a pagar", typeof(Int32));
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

        public DataTable sp_Get_Ventas()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Ventas", SqlCon);
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


        public string sp_vender(Venta Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_vender", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_v", SqlDbType.Int).Value = Obj.Id_v;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.codigo;
                Comando.Parameters.Add("@nombreP", SqlDbType.VarChar).Value = Obj.nombreP;
                Comando.Parameters.Add("@Cantidad", SqlDbType.Float).Value = Obj.Cantidad;
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
