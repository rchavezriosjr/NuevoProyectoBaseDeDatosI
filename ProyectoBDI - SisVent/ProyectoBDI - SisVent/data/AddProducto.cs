using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class AddProducto
    {
        public void Insertar(Producto Prod)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Producto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Cat = new SqlParameter();
                Cat.ParameterName = "@Categoria";
                Cat.SqlDbType = SqlDbType.Int;
                Cat.Value = Prod.CategoriaID;
                cmd.Parameters.Add(Cat);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 200;
                Name.Value = Prod.Descripcion;
                cmd.Parameters.Add(Name);

                SqlParameter PVta = new SqlParameter();
                PVta.ParameterName = "@PrecioVenta";
                PVta.SqlDbType = SqlDbType.Decimal;
                PVta.Value = Prod.PrecioVenta;
                cmd.Parameters.Add(PVta);

                SqlParameter Stock = new SqlParameter();
                Stock.ParameterName = "@Stock";
                Stock.SqlDbType = SqlDbType.Decimal;
                Stock.Value = Prod.Stock;
                cmd.Parameters.Add(Stock);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descripcion";
                Desc.SqlDbType = SqlDbType.VarChar;
                Desc.Size = 250;
                Desc.Value = Prod.Descripcion;
                cmd.Parameters.Add(Desc);

                SqlParameter Estadox = new SqlParameter();
                Estadox.ParameterName = "@Estado";
                Estadox.SqlDbType = SqlDbType.Int;
                Estadox.Value = Prod.Estado;
                cmd.Parameters.Add(Estadox);

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

        public void Actualizar(Producto Prod)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Producto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@ID";
                id.SqlDbType = SqlDbType.Int;
                id.Value = Prod.CategoriaID;
                cmd.Parameters.Add(id);

                SqlParameter Cat = new SqlParameter();
                Cat.ParameterName = "@Categoria";
                Cat.SqlDbType = SqlDbType.Int;
                Cat.Value = Prod.CategoriaID;
                cmd.Parameters.Add(Cat);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 200;
                Name.Value = Prod.Descripcion;
                cmd.Parameters.Add(Name);

                SqlParameter PVta = new SqlParameter();
                PVta.ParameterName = "@PrecioVenta";
                PVta.SqlDbType = SqlDbType.Decimal;
                PVta.Value = Prod.PrecioVenta;
                cmd.Parameters.Add(PVta);

                SqlParameter Stock = new SqlParameter();
                Stock.ParameterName = "@Stock";
                Stock.SqlDbType = SqlDbType.Decimal;
                Stock.Value = Prod.Stock;
                cmd.Parameters.Add(Stock);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descripcion";
                Desc.SqlDbType = SqlDbType.VarChar;
                Desc.Size = 250;
                Desc.Value = Prod.Descripcion;
                cmd.Parameters.Add(Desc);

                SqlParameter Estadox = new SqlParameter();
                Estadox.ParameterName = "@Estado";
                Estadox.SqlDbType = SqlDbType.Int;
                Estadox.Value = Prod.Estado;
                cmd.Parameters.Add(Estadox);

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
    }
}