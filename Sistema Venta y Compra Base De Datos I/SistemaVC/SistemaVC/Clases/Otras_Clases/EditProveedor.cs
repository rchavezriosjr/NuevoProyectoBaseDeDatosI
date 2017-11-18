using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SistemaVC.Classes;

namespace SistemaVC
{
    public partial class EditProveedor
    {
        public static int InsertarProveedor(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, proveedor.P_Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0,proveedor.P_Domicilio),
                    DBHelper.MakeParam("@Tel", SqlDbType.VarChar, 0,proveedor.P_Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0,proveedor.P_Email)

				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("Insertar_Proveedores", dbParams));
        }
        public static int Actualizar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, proveedor.P_Id),
                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, proveedor.P_Nombre),
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0,proveedor.P_Domicilio),
                    DBHelper.MakeParam("@Tel", SqlDbType.VarChar, 0,proveedor.P_Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0,proveedor.P_Email)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("Actualizar_Proveedores", dbParams));
        }

        public static DataSet GetProveedor(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, proveedor.P_Id),
				};
            return DBHelper.ExecuteDataSet("Proveedor_Get_edit", dbParams);
        }

    }
}