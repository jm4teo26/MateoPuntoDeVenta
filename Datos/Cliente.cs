using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Datos
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string Apellido { get; set; }

        [Required, MaxLength(100)]
        public string Correo { get; set; }

        [MaxLength(20)]
        public string? Telefono { get; set; }
    }
}
