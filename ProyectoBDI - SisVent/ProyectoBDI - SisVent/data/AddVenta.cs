using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class AddVenta
    {
        public void Insertar(Venta vta)
        {
            //SqlConnection Con = new SqlConnection();
            //try
            //{
            //    Con.ConnectionString = Conexión.Cn;
            //    Con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Con;
            //    cmd.CommandText = "AddVenta_Insertar";
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter FVta = new SqlParameter();
            //    FVta.ParameterName = "@FechaVenta";
            //    FVta.SqlDbType = SqlDbType.DateTime;
            //    FVta.Value = vta.FechaVenta;
            //    cmd.Parameters.Add(FVta);

            //    SqlParameter CId = new SqlParameter();
            //    CId.ParameterName = "@ClienteId";
            //    CId.SqlDbType = SqlDbType.Int;
            //    CId.Value = vta.Cliente.C_Id;
            //    cmd.Parameters.Add(CId);

            //    SqlParameter MTot = new SqlParameter();
            //    MTot.ParameterName = "@MontoTotal";
            //    MTot.SqlDbType = SqlDbType.Decimal;
            //    MTot.Value = vta.MontoTotal;
            //    cmd.Parameters.Add(MTot);

            //    SqlParameter UID = new SqlParameter();
            //    UID.ParameterName = "@UserId";
            //    UID.SqlDbType = SqlDbType.Int;
            //    UID.Value = vta.UserId;
            //    cmd.Parameters.Add(UID);

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
    }
}