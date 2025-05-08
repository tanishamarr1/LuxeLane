using System;
using System.Collections.Generic;

namespace LuxeLane.Modelos;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int CategoriaId { get; set; }

    public int StockId { get; set; }

    public string? Talla { get; set; }

    public string? Color { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<Detallefactura> Detallefacturas { get; set; } = new List<Detallefactura>();

    public virtual Inventario Stock { get; set; } = null!;
}
