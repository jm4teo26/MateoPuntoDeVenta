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

        // Método para agregar una categoría
        public static void AgregarCategoria(Categoria categoria)
        {
            using (var context = new SqLiteDbContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        // Método para actualizar una categoría
        public static void ActualizarCategoria(Categoria categoria)
        {
            using (var context = new SqLiteDbContext())
            {
                context.Categorias.Update(categoria);
                context.SaveChanges();
            }
        }

        // Método para eliminar una categoría
        public static void EliminarCategoria(int id)
        {
            using (var context = new SqLiteDbContext())
            {
                var categoria = context.Categorias.Find(id);
                if (categoria != null)
                {
                    context.Categorias.Remove(categoria);
                    context.SaveChanges();
                }
            }
        }

        // Método para obtener todas las categorías
        public static List<Categoria> ObtenerCategorias()
        {
            using (var context = new SqLiteDbContext())
            {
                return context.Categorias.ToList();
            }
        }

        // Método para buscar categorías
        public static List<Categoria> BuscarCategorias(string criterio)
        {
            using (var context = new SqLiteDbContext())
            {
                return context.Categorias
                    .Where(c => c.Nombre.Contains(criterio))
                    .ToList();
            }
        }
    }
}
