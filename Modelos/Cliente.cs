using System;
using System.Collections.Generic;

namespace LuxeLane.Modelos;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
