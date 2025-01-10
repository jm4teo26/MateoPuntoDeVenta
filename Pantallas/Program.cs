using Microsoft.EntityFrameworkCore;
using Datos;
namespace Pantallas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            InicializarBaseDeDatos();
            Application.Run(new frmProductos());

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
        }
        static void InicializarBaseDeDatos()
        {
            var db = new Datos.SqLiteDbContext();
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}