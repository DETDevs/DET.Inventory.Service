
namespace DET.Inventory.Models
{
    public class MovimientoInventario
    {
        public int IdMovimiento { get; set; }
        public int FkProducto { get; set; }
        public int? FkCompra { get; set; }
        public int? FkFactura { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaMovimiento { get; set; } = DateTime.Now;
        public string OrigenMovimiento { get; set; }
        public int? ReferenciaId { get; set; }
        public int StockAntes { get; set; }
        public int StockDespues { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
