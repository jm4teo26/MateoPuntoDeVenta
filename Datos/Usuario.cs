using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{
    [Table("Usuarios")]
    public class Usuario
    {

        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Alias { get; set; }

        [Required, MaxLength(50)]
        public string Correo { get; set; }

        [Required]
        public string Contrasenia { get; set; }

        public Rol Rol { get; set; } // Admin, Cajero, etc.

    }

    public enum Rol
    {
        Administrador, Cajero, Auxiliar
    }
}
