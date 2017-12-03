using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class DetalleVenta
    {
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Descuento { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
    }
}
