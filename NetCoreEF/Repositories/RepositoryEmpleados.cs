﻿using NetCoreEF.Data;
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

        public List<int> GetNumerosDepartamento()
        {
            var consulta = (from datos in this.context.Empleados
                           select datos.IdDepartamento).Distinct();
            return consulta.ToList();
        }

        public ResumenEmpleados GetResumenEmpleadosDepartamento(int idDepartamento)
        {
            //REALIZAMOS UNA CONSULTA PARA LOS EMPLEADOS POR DEPARTAMENTO
            var consulta = from datos in this.context.Empleados
                           where datos.IdDepartamento == idDepartamento
                           select datos;
            //QUEREMOS SABER EL NUMERO DE PERSONAS
            int personas = consulta.Count();
            //NECESITAMOS EL MAXIMO SALARIO
            int maximo = consulta.Max(x => x.Salario);
            //RECUPERAMOS EL MINIMO SALARIO
            int minimo = consulta.Min(x => x.Salario);
            ResumenEmpleados resumen = new ResumenEmpleados();
            resumen.Empleados = consulta.ToList();
            resumen.Personas = personas;
            resumen.MaximoSalario = maximo;
            resumen.MinimoSalario = minimo;
            return resumen;
        }

        public void IncrementarSalarioEmpleados(string oficio, int incremento)
        {
            //DEBEMOS RECUPERAR LOS EMPLEADOS DE UN OFICIO
            List<Empleado> empleados = this.GetEmpleadosOficio(oficio);
            //RECORREMOS LOS DATOS DE LOS EMPLEADOS Y MODIFICAMOS SU SALARIO
            foreach (Empleado emp in empleados)
            {
                emp.Salario = emp.Salario + incremento;
            }
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS Y LO TENEMOS
            this.context.SaveChanges();
        }
    }
}
