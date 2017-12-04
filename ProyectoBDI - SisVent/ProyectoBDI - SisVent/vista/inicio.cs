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
            cargar();
            InitializeComponent();
        }

        public void cargar()
        {
            //label3.Text = new ExtrasContadores().ContClient().ToString();
            //label6.Text = new ExtrasContadores().ContProv().ToString();
            //label4.Text = new ExtrasContadores().ContProd().ToString();
            //label8.Text = new ExtrasContadores().ContVentasMes().ToString();
            //ultimasVentas.DataSource = new ExtrasContadores().ContUltVta();
        }

        //public void Vtas()
        //{
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    DateTime Año =  new DateTime();
        //    ds = c.ContVentasMes(Año.Year);
        //    dt = ds.Tables[0];
        //    DataRow row = dt.Rows[0];
        //    label4.Text = row[0].ToString();
        //}


    }
}
