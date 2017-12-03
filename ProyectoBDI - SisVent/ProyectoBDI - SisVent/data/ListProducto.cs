using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class ListProducto
    {
        public int Id
        { get; set; }
        public ListProducto()
        { }
        public ListProducto(int IdProducto)
        {
            this.Id = IdProducto;
        }
        public DataSet GetProductos()
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Mostar_Productos";
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

        public DataSet SearchProduct(string valor, int clave)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Buscar_Productos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@valor";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 100;
                ID.Value = valor;
                cmd.Parameters.Add(ID);

                SqlParameter Key = new SqlParameter();
                Key.ParameterName = "@clave";
                Key.SqlDbType = SqlDbType.Int;
                Key.Value = clave;
                cmd.Parameters.Add(Key);

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

        public DataSet SearchUnavaliableProduct(string valor, int estado)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Productos_Deshabilitados";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@valor";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 100;
                ID.Value = valor;
                cmd.Parameters.Add(ID);

                SqlParameter Key = new SqlParameter();
                Key.ParameterName = "@estado";
                Key.SqlDbType = SqlDbType.Int;
                Key.Value = estado;
                cmd.Parameters.Add(Key);

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


        //public DataSet DeleteProducto(int id)
        //{
        //    DataSet dt = new DataSet();
        //    SqlConnection Con = new SqlConnection();
        //    try
        //    {
        //        Con.ConnectionString = Conexión.Cn;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = Con;
        //        cmd.CommandText = "ListProducto_DeleteProducto";
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter IDProducto = new SqlParameter();
        //        IDProducto.ParameterName = "@Id";
        //        IDProducto.SqlDbType = SqlDbType.Int;
        //        IDProducto.Value = id;
        //        cmd.Parameters.Add(IDProducto);

        //        SqlDataAdapter Data = new SqlDataAdapter(cmd);
        //        Data.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
        //        dt = null;
        //    }
        //    return dt;
        //}
    }
}
