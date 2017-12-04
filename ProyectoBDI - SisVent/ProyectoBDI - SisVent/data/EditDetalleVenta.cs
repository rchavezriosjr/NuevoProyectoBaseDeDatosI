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
        public void InsertarDetalle(DetalleVenta dv)//, SqlTransaction trx)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                //cmd.Transaction = trx;
                cmd.CommandText = "Insertar_Detalle_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter vtaID = new SqlParameter();
                vtaID.ParameterName = "@VentaID";
                vtaID.SqlDbType = SqlDbType.VarChar;
                vtaID.Size = 15;
                vtaID.Value = dv.VentaID;
                cmd.Parameters.Add(vtaID);

                SqlParameter PorductoID = new SqlParameter();
                PorductoID.ParameterName = "@ProductoID";
                PorductoID.SqlDbType = SqlDbType.Int;
                PorductoID.Value = dv.ProductoID;
                cmd.Parameters.Add(PorductoID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = dv.Cantidad;
                cmd.Parameters.Add(Cant);

                SqlParameter UnitPrice = new SqlParameter();
                UnitPrice.ParameterName = "@PrecioUnitario";
                UnitPrice.SqlDbType = SqlDbType.Decimal;
                UnitPrice.Value = dv.PrecioUnitario;
                cmd.Parameters.Add(UnitPrice);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descuento";
                Desc.SqlDbType = SqlDbType.Decimal;
                Desc.Value = dv.Descuento;
                cmd.Parameters.Add(Desc);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = dv.Impuesto;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = dv.Total;
                cmd.Parameters.Add(Tot);

                cmd.ExecuteScalar();

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

        public void ActualizarDetalle(DetalleVenta dv)//, SqlTransaction trx)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                //cmd.Transaction = trx;
                cmd.CommandText = "Actualizar_Detalle_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter vtaID = new SqlParameter();
                vtaID.ParameterName = "@VentaID";
                vtaID.SqlDbType = SqlDbType.VarChar;
                vtaID.Size = 15;
                vtaID.Value = dv.VentaID;
                cmd.Parameters.Add(vtaID);

                SqlParameter PorductoID = new SqlParameter();
                PorductoID.ParameterName = "@ProductoID";
                PorductoID.SqlDbType = SqlDbType.Int;
                PorductoID.Value = dv.ProductoID;
                cmd.Parameters.Add(PorductoID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = dv.Cantidad;
                cmd.Parameters.Add(Cant);

                SqlParameter UnitPrice = new SqlParameter();
                UnitPrice.ParameterName = "@PrecioUnitario";
                UnitPrice.SqlDbType = SqlDbType.Decimal;
                UnitPrice.Value = dv.PrecioUnitario;
                cmd.Parameters.Add(UnitPrice);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descuento";
                Desc.SqlDbType = SqlDbType.Decimal;
                Desc.Value = dv.Descuento;
                cmd.Parameters.Add(Desc);

                SqlParameter Tax = new SqlParameter();
                Tax.ParameterName = "@Impuesto";
                Tax.SqlDbType = SqlDbType.Decimal;
                Tax.Value = dv.Impuesto;
                cmd.Parameters.Add(Tax);

                SqlParameter Tot = new SqlParameter();
                Tot.ParameterName = "@Total";
                Tot.SqlDbType = SqlDbType.Decimal;
                Tot.Value = dv.Total;
                cmd.Parameters.Add(Tot);

                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible Actualizar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public void DeleteProdDetalleVenta(DetalleVenta dv)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Remover_Producto_Detalle_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter vtaID = new SqlParameter();
                vtaID.ParameterName = "@VentaID";
                vtaID.SqlDbType = SqlDbType.VarChar;
                vtaID.Size = 15;
                vtaID.Value = dv.VentaID;
                cmd.Parameters.Add(vtaID);

                SqlParameter PorductoID = new SqlParameter();
                PorductoID.ParameterName = "@ProductoID";
                PorductoID.SqlDbType = SqlDbType.Int;
                PorductoID.Value = dv.ProductoID;
                cmd.Parameters.Add(PorductoID);

                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible eliminar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
    }
}