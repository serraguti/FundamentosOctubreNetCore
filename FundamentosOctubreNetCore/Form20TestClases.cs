using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PARA UTILIZAR UNA PERSONA, NECESITAMOS LA LIBRERIA DEL PROYECTO
//Y SU NAMESPACE
using ProyectoClases;

namespace FundamentosOctubreNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Andres";
            persona.Apellidos = "Leon";
            persona.Edad = 28;
            persona.Nacionalidad = Paises.Suiza;
            this.lstPropiedades.Items.Add(persona.GetNombreCompleto());
            this.lstPropiedades.Items.Add(persona.GetNombreCompleto(true));
            this.lstPropiedades.Items.Add(persona.GetNombreCompleto(8899));
            this.lstPropiedades.Items.Add(persona.Nombre + " "
                + persona.Apellidos + " " + persona.Edad);
        }
    }
}
