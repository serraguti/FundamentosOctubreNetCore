﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum Paises { España, Francia, Alemania, Suiza, China, Andorra, Colombia }

    public class Persona
    {
        #region PROPIEDADES
        public Paises Nacionalidad { get; set; }

        //VAMOS A CREAR TRES PROPIEDADES
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        private int _CampoEdad;

        public int Edad
        {
            get
            {
                //CUANDO UN USUARIO QUIERA EL VALOR, LE DEVOLVEMOS EL CAMPO
                return this._CampoEdad;
            }
            set
            {
                //CUANDO UN USUARIO QUIERA ESTABLECER UN VALOR, PRIMERO
                //COMPROBAMOS
                if (value < 0)
                {
                    //NO ME GUSTA, PUES LANZO UN ERROR DE PROGRAMA
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    //SI NOS GUSTA, ALMACENAMOS EL DATO EN EL CAMPO
                    this._CampoEdad = value;
                }
            }
        }
        #endregion

        #region METODOS
            //CREAMOS UN NUEVO METODO PARA DEVOLVER EL NOMBRE COMPLETO
            //DE UNA PERSONA
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        #endregion


    }
}
