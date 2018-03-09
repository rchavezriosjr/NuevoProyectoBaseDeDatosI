using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDI___SisVent.data;

namespace ProyectoBDI___SisVent.vista
{
    public partial class inicio : UserControl
    {
        ExtrasContadores c = new ExtrasContadores();
        public inicio()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            
            try {
                DataRow row = new ExtrasContadores().Contadores().Rows[0];
                label3.Text = row["Cliente"].ToString();
                label6.Text = row["Proveedor"].ToString();
                label4.Text = row["Producto"].ToString();
                label8.Text = row["Venta"].ToString();

                ultimasVentas.DataSource = new ExtrasContadores().ultimasVentas();
                productosMasVendidos.DataSource = new ExtrasContadores().productosMasVendidos();
                mejoresClientes.DataSource = new ExtrasContadores().topClientes();
            }
            catch (Exception ex) { Console.WriteLine("Consulta realizada sin exito: " + ex.ToString()); }
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            cargar();
        }

        
    }
}
