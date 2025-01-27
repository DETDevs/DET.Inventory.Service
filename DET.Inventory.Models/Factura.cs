
namespace DET.Inventory.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = "Emitida";
        public int FkCliente { get; set; }
        public int FkUsuario { get; set; }
        public decimal Subtotal { get; set; } = 0.00M;
        public decimal Impuesto { get; set; } = 0.00M;
        public decimal Total { get; set; } = 0.00M;
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
