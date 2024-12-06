using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos
{
    [Table("Categorias")]
    public class Categoria
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        // Relación uno a muchos con Producto
        [NotMapped]
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
