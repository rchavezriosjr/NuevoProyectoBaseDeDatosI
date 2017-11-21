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
        public DataTable GetProductos()
        {
            DataTable dt = new DataTable("Productos");
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListProducto_GetProductos";
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
        public DataTable DeleteProducto(int id)
        {
            DataTable dt = new DataTable("ProductoAct");
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListProducto_DeleteProducto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IDProducto = new SqlParameter();
                IDProducto.ParameterName = "@Id";
                IDProducto.SqlDbType = SqlDbType.Int;
                IDProducto.Value = id;
                cmd.Parameters.Add(IDProducto);

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
