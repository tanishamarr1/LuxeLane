using System;
using System.Collections.Generic;

namespace LuxeLane.Modelos;

public partial class Inventario
{
    public int StockId { get; set; }

    public int ProductoId { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public int Cantidad { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public int UsuarioId { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual Usuario Usuario { get; set; } = null!;
}
