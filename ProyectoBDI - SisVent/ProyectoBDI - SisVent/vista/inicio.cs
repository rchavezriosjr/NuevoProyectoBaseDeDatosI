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

        public void Client()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = c.ContClient();
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            label3.Text = row[0].ToString();
        }

        public void Prod()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = c.ContProd();
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            label4.Text = row[0].ToString();
        }

        public void Prov()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = c.ContProv();
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            label6.Text = row[0].ToString();
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
