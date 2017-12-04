using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class AddVenta
    {
        public void InsertarVenta(Venta vta)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 15;
                ID.Value = vta.Id;
                cmd.Parameters.Add(ID);

                SqlParameter Client = new SqlParameter();
                Client.ParameterName = "@ClienteID";
                Client.SqlDbType = SqlDbType.Int;
                Client.Value = vta.ClientId;
                cmd.Parameters.Add(Client);

                SqlParameter UserID = new SqlParameter();
                UserID.ParameterName = "@UsuarioID";
                UserID.SqlDbType = SqlDbType.VarChar;
                UserID.Size = 10;
                UserID.Value = vta.UserId;
                cmd.Parameters.Add(UserID);

                SqlParameter FechaVta = new SqlParameter();
                FechaVta.ParameterName = "@FechaVenta";
                FechaVta.SqlDbType = SqlDbType.Date;
                FechaVta.Value = vta.FechaVenta;
                cmd.Parameters.Add(FechaVta);

                SqlParameter PagoTipo = new SqlParameter();
                PagoTipo.ParameterName = "@TipoPago";
                PagoTipo.SqlDbType = SqlDbType.Int;
                PagoTipo.Value = vta.TipoPago;
                cmd.Parameters.Add(PagoTipo);

                SqlParameter TipoVenta = new SqlParameter();
                TipoVenta.ParameterName = "@TipoVenta";
                TipoVenta.SqlDbType = SqlDbType.Int;
                TipoVenta.Value = vta.TipoVenta;
                cmd.Parameters.Add(TipoVenta);

                SqlParameter Sub = new SqlParameter();
                Sub.ParameterName = "@SubTotal";
                Sub.SqlDbType = SqlDbType.Decimal;
                Sub.Value = vta.SubTotal;
                cmd.Parameters.Add(Sub);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = vta.Tax;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = vta.MontoTotal;
                cmd.Parameters.Add(Tot);

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
        public void ActualizarVenta(Venta vta)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 15;
                ID.Value = vta.Id;
                cmd.Parameters.Add(ID);

                SqlParameter Client = new SqlParameter();
                Client.ParameterName = "@ClienteID";
                Client.SqlDbType = SqlDbType.Int;
                Client.Value = vta.ClientId;
                cmd.Parameters.Add(Client);

                SqlParameter UserID = new SqlParameter();
                UserID.ParameterName = "@UsuarioID";
                UserID.SqlDbType = SqlDbType.VarChar;
                UserID.Size = 10;
                UserID.Value = vta.UserId;
                cmd.Parameters.Add(UserID);

                SqlParameter FechaVta = new SqlParameter();
                FechaVta.ParameterName = "@FechaVenta";
                FechaVta.SqlDbType = SqlDbType.Date;
                FechaVta.Value = vta.FechaVenta;
                cmd.Parameters.Add(FechaVta);

                SqlParameter PagoTipo = new SqlParameter();
                PagoTipo.ParameterName = "@TipoPago";
                PagoTipo.SqlDbType = SqlDbType.Int;
                PagoTipo.Value = vta.TipoPago;
                cmd.Parameters.Add(PagoTipo);

                SqlParameter TipoVenta = new SqlParameter();
                TipoVenta.ParameterName = "@TipoVenta";
                TipoVenta.SqlDbType = SqlDbType.Int;
                TipoVenta.Value = vta.TipoVenta;
                cmd.Parameters.Add(TipoVenta);

                SqlParameter Sub = new SqlParameter();
                Sub.ParameterName = "@SubTotal";
                Sub.SqlDbType = SqlDbType.Decimal;
                Sub.Value = vta.SubTotal;
                cmd.Parameters.Add(Sub);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = vta.Tax;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = vta.MontoTotal;
                cmd.Parameters.Add(Tot);

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

        public DataSet BuscarVenta(string valor, int clave)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Ventas";
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
        public DataSet MostrarVentas()
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Mostar_Ventas";
                cmd.CommandType = CommandType.StoredProcedure;

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