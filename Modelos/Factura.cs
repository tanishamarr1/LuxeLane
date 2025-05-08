using System;
using System.Collections.Generic;

namespace LuxeLane.Modelos;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int ClienteId { get; set; }

    public int UsuarioId { get; set; }

    public DateTime? FechaVenta { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<Detallefactura> Detallefacturas { get; set; } = new List<Detallefactura>();

    public virtual Usuario Usuario { get; set; } = null!;
}
