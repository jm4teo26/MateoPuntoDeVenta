using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
        // Métodos para manejar ventas
        public static async Task<List<Venta>> ObtenerTodasLasVentasAsync()
        {
            using var context = new SqLiteDbContext();
            return await context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.Usuario)
                .Include(v => v.ProductosVentas)
                    .ThenInclude(pv => pv.Producto)
                .ToListAsync();
        }

        public static async Task<Venta> ObtenerVentaPorIdAsync(int id)
        {
            using var context = new SqLiteDbContext();
            return await context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.Usuario)
                .Include(v => v.ProductosVentas)
                    .ThenInclude(pv => pv.Producto)
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public static async Task<bool> AgregarVentaAsync(Venta nuevaVenta)
        {
            try
            {
                using var context = new SqLiteDbContext();
                context.Ventas.Add(nuevaVenta);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> EliminarVentaAsync(int id)
        {
            try
            {
                using var context = new SqLiteDbContext();
                var venta = await context.Ventas
                    .Include(v => v.ProductosVentas)
                    .FirstOrDefaultAsync(v => v.Id == id);

                if (venta == null)
                    return false;

                // Eliminar productos relacionados
                context.ProductosVentas.RemoveRange(venta.ProductosVentas);
                // Eliminar la venta
                context.Ventas.Remove(venta);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
 