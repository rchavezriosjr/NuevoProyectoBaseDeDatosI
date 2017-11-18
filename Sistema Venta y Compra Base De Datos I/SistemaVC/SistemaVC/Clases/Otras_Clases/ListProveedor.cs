
using SistemaVC.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace SistemaVC
{
    public partial class ListProveedor
    {
        public static DataSet GetProveedor()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("ListProveedores_Get", dbParams);
        }

        public static DataSet DeleteProveedor(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, proveedor.P_Id),
				};
            return DBHelper.ExecuteDataSet("ListProveedores_Delete", dbParams);
        }
    }
}