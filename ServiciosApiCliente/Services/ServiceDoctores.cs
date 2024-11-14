using ServiciosApiCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosApiCliente.Services
{
    public class ServiceDoctores
    {
        //NECESITAMOS LA URL DE ACCESO AL SERVICIO
        private string ApiUrlDoctores;
        //CUANDO CONSUMIMOS UN SERVICIO DEBEMOS INDICAR EL 
        //TIPO DE DATOS QUE ESTAMOS RECIBIENDO (JSON)
        private MediaTypeWithQualityHeaderValue Header;

        public ServiceDoctores() 
        {
            this.ApiUrlDoctores = "https://apidoctoresroutes2023.azurewebsites.net/";
            this.Header =
                new MediaTypeWithQualityHeaderValue("application/json");
        }

        //DEBEMOS CREAR UN METODO QUE NOS DEVOLVERA LOS DATOS DE LOS DOCTORES
        //EL METODO DEBE SER ASINCRONO
        public async Task<List<Doctor>> GetDoctoresAsync()
        {
            //DEBEMOS UTILIZAR using PARA PODER LEER EL SERVICIO
            using (HttpClient client = new HttpClient()) 
            {
                //INDICAMOS LA URL DE NUESTRO SERVICIO
                client.BaseAddress = new Uri(this.ApiUrlDoctores);
                //DEBEMOS INDICAR EL TIPO DE DATOS QUE VAMOS A CONSUMIR (JSON)
                //COMO PODRIAMOS TENER PETICIONES CRUZADAS, POR NORMA, SE LIMPIAN 
                //LAS CABECERAS PARA CADA PETICION
                client.DefaultRequestHeaders.Clear();
                //MEDIANTE UN HEADER LE INDICAMOS QUE CONSUMIMOS JSON
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                //POR ULTIMO, DEBEMOS INDICAR EL REQUEST DONDE ESTAN LOS DATOS
                string request = "api/doctores";
                //REALIZAMOS LA PETICION AL METODO Y NOS DEVOLVERA UNA RESPUESTA
                HttpResponseMessage response =
                    await client.GetAsync(request);
                //COMPROBAMOS SI LA PETICION ES CORRECTA O NO
                if (response.IsSuccessStatusCode) 
                {
                    //SI LA RESPUESTA ES CORRECTA, TENEMOS A LOS DOCTORES AQUI
                    List<Doctor> doctores = await response.Content.ReadAsAsync<List<Doctor>>();
                    return doctores;
                }
                else
                {
                    //SI LA RESPUESTA NO ES CORRECTA, POR NORMA, SE DEVUELVE NULL
                    return null;
                }
            }
        }

        public async Task<Doctor> FindDoctorAsync(int iddoctor)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiUrlDoctores);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                string request = "api/doctores/" + iddoctor;
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    Doctor doctor = await response.Content.ReadAsAsync<Doctor>();
                    return doctor;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
