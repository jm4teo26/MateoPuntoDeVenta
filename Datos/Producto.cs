using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
        // Métodos CRUD

        public static async Task<List<Producto>> ObtenerProductosAsync()
        {
            using var context = new SqLiteDbContext();
            return await context.Productos.Include(p => p.Categoria).ToListAsync();
        }

        public static async Task<Producto> CrearProductoAsync(Producto producto)
        {
            using var context = new SqLiteDbContext();
            context.Productos.Add(producto);
            await context.SaveChangesAsync();
            return producto;
        }

        public static async Task<Producto> ActualizarProductoAsync(Producto producto)
        {
            using var context = new SqLiteDbContext();
            var productoExistente = await context.Productos.FindAsync(producto.Id);
            if (productoExistente != null)
            {
                productoExistente.Nombre = producto.Nombre;
                productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.PrecioUnitario = producto.PrecioUnitario;
                productoExistente.PrecioCompra = producto.PrecioCompra;
                productoExistente.Stock = producto.Stock;

                context.Productos.Update(productoExistente);
                await context.SaveChangesAsync();
            }
            return productoExistente;
        }

        public static async Task<bool> EliminarProductoAsync(int id)
        {
            using var context = new SqLiteDbContext();
            var producto = await context.Productos.FindAsync(id);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }

}
