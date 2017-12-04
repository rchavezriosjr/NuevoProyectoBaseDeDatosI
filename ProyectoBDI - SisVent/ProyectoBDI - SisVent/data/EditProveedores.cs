using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditProveedores
    {
        public void InsertarProveedor(Proveedor prov)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.NVarChar;
                Name.Size = 200;
                Name.Value = prov.P_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.NVarChar;
                Dom.Size = 200;
                Dom.Value = prov.P_Domicilio ;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.NVarChar;
                Tel.Size = 200;
                Tel.Value = prov.P_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.NVarChar;
                Correo.Size = 200;
                Correo.Value = prov.P_Email;
                cmd.Parameters.Add(Correo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible insertar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        public void ActualizaProveedor(Proveedor prov)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Proveedores";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@ID";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = prov.P_Id;
                cmd.Parameters.Add(ID);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 200;
                Name.Value = prov.P_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 200;
                Dom.Value = prov.P_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Tel";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 200;
                Tel.Value = prov.P_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 200;
                Correo.Value = prov.P_Email;
                cmd.Parameters.Add(Correo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible actualizar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        public DataSet GetProveedores(string valor, int clave)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Busqueda_Proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@valor";
                ID.SqlDbType = SqlDbType.VarChar;
                ID.Size = 100;
                ID.Value = valor ;
                cmd.Parameters.Add(ID);

                SqlParameter key = new SqlParameter();
                key.ParameterName = "@clave";
                key.SqlDbType = SqlDbType.Int;
                key.Value = clave;
                cmd.Parameters.Add(key);

                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta realizada sin exito: " + ex.ToString());
                dt = null;
            }
            return dt;
        }
    }
}
