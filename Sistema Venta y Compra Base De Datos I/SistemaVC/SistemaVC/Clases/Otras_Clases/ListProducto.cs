using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaVC.Clases;
using SistemaVC.Classes;

namespace SistemaVC
{
    public partial class ListProducto
    {
        public static DataSet GetProductos()
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
				};
            return DBHelper.ExecuteDataSet("ListProducto_GetProductos", dbParams);
        }

        public static DataSet DeleteProducto(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, producto.Id),
				};
            return DBHelper.ExecuteDataSet("ListProducto_DeleteProducto", dbParams);
        }
    }
}