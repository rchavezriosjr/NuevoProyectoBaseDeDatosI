using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditCompra
    {
        public void InsertarCompra(Compra comp)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DESC = new SqlParameter();
                DESC.ParameterName = "@ID";
                DESC.SqlDbType = SqlDbType.VarChar;
                DESC.Size = 15;
                DESC.Value = comp.ID;
                cmd.Parameters.Add(DESC);

                SqlParameter Prov = new SqlParameter();
                Prov.ParameterName = "@ProveedorID";
                Prov.SqlDbType = SqlDbType.Int;
                Prov.Value = comp.ProveedorID;
                cmd.Parameters.Add(Prov);

                SqlParameter FComp = new SqlParameter();
                FComp.ParameterName = "@FechaCompra";
                FComp.SqlDbType = SqlDbType.Date;
                FComp.Value = comp.FechaCompra;
                cmd.Parameters.Add(FComp);

                SqlParameter TipoPago = new SqlParameter();
                TipoPago.ParameterName = "@TipoPago";
                TipoPago.SqlDbType = SqlDbType.Int;
                TipoPago.Value = comp.TipoPago;
                cmd.Parameters.Add(TipoPago);

                SqlParameter Mont = new SqlParameter();
                Mont.ParameterName = "@Monto";
                Mont.SqlDbType = SqlDbType.Decimal;
                Mont.Value = comp.Monto;
                cmd.Parameters.Add(Mont);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible insertar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        public void ActualizarCompra(Compra comp)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DESC = new SqlParameter();
                DESC.ParameterName = "@ID";
                DESC.SqlDbType = SqlDbType.VarChar;
                DESC.Size = 15;
                DESC.Value = comp.ID;
                cmd.Parameters.Add(DESC);

                SqlParameter Prov = new SqlParameter();
                Prov.ParameterName = "@ProveedorID";
                Prov.SqlDbType = SqlDbType.Int;
                Prov.Value = comp.ProveedorID;
                cmd.Parameters.Add(Prov);

                SqlParameter FComp = new SqlParameter();
                FComp.ParameterName = "@FechaCompra";
                FComp.SqlDbType = SqlDbType.Date;
                FComp.Value = comp.FechaCompra;
                cmd.Parameters.Add(FComp);

                SqlParameter TipoPago = new SqlParameter();
                TipoPago.ParameterName = "@TipoPago";
                TipoPago.SqlDbType = SqlDbType.Int;
                TipoPago.Value = comp.TipoPago;
                cmd.Parameters.Add(TipoPago);

                SqlParameter Mont = new SqlParameter();
                Mont.ParameterName = "@Monto";
                Mont.SqlDbType = SqlDbType.Decimal;
                Mont.Value = comp.Monto;
                cmd.Parameters.Add(Mont);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible actualizar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public DataSet GetCompra(string valor, int clave)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Compras";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Valor = new SqlParameter();
                Valor.ParameterName = "@valor";
                Valor.SqlDbType = SqlDbType.VarChar;
                Valor.Size = 100;
                Valor.Value = valor;
                cmd.Parameters.Add(Valor);

                SqlParameter Clave = new SqlParameter();
                Clave.ParameterName = "@clave";
                Clave.SqlDbType = SqlDbType.Int;
                Clave.Value = clave;
                cmd.Parameters.Add(Clave);

                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
                dt = null;
            }
            return dt;
        }
    }
}
