using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class ListProveedor
    {
        public int Id
        { get; set; }
        public ListProveedor()
        { }
        public ListProveedor(int IdProveedor)
        {
            this.Id = IdProveedor;
        }
        public DataSet GetProveedores()
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Mostrar_Proveedores";
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
        public DataSet DeleteProveedor(int id)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Deshabilitar_Proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IDPROVEEDOR = new SqlParameter();
                IDPROVEEDOR.ParameterName = "@ID";
                IDPROVEEDOR.SqlDbType = SqlDbType.Int;
                IDPROVEEDOR.Value = id;
                cmd.Parameters.Add(IDPROVEEDOR);

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
