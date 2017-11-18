using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaVC.Classes;

namespace SistemaVC
{
    public partial class EditCliente
    {
        public static int InsertarCliente(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.C_Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0,cliente.C_Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0,cliente.C_Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0,cliente.C_Email)

				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("Insertar_Cliente", dbParams));
        }
            public static int Actualizar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.C_Id),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.C_Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0,cliente.C_Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0,cliente.C_Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0,cliente.C_Email)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("Actualizar_Cliente", dbParams));
        }

        public static DataSet GetCliente(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.C_Id),
				};
            return DBHelper.ExecuteDataSet("Cliente_Get_edit", dbParams);
        }
        
    }
}