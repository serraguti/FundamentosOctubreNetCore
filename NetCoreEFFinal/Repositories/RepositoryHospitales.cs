using Microsoft.EntityFrameworkCore;
using NetCoreEFFinal.Data;
using NetCoreEFFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEFFinal.Repositories
{
    public class RepositoryHospitales
    {
        HospitalContext context;

        public RepositoryHospitales(HospitalContext context)
        {
            this.context = context;
        }

        //VAMOS A REALIZAR LAS CONSULTAS MEDIANTE async/await
        //SIEMPRE QUE DEVOLVAMOS ALGO DENTRO DE UN METODO ASINCRONO DEBEMOS
        //DEVOLVER EL OBJETO DENTRO DE Task<>
        public async Task<List<Hospital>> GetHospitalesAsync() {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return await consulta.ToListAsync();
        }

        public async Task<Hospital> FindHospitalAsync(int idhospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idhospital
                           select datos;
            return await consulta.FirstAsync();
        }

        //A CONTINUACION VAMOS A REALIZAR EL METODO INSERTAR HOSPITAL
        //COMO NO VAMOS A DEVOLVER NADA, AL HACERLO ASINCRONO, LE DIREMOS QUE 
        //ES UN METODO DE TIPO Task EN LUGAR DE void
        public async Task InsertarHospitalAsync(int idhospital, string nombre
            , string direccion, string telefono, int camas)
        {
            Hospital hospital = new Hospital();
            hospital.IdHospital = idhospital;
            hospital.Nombre = nombre;
            hospital.Direccion = direccion;
            hospital.Telefono = telefono;
            hospital.Camas = camas;
            //AGREGAMOS EL NUEVO HOSPITAL A LA CLASE DBCONTEXT
            await this.context.Hospitales.AddAsync(hospital);
            //GUARDAMOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarHospitalAsync(int idhospital, string nombre
            , string direccion, string telefono, int camas)
        {
            //BUSCAMOS EL HOSPITAL A MODIFICAR POR SU ID
            Hospital hospital = await this.FindHospitalAsync(idhospital);
            //MODIFICAMOS LAS PROPIEDADES DEL HOSPITAL
            hospital.Nombre = nombre;
            hospital.Direccion = direccion;
            hospital.Telefono = telefono;
            hospital.Camas = camas;
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarHospitalAsync(int idhospital)
        {
            Hospital hospital = await this.FindHospitalAsync(idhospital);
            //ELIMINAMOS EL HOSPITAL DE LA COLECCION DbSet
            this.context.Hospitales.Remove(hospital);
            //GUARDAMOS LOS CAMBIOS EN LA BASE DE DATOS
            await this.context.SaveChangesAsync();
        }
    }
}
