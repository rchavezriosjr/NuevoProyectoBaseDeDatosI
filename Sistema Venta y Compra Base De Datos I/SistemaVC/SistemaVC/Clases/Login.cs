using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using SistemaVC.Classes;

namespace SistemaVC
{
    public partial class Login
    {
        public static DataSet ValidarLogin(string sUserName, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUserName),
                    DBHelper.MakeParam("@Contraseña", SqlDbType.VarChar, 0, sPassword)
				};
           // return DBHelper.ExecuteDataSet("usp_Login_ValidarLogin", dbParams);
             return DBHelper.ExecuteDataSet("Validar_Usuario", dbParams);
        }
    }
}