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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "AddProducto_Insertar";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Cod = new SqlParameter();
                Cod.ParameterName = "@Codigo";
                Cod.SqlDbType = SqlDbType.Int;
                Cod.Value = Prod.Codigo;
                cmd.Parameters.Add(Cod);

                SqlParameter Desc = new SqlParameter();
                Desc.ParameterName = "@Descripcion";
                Desc.SqlDbType = SqlDbType.VarChar;
                Desc.Size = 1000;
                Desc.Value = Prod.Descripcion;
                cmd.Parameters.Add(Desc);

                SqlParameter TipoID = new SqlParameter();
                TipoID.ParameterName = "@TipoID";
                TipoID.SqlDbType = SqlDbType.Int;
                TipoID.Value = Prod.Tipo.Id;
                cmd.Parameters.Add(TipoID);

                SqlParameter ColDesc = new SqlParameter();
                ColDesc.ParameterName = "@ColorDescripcion";
                ColDesc.SqlDbType = SqlDbType.VarChar;
                ColDesc.Size = 200;
                ColDesc.Value = Prod.Color.Descripcion;
                cmd.Parameters.Add(ColDesc);

                SqlParameter TalleID = new SqlParameter();
                TalleID.ParameterName = "@TalleID";
                TalleID.SqlDbType = SqlDbType.Int;
                TalleID.Value=Prod.

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
