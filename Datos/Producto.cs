using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos
{
    [Table("Productos")]
    public class Producto
    {
        public int Id { get; set; }

        [ForeignKey("FK_Productos_Categoria_Id")]
        public int CategoriaId { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public decimal PrecioCompra { get; set; }

        [Required]
        public int Stock { get; set; }

        //Manejo de Entity Framework
        [NotMapped]
        public Categoria Categoria { get; set; }
        [NotMapped]

        //Relacion con la clase Productosventas
        public List<ProductosVentas> ProductosVentas { get; set; }
    }

}
