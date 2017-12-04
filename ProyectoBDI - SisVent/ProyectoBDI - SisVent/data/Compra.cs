using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDI___SisVent.data
{
    class Compra
    {
    public string ID { get; set; }
    public int ProveedorID { get; set; }
	public DateTime FechaCompra { get; set; }
    public int TipoPago { get; set; }
	public decimal Monto { get; set; }
    public List<DetalleCompra> Detail {get;set;}
    }
}
