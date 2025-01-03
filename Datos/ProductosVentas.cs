using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos
{
    [Table("ProductosVentas")]
    public class ProductosVentas
    {
        [ForeignKey("FK_ProductosVentas_Ventas_Id")]
        public int VentaId { get; set; }

        [ForeignKey("FK_ProductosVentas_Productos_Id")]
        public int ProductoId { get; set; }

        [Required]
        public decimal PrecioVenta { get; set; }

        [Required]
        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        // Para manejo de EF Core
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
    }
}
