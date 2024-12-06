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

        public static Usuario IniciarSesion(string alias, string contrasenia)
        {
            using (var context = new SqLiteDbContext()) // Acceso al DbContext
            {
                // Buscar al usuario en la base de datos por alias
                var usuario = context.Usuarios.FirstOrDefault(u => u.Alias == alias);

                if (usuario == null)
                {
                    throw new Exception("El usuario no existe.");
                }

                // Validar la contraseña
                if (usuario.Contrasenia != contrasenia)
                {
                    throw new Exception("Contraseña incorrecta.");
                }

                // Retornar el usuario si todo es válido
                return usuario;
            }
        }


    }

    public enum Rol
    {
        Administrador, Cajero, Auxiliar
    }
}
