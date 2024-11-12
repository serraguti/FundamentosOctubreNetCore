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

        private int GetMaxIdDepartamento()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            //EN ESTA ACCION, TENEMOS DOS POSIBILIDADES
            //1) PUEDE SER QUE NO TENGAMOS DATOS EN LA TABLA, POR LO QUE
            //MAX NOS OFRECE UN NULL Y NO FUNCIONARIA
            //2) TENEMOS DATOS Y DEVOLVEMOS EL MAXIMO
            if (consulta.Count() == 0)
            {
                return 1;
            }
            else
            {
                int maximo = consulta.Max(z => z.IdDepartamento) + 1;
                return maximo;
            }
        }

        public void InsertarDepartamento(string nombre, string localidad)
        {
            //CREAMOS UN NUEVO MODELO DE DEPARTAMENTO
            Departamento departamento = new Departamento();
            //ASIGNAMOS SUS PROPIEDADES
            departamento.IdDepartamento = this.GetMaxIdDepartamento();
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

        public void EliminarDepartamento(int id)
        {
            //BUSCAMOS EL DEPARTAMENTO QUE DESEAMOS ELIMINAR
            Departamento departamento = this.FindDepartamento(id);
            //TENEMOS EL METODO Remove DE LA COLECCION DBSET DEL CONTEXT
            //PARA ELIMINAR EL OBJETO
            this.context.Departamentos.Remove(departamento);
            //GUARDAMOS LOS DATOS EN LA BASE DE DATOS
            this.context.SaveChanges();
        }
    }
}
