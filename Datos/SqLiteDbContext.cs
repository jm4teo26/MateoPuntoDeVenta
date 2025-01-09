using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SqLiteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbFileName = "biblioteca.sqlite";
            var dbDirectory = Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Db"));
            var dbPath = Path.Combine(dbDirectory.FullName, dbFileName);
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ProductosVentas> ProductosVentas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId);
            modelBuilder.Entity<Usuario>(usuario =>
            {
                usuario.HasIndex(u => u.Alias).IsUnique();
                usuario.HasIndex(u => u.Correo).IsUnique();

            }
            );
            modelBuilder.Entity<Categoria>()
                .HasIndex(cat => cat.Nombre).IsUnique();
            modelBuilder.Entity<ProductosVentas>()
                .HasKey(dv => new { dv.VentaId, dv.ProductoId });
            modelBuilder.Entity<ProductosVentas>(dv =>
            {
                dv.HasOne(d => d.Venta)
                    .WithMany(v => v.ProductosVentas)
                    .HasForeignKey("FK_ProductosVenta_Ventas_Id");

                dv.HasOne<Producto>(d => d.Producto)
                    .WithMany(p => p.ProductosVentas)
                    .HasForeignKey("FK_ProductosVenta_Productos_Id");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
