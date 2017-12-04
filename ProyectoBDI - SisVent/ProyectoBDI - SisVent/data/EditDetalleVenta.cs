using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditDetalleVenta
    {
        public DataSet GetVenta(Venta v)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "EditDetalleVenta_GetVenta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "Venta@Id";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = v.Id;
                cmd.Parameters.Add(ID);

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
        public DataSet GetDetalleVenta(Venta v)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "EditDetalleVenta_GetDetalleVenta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@VentaId";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = v.Id;
                cmd.Parameters.Add(ID);

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

        public void EliminmarDetalleVenta(DetalleVenta dv)
        {
            //SqlConnection Con = new SqlConnection();
            //try
            //{
            //    Con.ConnectionString = Conexión.Cn;

            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Con;
            //    cmd.CommandText = "usp_EditDetalleVenta_EliminarDetalleVenta";
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter Detail = new SqlParameter();
            //    Detail.ParameterName = "@DetalleVentaId";
            //    Detail.SqlDbType = SqlDbType.Int;
            //    Detail.Value = dv.Id;
            //    cmd.Parameters.Add(Detail);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("No se pudo eliminar detalle: " + ex.ToString());
            //}
        }
        public void DismStock(DetalleVenta dv,SqlTransaction trx)
        {
            //SqlConnection Con = new SqlConnection();
            //try
            //{
            //    Con.ConnectionString = Conexión.Cn;

            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Con;
            //    cmd.Transaction = trx;
            //    cmd.CommandText = "AddVenta_DisminuirStock";
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter ProdID = new SqlParameter();
            //    ProdID.ParameterName = "@ProductoId";
            //    ProdID.SqlDbType = SqlDbType.Int;
            //    ProdID.Value = dv.Producto.Id;
            //    cmd.Parameters.Add(ProdID);

            //    SqlParameter Unid = new SqlParameter();
            //    Unid.ParameterName = "@CantidadUnidades";
            //    Unid.SqlDbType = SqlDbType.Int;
            //    Unid.Value = dv.CantidadUnidades;
            //    cmd.Parameters.Add(Unid);

            //    cmd.ExecuteScalar();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("No se pudo  disminuir stocl: " + ex.ToString());
            //}
        }
        public void InsertarDetalle(DetalleVenta dv, SqlTransaction trx)
        {
            //SqlConnection Con = new SqlConnection();
            //try
            //{
            //    Con.ConnectionString = Conexión.Cn;
            //    Con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Con;
            //    cmd.Transaction = trx;
            //    cmd.CommandText = "AddVenta_InsertarDetalle";
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter ProdID = new SqlParameter();
            //    ProdID.ParameterName = "@ProductoId";
            //    ProdID.SqlDbType = SqlDbType.Int;
            //    ProdID.Value = dv.Producto.Id;
            //    cmd.Parameters.Add(ProdID);

            //    SqlParameter Unid = new SqlParameter();
            //    Unid.ParameterName = "@CantidadUnidades";
            //    Unid.SqlDbType = SqlDbType.Int;
            //    Unid.Value = dv.CantidadUnidades;
            //    cmd.Parameters.Add(Unid);

            //    SqlParameter Desc = new SqlParameter();
            //    Desc.ParameterName = "@Descuento";
            //    Desc.SqlDbType = SqlDbType.Decimal;
            //    Desc.Value = dv.PorcDescuento;
            //    cmd.Parameters.Add(Desc);

            //    SqlParameter Costo = new SqlParameter();
            //    Costo.ParameterName = "@PrecioCosto";
            //    Costo.SqlDbType = SqlDbType.Decimal;
            //    Costo.Value = dv.PrecioCosto;
            //    cmd.Parameters.Add(Costo);

            //    SqlParameter Vendido = new SqlParameter();
            //    Vendido.ParameterName = "@PrecioVendido";
            //    Vendido.SqlDbType = SqlDbType.Decimal;
            //    Vendido.Value = dv.PrecioVendido;
            //    cmd.Parameters.Add(Vendido);

            //    SqlParameter VtaId = new SqlParameter();
            //    VtaId.ParameterName = "@VentaId";
            //    VtaId.SqlDbType = SqlDbType.Int;
            //    VtaId.Value = dv.VentaId;
            //    cmd.Parameters.Add(VtaId);


            //    cmd.ExecuteScalar();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("ERROR: Imposible insertar: " + ex.ToString());
            //}
            //finally
            //{
            //    if (Con.State == ConnectionState.Open) Con.Close();
            //}
        }
    }
}