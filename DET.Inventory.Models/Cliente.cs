﻿
namespace DET.Inventory.Models
{
    public class Cliente
    {
        public int? IdCliente { get; set; }
        public string? CodigoCliente { get; set; }
        public Persona? Persona { get; set; }
        public string? TipoCliente { get; set; }
        public bool? Activo { get; set; } = true;
        public DateTime? FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }
    }
}
