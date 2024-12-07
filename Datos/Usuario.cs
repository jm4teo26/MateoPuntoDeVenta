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

        // Método estático para agregar un usuario
        public static void AgregarUsuario(string alias, string correo, string contrasenia, Rol rol)
        {
            using (var context = new SqLiteDbContext())
            {
                // Verificar si ya existe un usuario con el mismo alias
                if (context.Usuarios.Any(u => u.Alias == alias))
                {
                    throw new Exception("El alias ya está en uso.");
                }

                // Crear un nuevo usuario
                var nuevoUsuario = new Usuario
                {
                    Alias = alias,
                    Correo = correo,
                    Contrasenia = contrasenia, // Considera cifrar la contraseña
                    Rol = rol
                };

                context.Usuarios.Add(nuevoUsuario);
                context.SaveChanges();

                Console.WriteLine("Usuario agregado exitosamente.");
            }
        }
    }

    public enum Rol
    {
        Administrador, Cajero, Auxiliar
    }
}
