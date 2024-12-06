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

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            InicializarBaseDeDatos();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());

        }

        static void InicializarBaseDeDatos()
        {
            using (var Db = new Datos.SqLiteDbContext())
            {
                //Db.Database.EnsureDeleted();
                Db.Database.EnsureCreated();
            }

        }
    }
}