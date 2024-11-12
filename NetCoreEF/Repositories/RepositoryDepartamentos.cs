using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Repositories
{
    public class RepositoryDepartamentos
    {
        EmpleadosContext context;

        public RepositoryDepartamentos(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        public Departamento FindDepartamento(int id)
        {
            var consulta = from datos in this.context.Departamentos
                           where datos.IdDepartamento == id
                           select datos;
            return consulta.First();
        }

        public void InsertarDepartamento(int id, string nombre, string localidad)
        {
            //CREAMOS UN NUEVO MODELO DE DEPARTAMENTO
            Departamento departamento = new Departamento();
            //ASIGNAMOS SUS PROPIEDADES
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            //AÑADIMOS EL MODELO DEPARTAMENTO AL CONTEXT
            this.context.Departamentos.Add(departamento);
            //GUARDAMOS LOS DATOS EN LA BASE DE DATOS
            this.context.SaveChanges();
        }

        public void ModificarDepartamento(int id, string nombre, string localidad)
        {
            //BUSCAMOS EL DEPARTAMENTO QUE NECESITAMOS MODIFICAR
            Departamento departamento = this.FindDepartamento(id);
            //MODIFICAMOS SUS PROPIEDADES
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            //NO TENEMOS METODO PARA MODIFICAR, SIMPLEMENTE
            //LE DEBEMOS INDICAR QUE GUARDAMOS CAMBIOS
            this.context.SaveChanges();
        }
    }
}
