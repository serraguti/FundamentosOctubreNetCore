using Microsoft.EntityFrameworkCore;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Data
{
    public class EmpleadosContext: DbContext
    {
        //EN EL CONSTRUCTOR DE LA CLASE DEBEMOS RECIBIR LAS OPCIONES
        //DE LA BASE DE DATOS COMO LA CADENA DE CONEXION
        public EmpleadosContext(DbContextOptions<EmpleadosContext> options) 
            : base(options) { }

        //CONTENDRA UNA COLECCION DBSET CON LOS MODELOS
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }

        public DbSet<EmpleadoDepartamento> EmpleadosDepartamentos { get; set; }
    }
}
