using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class Venta
    {
        public int Id
        { get; set; }
        public int ClientId
        { get; set; }
        public int UserId
        { get; set; }
        public DateTime FechaVenta
        { get; set; }
        public int TipoPago
        { get; set; }
        public int TipoVenta
        { get; set; }
        public double SubTotal { get;set; }
        public double Tax { get; set; }
        public double MontoTotal
        { get; set; }
        public List<DetalleVenta> DetalleVentas
        { get; set; }

    }
}
