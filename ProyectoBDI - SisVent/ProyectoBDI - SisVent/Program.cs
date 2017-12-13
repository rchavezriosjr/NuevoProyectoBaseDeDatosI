using ProyectoBDI___SisVent.vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDI___SisVent
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Conexión conexion = new Conexión();
            //string rpa = "";
            //SqlConnection cn = new SqlConnection(Conexión.Cn);
            //    try
            //    {
            //        cn.Open();
            //    }
            //    catch (Exception ex)
            //    {
            //        rpa = ex.Message;
            //    }

            //if (cn.State == ConnectionState.Open)
            //    Console.WriteLine("Test correcto");
            //else
            //    Console.WriteLine("Error: "+rpa);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
