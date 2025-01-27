
namespace DET.Inventory.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public int FkPersona { get; set; }
        public string NombreEmpresa { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
