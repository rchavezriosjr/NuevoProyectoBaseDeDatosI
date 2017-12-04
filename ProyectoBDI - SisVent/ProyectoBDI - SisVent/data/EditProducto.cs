using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditProducto
    {
        public void InsertarProducto(Producto p)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@CategoriaID";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = p.CategoriaID;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Nombre";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 200;
                ParContraseña.Value = p.Nombre;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@PecioVenta";
                ParNombre.SqlDbType = SqlDbType.Decimal;
                ParNombre.Value = p.PrecioVenta;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Stock";
                ParApellido.SqlDbType = SqlDbType.Int;
                ParApellido.Value = p.Stock;
                SqlCmd.Parameters.Add(ParApellido);


                SqlParameter ParDes = new SqlParameter();
                ParDes.ParameterName = "@Descripcion";
                ParDes.SqlDbType = SqlDbType.VarChar;
                ParDes.Size = 250;
                ParDes.Value = p.Descripcion;
                SqlCmd.Parameters.Add(ParDes);


                SqlParameter ParApellid = new SqlParameter();
                ParApellid.ParameterName = "@Estado";
                ParApellid.SqlDbType = SqlDbType.Int;
                ParApellid.Value = p.Estado;
                SqlCmd.Parameters.Add(ParApellid);

                //SqlCmd.ExecuteNonQuery();

                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Usuario creado correctamente", popup.AlertType.check);
                else
                    new popup("Usuario no creado", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }



        public void ActualizarProducto(Producto p)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Actualizar_Producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@ID";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = p.ID;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParUsuari = new SqlParameter();
                ParUsuari.ParameterName = "@CategoriaID";
                ParUsuari.SqlDbType = SqlDbType.Int;
                ParUsuari.Value = p.CategoriaID;
                SqlCmd.Parameters.Add(ParUsuari);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Nombre";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 200;
                ParContraseña.Value = p.Nombre;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@PrecioVenta";
                ParNombre.SqlDbType = SqlDbType.Decimal;
                ParNombre.Value = p.PrecioVenta;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@Stock";
                ParApellido.SqlDbType = SqlDbType.Int;
                ParApellido.Value = p.Stock;
                SqlCmd.Parameters.Add(ParApellido);


                SqlParameter ParDes = new SqlParameter();
                ParDes.ParameterName = "@Descripcion";
                ParDes.SqlDbType = SqlDbType.VarChar;
                ParDes.Size = 250;
                ParDes.Value = p.Descripcion;
                SqlCmd.Parameters.Add(ParDes);


                SqlParameter ParApellid = new SqlParameter();
                ParApellid.ParameterName = "@Estado";
                ParApellid.SqlDbType = SqlDbType.Int;
                ParApellid.Value = p.Estado;
                SqlCmd.Parameters.Add(ParApellid);

                //SqlCmd.ExecuteNonQuery();

                //Ejecutamos nuestro comando

                if (SqlCmd.ExecuteNonQuery() == 1)
                    new popup("Usuario creado correctamente", popup.AlertType.check);
                else
                    new popup("Usuario no creado", popup.AlertType.error); ;

            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }
    }
}
