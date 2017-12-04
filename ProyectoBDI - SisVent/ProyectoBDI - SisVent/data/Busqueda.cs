using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class Busqueda
    {

        public DataTable BusquedaUsuarios(string value)
        {
            DataTable dt = new DataTable("Acceso");
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexión.Cn))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "select* from Usuario where Nombre like %"+ value+ "% or ID like %" + value + "%",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                dt = null;
            }


            return dt;
        }


        public DataTable MostrarCategoria(int estado)
        {
            DataTable dt = new DataTable("Acceso");
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexión.Cn))
                {
                    cn.Open();
                    SqlCommand cmd;
                    if (estado == 1)
                        cmd = new SqlCommand("select* from Categoria where Estado = 1", cn);
                    else
                        cmd = new SqlCommand("select* from Categoria", cn);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                dt = null;
            }


            return dt;
        }


        public DataTable MostrarProductosDeshabilitados()
        {
            DataTable dt = new DataTable("Acceso");
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexión.Cn))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select* from Producto where Estado = 0", cn);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                dt = null;
            }


            return dt;
        }

        public DataTable BusquedaCliente(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable BusquedaProveedor(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable BusquedaCompras(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable BusquedaVentas(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable BusquedaProductos(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable BusquedaCategoria(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable BusquedaProductosDeshabilitados(string valor, int clave)
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Busqueda_Productos_Deshabilitados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.VarChar;
                ParValor.Size = 100;
                ParValor.Value = valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = clave;
                SqlCmd.Parameters.Add(ParClave);
                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable MostrarUsuarios()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Usuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable MostrarClientes()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Clientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable MostrarProveedores()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Proveedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable MostrarProductos()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Productos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable MostrarVentas()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }


        public DataTable MostrarCompras()
        {
            DataTable dt = new DataTable("Acceso");
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Asignar valor retornado del procedimiento almacenado en un datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
                //Ejecutamos nuestro comando
                //if (SqlCmd.ExecuteNonQuery() == 1)
                //    new popup("Cuenta eliminada correctamente", popup.AlertType.check);
                //else
                //    new popup("Cuenta no eliminada", popup.AlertType.error); ;
            }
            catch (Exception ex)
            {
                new popup(ex.Message, popup.AlertType.error);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dt;
        }

    }
}
