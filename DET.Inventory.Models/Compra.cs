
namespace DET.Inventory.Models
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string NumeroCompra { get; set; }
        public int FkProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public decimal Subtotal { get; set; } = 0.00M;
        public decimal Impuesto { get; set; } = 0.00M;
        public decimal Total { get; set; } = 0.00M;
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
