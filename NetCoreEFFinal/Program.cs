using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEFFinal.Data;
using NetCoreEFFinal.Repositories;

namespace NetCoreEFFinal
{
    internal static class Program
    {
        public static ServiceProvider Provider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //RECUPERAMOS LA CADENA DE CONEXION DEL FICHERO DE CONFIGURACION
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("HospitalSQLServer");
            //string connectionString = configuration.GetConnectionString("HospitalMySql");
            //string connectionString = configuration.GetConnectionString("HospitalOracle");

            //INYECTAMOS LAS CLASES NECESARIAS PARA LOS FORMULARIOS Y TAMBIEN PARA
            //ENTITY FRAMEWORK
            Provider = new ServiceCollection()
                .AddTransient<RepositoryHospitales>()
                .AddDbContext<HospitalContext>
                (options => options.UseSqlServer(connectionString))
                //(options => options.UseOracle(connectionString))
                //(options => options.UseMySql(connectionString
                //, ServerVersion.AutoDetect(connectionString)))
                .BuildServiceProvider();

            Application.Run(new Form03EliminarEnfermos());
        }
    }
}