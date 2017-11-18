using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using SistemaVC.Classes;

namespace SistemaVC
{
    public partial class ListCompra
    {
        public static DataSet GetCompras()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("ListCompra_GetCompras", dbParams);
        }

        public static DataSet DeleteCompra(Compra compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, compra.Id),
				};
            return DBHelper.ExecuteDataSet("ListCompra_DeleteCompra", dbParams);
        }
    }
}