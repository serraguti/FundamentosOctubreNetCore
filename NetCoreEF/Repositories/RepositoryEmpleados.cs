using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Repositories
{
    public class RepositoryEmpleados
    {
        //NECESITAMOS UTILIZAR AQUI EL CONTEXT PARA LAS CONSULTAS
        EmpleadosContext context;

        //EL CONTEXT NO SE CREA, SINO QUE NOS LO DARA NUESTRO CONTAINER (PROGRAM)
        //AQUI ES CUANDO UTILIZAMOS INYECCION DE DEPENDENCIAS
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        //CREAMOS UN METODO PARA RECUPERAR LOS EMPLEADOS
        public List<Empleado> GetEmpleados()
        {
            //HACEMOS LA CONSULTA LINQ PARA RECUPERAR LOS DATOS
            var consulta = from datos in this.context.Empleados
                           select datos;
            //DEVOLVEMOS LOS DATOS DE LA COLECCION EMPLEADOS
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Salario >= salario
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosDepartamento(int iddepartamento)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.IdDepartamento == iddepartamento
                           select datos;
            return consulta.ToList();
        }

        public List<string> GetOficios()
        {
            var consulta = (from datos in this.context.Empleados
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }
    }
}
