using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DET.Inventory.Models
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Stock { get; set; } = 0;
        public decimal PrecioCompra { get; set; } = 0.00m;
        public decimal PrecioVenta { get; set; } = 0.00m;
        public decimal? MargenGanancia { get; set; }
        public bool Estado { get; set; } = true;
        public int FkProveedor { get; set; }
        public int FkCategoria { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
