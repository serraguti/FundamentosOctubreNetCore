using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosOctubreNetCore
{
    public partial class Form22ColeccionesNoGraficas : Form
    {
        List<string> coleccionNombres;

        public Form22ColeccionesNoGraficas()
        {
            InitializeComponent();
            //EN EL CONSTRUCTOR ES DONDE CREAMOS LOS OBJETOS DE LA CLASE
            this.coleccionNombres = new List<string>();
        }

        private void btnGuardarNombre_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNuevoNombre.Text;
            //ALMACENAMOS EL NOMBRE DENTRO DE LA COLECCION NO GRAFICA
            this.coleccionNombres.Add(nombre);
            this.lblMensaje.Text = "Nombres almacenados: " + this.coleccionNombres.Count;
            this.txtNuevoNombre.Text = "";
        }

        private void btnMostrarNombres_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Clear();
            foreach (string nombre in this.coleccionNombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }
    }
}
