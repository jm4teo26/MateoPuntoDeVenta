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
        public string Telefono { get; set; }

        public static void AgregarCliente(Cliente cliente)
        {
            using (var context = new SqLiteDbContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
        public static void ActualizarCliente(Cliente cliente)
        {
            using (var context = new SqLiteDbContext())
            {
                context.Clientes.Update(cliente);
                context.SaveChanges();
            }
        }
        public static void EliminarCliente(int clienteId)
        {
            using (var context = new SqLiteDbContext())
            {
                var cliente = context.Clientes.Find(clienteId);
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
            }
        }
        public static List<Cliente> BuscarClientes(string criterio)
        {
            using (var context = new SqLiteDbContext())
            {
                return context.Clientes
                    .Where(c => c.Nombre.Contains(criterio) || c.Apellido.Contains(criterio) || c.Correo.Contains(criterio))
                    .ToList();
            }
        }

    }
}
