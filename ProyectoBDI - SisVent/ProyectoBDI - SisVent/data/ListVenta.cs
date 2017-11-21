using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class ListVenta
    {
        public int IdVta
        { get; set; }
        public ListVenta()
        { }

        public ListVenta(int idvta)
        {
            this.IdVta = idvta;
        }
        public DataTable GetVtas()
        {
            DataTable dt = new DataTable("Ventas");
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListVenta_GetVentas";
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
        public void DeleteVenta(int id)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListVenta_DeleteVenta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter IDVENTA = new SqlParameter();
                IDVENTA.ParameterName = "@VentaId";
                IDVENTA.SqlDbType = SqlDbType.Decimal;
                IDVENTA.Value = id;
                cmd.Parameters.Add(IDVENTA);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
            }
        }
    }
}
 