using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Data;
using NetCoreEF.Repositories;

namespace NetCoreEF
{
    internal static class Program
    {
        //NECESITAMOS LA VARIABLE DEL PROVEEDOR DE SERVICIOS
        //PARA RECUPERAR LOS REPOSITORIOS Y LAS CLASES DESDE
        //CUALQUIER FORMULARIO
        public static ServiceProvider provider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot configuration = builder.Build();
            //RECUPERAMOS LA CADENA DE CONEXION DIRECTAMENTE AQUI ESCRITA
            string connectionString =
                configuration.GetConnectionString("HospitalSQLServer");
            //NECESITAMOS UN OBJETO LLAMADO ServiceProvider QUE ES EL ENCARGADO DE RESOLVER LAS 
            //DEPENDENCIAS
            //CADA CLASE DEBEMOS INCLUIRLA DEPENDIENDO DE SU TIPO
            //1) SI ES UN REPOSITORIO:  AddTransient
            //2) SI ES UN CONTEXT:  AddDbContext
            //CUANDO AGREGAMOS UN CONTEXT DEBEMOS INDICAR SU BASE DE DATOS Y SU CADENA DE CONEXION
            //PROVEEDOR: SQL Server: UseSqlServer(cadena conexion)  My SQL: UseMySql(cadena conexion)
            //ALMACENAMOS LAS CLASES EN EL PROVIDER
            provider = new ServiceCollection()
                .AddTransient<RepositoryEmpleados>()
                .AddDbContext<EmpleadosContext>
                (options => options.UseSqlServer(connectionString))
                .BuildServiceProvider();


            Application.Run(new Form01TodosEmpleados());
        }
    }
}