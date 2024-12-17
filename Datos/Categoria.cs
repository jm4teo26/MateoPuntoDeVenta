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
        public static void AgregarCategoria(string nombre)
        {
            using (var context = new SqLiteDbContext())
            {
                // Verificar si ya existe la categoría
                if (context.Categorias.Any(c => c.Nombre == nombre))
                {
                    throw new Exception("La categoría ya existe.");
                }

                // Crear una nueva categoría
                var nuevaCategoria = new Categoria
                {
                    Nombre = nombre
                };

                context.Categorias.Add(nuevaCategoria);
                context.SaveChanges();
            }
        }

        // Método estático para cargar las categorías desde la base de datos
        public static List<Categoria> CargarCategorias()
        {
            using (var context = new SqLiteDbContext())
            {
                // Recuperar todas las categorías
                return context.Categorias.ToList();
            }
        }
    }

}
