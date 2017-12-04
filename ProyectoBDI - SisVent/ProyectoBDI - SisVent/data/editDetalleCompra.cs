using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class editDetalleCompra
    {
        public void InsertarDetail (DetalleCompra det)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Detalle_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCmp = new SqlParameter();
                IdCmp.ParameterName = "@CompraID";
                IdCmp.SqlDbType = SqlDbType.VarChar;
                IdCmp.Size = 15;
                IdCmp.Value = det.CompraID;
                cmd.Parameters.Add(IdCmp);

                SqlParameter ProdID = new SqlParameter();
                ProdID.ParameterName = "@ProductoID";
                ProdID.SqlDbType = SqlDbType.Int;
                ProdID.Value = det.ProdID;
                cmd.Parameters.Add(ProdID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = det.Cant;
                cmd.Parameters.Add(Cant);

                SqlParameter cst = new SqlParameter();
                cst.ParameterName = "@CostoUnitario";
                cst.SqlDbType = SqlDbType.Decimal;
                cst.Value = det.UnitPrice;
                cmd.Parameters.Add(cst);

                SqlParameter Total = new SqlParameter();
                Total.ParameterName = "@Total";
                Total.SqlDbType = SqlDbType.Decimal;
                Total.Value = det.Total;
                cmd.Parameters.Add(Total);
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
        public void UpdateDetail(DetalleCompra det)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Detalle_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IdCmp = new SqlParameter();
                IdCmp.ParameterName = "@CompraID";
                IdCmp.SqlDbType = SqlDbType.VarChar;
                IdCmp.Size = 15;
                IdCmp.Value = det.CompraID;
                cmd.Parameters.Add(IdCmp);

                SqlParameter ProdID = new SqlParameter();
                ProdID.ParameterName = "@ProductoID";
                ProdID.SqlDbType = SqlDbType.Int;
                ProdID.Value = det.ProdID;
                cmd.Parameters.Add(ProdID);

                SqlParameter Cant = new SqlParameter();
                Cant.ParameterName = "@Cantidad";
                Cant.SqlDbType = SqlDbType.Int;
                Cant.Value = det.Cant;
                cmd.Parameters.Add(Cant);

                SqlParameter cst = new SqlParameter();
                cst.ParameterName = "@CostoUnitario";
                cst.SqlDbType = SqlDbType.Decimal;
                cst.Value = det.UnitPrice;
                cmd.Parameters.Add(cst);

                SqlParameter Total = new SqlParameter();
                Total.ParameterName = "@Total";
                Total.SqlDbType = SqlDbType.Decimal;
                Total.Value = det.Total;
                cmd.Parameters.Add(Total);
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

        public DataSet GetComprasDetalle()
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Select * from Detalle_Compra";
                cmd.CommandType = CommandType.Text;

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

        public void DeleteProdDetalleCompra(DetalleCompra dv)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Remover_Producto_Detalle_Compra";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter vtaID = new SqlParameter();
                vtaID.ParameterName = "@CompraID";
                vtaID.SqlDbType = SqlDbType.VarChar;
                vtaID.Size = 15;
                vtaID.Value = dv.CompraID;
                cmd.Parameters.Add(vtaID);

                SqlParameter PorductoID = new SqlParameter();
                PorductoID.ParameterName = "@ProductoID";
                PorductoID.SqlDbType = SqlDbType.Int;
                PorductoID.Value = dv.ProdID;
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
