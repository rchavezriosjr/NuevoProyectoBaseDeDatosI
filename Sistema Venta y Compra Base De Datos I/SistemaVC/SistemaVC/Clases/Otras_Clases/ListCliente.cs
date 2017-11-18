
using SistemaVC.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace SistemaVC
{
    public partial class ListCliente
    {
        public static DataSet GetClientes()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("ListCliente_Get", dbParams);
        }

        public static DataSet DeleteCliente(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.C_Id),
				};
            return DBHelper.ExecuteDataSet("ListCliente_Delete", dbParams);
        }
    }
}