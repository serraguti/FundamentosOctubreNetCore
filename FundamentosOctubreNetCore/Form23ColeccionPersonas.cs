using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosOctubreNetCore
{
    public partial class Form23ColeccionPersonas : Form
    {
        List<Persona> coleccionPersonas;

        public Form23ColeccionPersonas()
        {
            InitializeComponent();
            this.coleccionPersonas = new List<Persona>();
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            //CADA VEZ QUE PULSEMOS EL BOTON, CREAMOS UNA NUEVA PERSONA
            Persona persona = new Persona();
            persona.Nombre = this.txtNombre.Text;
            persona.Apellidos = this.txtApellidos.Text;
            persona.Edad = int.Parse(this.txtEdad.Text);
            //ALMACENAMOS LA PERSONA EN LA COLECCION
            this.coleccionPersonas.Add(persona);
            this.lblMensaje.Text = "Número personas: " + this.coleccionPersonas.Count;
        }

        private void btnMostrarPersonas_Click(object sender, EventArgs e)
        {
            this.lstPersonas.Items.Clear();
            foreach (Persona persona in this.coleccionPersonas)
            {
                this.lstPersonas.Items.Add(persona.Nombre);
            }
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedIndex != -1)
            {
                //ENTRE TODAS LAS PERSONAS, NOS INTERESA EL INDICE
                //DE LA SELECCIONADA
                int indice = this.lstPersonas.SelectedIndex;
                //RECUPERAMOS LA PERSONA DE LA COLECCION 
                Persona persona = this.coleccionPersonas[indice];
                this.txtNombre.Text = persona.Nombre;
                this.txtApellidos.Text = persona.Apellidos;
                this.txtEdad.Text = persona.Edad.ToString();
            }
        }
    }
}
