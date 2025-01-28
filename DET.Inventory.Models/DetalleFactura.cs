
namespace DET.Inventory.Models
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int FkFactura { get; set; }
        public int FkProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
