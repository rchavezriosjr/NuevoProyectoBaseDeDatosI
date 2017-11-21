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
        public DataTable GetProveedores()
        {
            DataTable dt = new DataTable("Proveedores");
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListProveedores_Get";
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
        public DataTable DeleteProveedor(int id)
        {
            DataTable dt = new DataTable("ProveedorAct");
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListProveedores_Delete";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IDPROVEEDOR = new SqlParameter();
                IDPROVEEDOR.ParameterName = "@Id";
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
