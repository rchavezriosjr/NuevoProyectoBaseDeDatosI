using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditCompra
    {
        public void Insertar(Compra comp)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "EditCompra_Insertar";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DESC = new SqlParameter();
                DESC.ParameterName = "@Descripcion";
                DESC.SqlDbType = SqlDbType.VarChar;
                DESC.Size = 200;
                DESC.Value = comp.Descripcion;
                cmd.Parameters.Add(DESC);

                SqlParameter FComp = new SqlParameter();
                FComp.ParameterName = "@FechaCompra";
                FComp.SqlDbType = SqlDbType.Date;
                FComp.Value = comp.FechaCompra;
                cmd.Parameters.Add(FComp);

                SqlParameter Prov = new SqlParameter();
                Prov.ParameterName = "@Proveedor";
                Prov.SqlDbType = SqlDbType.VarChar;
                Prov.Size = 200;
                Prov.Value = comp.Proveedor;
                cmd.Parameters.Add(DESC);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
