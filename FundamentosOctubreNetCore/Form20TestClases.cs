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
            persona.Edad = -28;
            this.lstPropiedades.Items.Add(persona.Nombre + " "
                + persona.Apellidos + " " + persona.Edad);
        }
    }
}
