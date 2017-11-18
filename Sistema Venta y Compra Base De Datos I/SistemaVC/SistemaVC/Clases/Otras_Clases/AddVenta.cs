using System.Data;
using SistemaVC.Clases;
using SistemaVC.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using SiatemaVC;

namespace SistemaVC
{
    public partial class AddVenta
    {
        public static int Insertar(Venta venta)
        {
            int VentaId = 0;

            //SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            //cn.Open();
            //SqlTransaction trx = cn.BeginTransaction();

            try
            {
                SqlParameter[] dbParams = new SqlParameter[]
				{
                    DBHelper.MakeParam("@FechaVenta", SqlDbType.DateTime, 0, venta.FechaVenta),
                    DBHelper.MakeParam("@ClienteId", SqlDbType.Int, 0, venta.Cliente.C_Id),
                    DBHelper.MakeParam("@MontoTotal", SqlDbType.Decimal, 0, venta.MontoTotal),
                    DBHelper.MakeParam("@UserId", SqlDbType.Int, 0, venta.UserId)
				};

               

                VentaId =Convert.ToInt32(DBHelper.ExecuteScalar("AddVenta_Insertar", dbParams));

                //foreach (DetalleVenta detalle in venta.DetalleVentas)
                //{
                //    detalle.VentaId = VentaId;
                //    if (InsertarDetalle(detalle, trx, cn) == 0)
                //    {
                //        throw new Exception("Hubo un error en la insercion de detalle " + detalle.Producto.Descripcion);
                //    }

                //}

                //trx.Commit();

                return VentaId;

            }
            catch (Exception ex)
            {
                //trx.Rollback();
                //cn.Close();
                throw ex;
            }
        }

        
    }
}