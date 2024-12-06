using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos
{
    [Table("Ventas")]
    public class Venta
    {
        public int Id { get; set; }

        [Required, ForeignKey("FK_Ventas_Clientes_Id")]
        public int ClienteId { get; set; }
       
        [Required, ForeignKey("FK_Ventas_Usuario_Id")]
        public int UsuarioId { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }

        // Manejo interno de efcore
        [NotMapped]
        public Cliente Cliente { get; set; }
        [NotMapped]
        public Usuario Usuario { get; set; }

        // Relacion con la clase ProductosVentas
        [NotMapped]
        public List<ProductosVentas> ProductosVentas { get; set; } = new List<ProductosVentas>();
    }
}
 