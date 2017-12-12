using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class ListCompra
    {
        public int Id
        { get; set; }
        public ListCompra()
        {   }
        public ListCompra(int IdCompra)
        {
            this.Id = IdCompra;
        }

        public DataSet GetCompras()
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Mostar_Compras";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta realizada sin exito: "+ex.ToString());
                dt = null;
            }
            return dt;
        }
        


        //public DataSet DeleteCompra(int id)
        //{
        //    DataSet dt = new DataSet();
        //    SqlConnection Con = new SqlConnection();
        //    try
        //    {
        //        Con.ConnectionString = Conexión.Cn;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = Con;
        //        cmd.CommandText = "ListCompra_DeleteCompra";
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter IDCOMPRA = new SqlParameter();
        //        IDCOMPRA.ParameterName = "@Id";
        //        IDCOMPRA.SqlDbType = SqlDbType.Int;
        //        IDCOMPRA.Value = id;
        //        cmd.Parameters.Add(IDCOMPRA);

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
