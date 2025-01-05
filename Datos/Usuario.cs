using System;
using System.Collections.Generic;
using System.Linq;
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

        // Método para agregar un nuevo usuario
        public static void AgregarUsuario(Usuario usuario)
        {
            try
            {
                using (var context = new SqLiteDbContext())
                {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones para fallos al agregar
                Console.WriteLine($"Error al agregar el usuario: {ex.Message}");
            }
        }

        // Método para actualizar un usuario existente
        public static void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                using (var context = new SqLiteDbContext())
                {
                    context.Usuarios.Update(usuario);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones para fallos al actualizar
                Console.WriteLine($"Error al actualizar el usuario: {ex.Message}");
            }
        }

        // Método para eliminar un usuario por su Id
        public static void EliminarUsuario(int usuarioId)
        {
            try
            {
                using (var context = new SqLiteDbContext())
                {
                    var usuario = context.Usuarios.Find(usuarioId);
                    if (usuario != null)
                    {
                        context.Usuarios.Remove(usuario);
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Usuario no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones para fallos al eliminar
                Console.WriteLine($"Error al eliminar el usuario: {ex.Message}");
            }
        }

        // Método para buscar usuarios, con la opción de búsqueda por más campos
        public static List<Usuario> BuscarUsuarios(string criterio)
        {
            using (var context = new SqLiteDbContext())
            {
                // Normalizar el criterio de búsqueda a minúsculas para búsqueda insensible a mayúsculas/minúsculas
                criterio = criterio.ToLower();

                // Filtrar usuarios por alias, correo o rol (puedes agregar más campos si es necesario)
                return context.Usuarios
                              .Where(u => u.Alias.ToLower().Contains(criterio) ||
                                          u.Correo.ToLower().Contains(criterio) ||
                                          u.Rol.ToString().ToLower().Contains(criterio)) // Se agrega el Rol al filtro
                              .ToList();
            }
        }
    }

    // Enum para definir los roles posibles de un usuario
    public enum Rol
    {
        Administrador, Cajero, Auxiliar
    }
}
