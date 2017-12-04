using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditProducto
    {
        public void ActualizarProducto(Producto Prod)
        {
            //SqlConnection Con = new SqlConnection();
            //try
            //{
            //    Con.ConnectionString = Conexión.Cn;
            //    Con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Con;
            //    cmd.CommandText = "EditProducto_Actualizar";
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter ID = new SqlParameter();
            //    ID.ParameterName = "@Id";
            //    ID.SqlDbType = SqlDbType.Int;
            //    ID.Value = Prod.Id;
            //    cmd.Parameters.Add(ID);

            //    SqlParameter Cod = new SqlParameter();
            //    Cod.ParameterName = "@Codigo";
            //    Cod.SqlDbType = SqlDbType.Int;
            //    Cod.Value = Prod.Codigo;
            //    cmd.Parameters.Add(Cod);

            //    SqlParameter Desc = new SqlParameter();
            //    Desc.ParameterName = "@Nombre";
            //    Desc.SqlDbType = SqlDbType.VarChar;
            //    Desc.Size = 1000;
            //    Desc.Value = Prod.Descripcion;
            //    cmd.Parameters.Add(Desc);

            //    SqlParameter TipoID = new SqlParameter();
            //    TipoID.ParameterName = "@TipoID";
            //    TipoID.SqlDbType = SqlDbType.Int;
            //    TipoID.Value = Prod.Tipo.Id;
            //    cmd.Parameters.Add(TipoID);

            //    SqlParameter ColDesc = new SqlParameter();
            //    ColDesc.ParameterName = "@ColorDescripcion";
            //    ColDesc.SqlDbType = SqlDbType.VarChar;
            //    ColDesc.Size = 200;
            //    ColDesc.Value = Prod.Color.Descripcion;
            //    cmd.Parameters.Add(ColDesc);

            //    SqlParameter TalleID = new SqlParameter();
            //    TalleID.ParameterName = "@TalleID";
            //    TalleID.SqlDbType = SqlDbType.Int;
            //    TalleID.Value = Prod.Talle.Id;
            //    cmd.Parameters.Add(TalleID);

            //    SqlParameter PrecioCst = new SqlParameter();
            //    PrecioCst.ParameterName = "@PrecioCosto";
            //    PrecioCst.SqlDbType = SqlDbType.Decimal;
            //    PrecioCst.Value = Prod.PrecioCosto;
            //    cmd.Parameters.Add(PrecioCst);

            //    SqlParameter PorcGananc = new SqlParameter();
            //    PorcGananc.ParameterName = "@PorcGanancia";
            //    PrecioCst.SqlDbType = SqlDbType.Decimal;
            //    PrecioCst.Value = Prod.PrecioCosto;
            //    cmd.Parameters.Add(PrecioCst);

            //    SqlParameter PVta = new SqlParameter();
            //    PVta.ParameterName = "@PrecioVenta";
            //    PVta.SqlDbType = SqlDbType.Decimal;
            //    PVta.Value = Prod.PrecioVenta;
            //    cmd.Parameters.Add(PVta);

            //    SqlParameter IStock = new SqlParameter();
            //    IStock.ParameterName = "@StockInicial";
            //    IStock.SqlDbType = SqlDbType.Decimal;
            //    IStock.Value = Prod.StockInicial;
            //    cmd.Parameters.Add(IStock);

            //    SqlParameter AStock = new SqlParameter();
            //    AStock.ParameterName = "@StockActual";
            //    AStock.SqlDbType = SqlDbType.Decimal;
            //    AStock.Value = Prod.StockActual;
            //    cmd.Parameters.Add(AStock);

            //    SqlParameter Descu = new SqlParameter();
            //    Descu.ParameterName = "@PorcDescuento";
            //    Descu.SqlDbType = SqlDbType.Decimal;
            //    Descu.Value = Prod.PorcDescuento;
            //    cmd.Parameters.Add(Descu);

            //    SqlParameter CompID = new SqlParameter();
            //    CompID.ParameterName = "@CompraID";
            //    CompID.SqlDbType = SqlDbType.Int;
            //    CompID.Value = Prod.Compra.Id;
            //    cmd.Parameters.Add(CompID);

            //    cmd.ExecuteNonQuery();

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
        public DataSet GetProducto(Producto prod)
        {
            DataSet dt = new DataSet();
            //SqlConnection Con = new SqlConnection();
            //try
            //{
            //    Con.ConnectionString = Conexión.Cn;
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Con;
            //    cmd.CommandText = "EditProducto_GetProducto";
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter ID = new SqlParameter();
            //    ID.ParameterName = "@Id";
            //    ID.SqlDbType = SqlDbType.Int;
            //    ID.Value = prod.Id;
            //    cmd.Parameters.Add(ID);

            //    SqlDataAdapter Data = new SqlDataAdapter(cmd);
            //    Data.Fill(dt);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
            //    dt = null;
            //}
            return dt;
        }
    }
}
