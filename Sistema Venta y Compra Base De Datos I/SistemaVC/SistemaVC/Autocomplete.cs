using SistemaVC.Classes;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace SistemaVC
{
    public partial class Autocomplete
    {
        public static DataSet GetProveedores(string sQuery)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Query", SqlDbType.VarChar, 0, sQuery),
				};
            return DBHelper.ExecuteDataSet("Autocomplete_GetProveedores", dbParams);
        }

        public static DataSet GetClientes(string sQuery)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Query", SqlDbType.VarChar, 0, sQuery),
				};
            return DBHelper.ExecuteDataSet("Autocomplete_GetClientes", dbParams);
        }

        public static DataSet GetCompras(string sQuery)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Query", SqlDbType.VarChar, 0, sQuery),
				};
            return DBHelper.ExecuteDataSet("Autocomplete_GetCompras", dbParams);
        }

        public static DataSet GetColores(string sQuery)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Query", SqlDbType.VarChar, 0, sQuery),
				};
            return DBHelper.ExecuteDataSet("Autocomplete_GetColores", dbParams);
        }

        public static DataSet GetProductos(string sQuery)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Query", SqlDbType.VarChar, 0, sQuery),
				};
            return DBHelper.ExecuteDataSet("Autocomplete_GetProductos", dbParams);
        }
    }
}