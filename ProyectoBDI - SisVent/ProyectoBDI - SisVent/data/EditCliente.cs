using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class EditCliente
    {
        public void InsertarCliente(Cliente client)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insertar_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 200;
                Name.Value = client.C_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 200;
                Dom.Value = client.C_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 200;
                Tel.Value = client.C_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 200;
                Correo.Value = client.C_Email;
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
        public void Actualizar(Cliente client)
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                Con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Actualizar_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@Id";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = client.C_Id;
                cmd.Parameters.Add(ID);

                SqlParameter Name = new SqlParameter();
                Name.ParameterName = "@Nombre";
                Name.SqlDbType = SqlDbType.VarChar;
                Name.Size = 200;
                Name.Value = client.C_Nombre;
                cmd.Parameters.Add(Name);

                SqlParameter Dom = new SqlParameter();
                Dom.ParameterName = "@Domicilio";
                Dom.SqlDbType = SqlDbType.VarChar;
                Dom.Size = 200;
                Dom.Value = client.C_Domicilio;
                cmd.Parameters.Add(Dom);

                SqlParameter Tel = new SqlParameter();
                Tel.ParameterName = "@Telefono";
                Tel.SqlDbType = SqlDbType.VarChar;
                Tel.Size = 200;
                Tel.Value = client.C_Telefono;
                cmd.Parameters.Add(Tel);

                SqlParameter Correo = new SqlParameter();
                Correo.ParameterName = "@Email";
                Correo.SqlDbType = SqlDbType.VarChar;
                Correo.Size = 200;
                Correo.Value = client.C_Email;
                cmd.Parameters.Add(Correo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Imposible Actualizar: " + ex.ToString());
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public DataSet GetCliente(Cliente client)
        {
            DataSet dt = new DataSet();
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = Conexión.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "ListProveedores_Get";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ID = new SqlParameter();
                ID.ParameterName = "@Id";
                ID.SqlDbType = SqlDbType.Int;
                ID.Value = client.C_Id;
                cmd.Parameters.Add(ID);

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
