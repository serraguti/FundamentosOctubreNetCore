using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases;
using System.Xml.Serialization;
using System.Threading.Tasks.Sources;


namespace FundamentosOctubreNetCore
{
    public partial class Form26SerializarColeccion : Form
    {
        List<Mascota> coleccionMascotas;
        XmlSerializer serializer;

        public Form26SerializarColeccion()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas = new List<Mascota>();
        }

        //CREAMOS UN METODO PARA DIBUJAR LAS MASCOTAS EN LA LISTA
        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.coleccionMascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Anyos = int.Parse(this.txtEdad.Text);
            this.coleccionMascotas.Add(mascota);
            this.DibujarMascotas();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMascotas.SelectedIndex != -1)
            {
                int index = this.lstMascotas.SelectedIndex;
                Mascota mascota = this.coleccionMascotas[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Anyos.ToString();
            }
        }

        private async void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("listamascotas.xml"))
            {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();
            }
            this.coleccionMascotas.Clear();
            this.lstMascotas.Items.Clear();
        }

        private async void btnLeerDatos_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("listamascotas.xml"))
            {
                this.coleccionMascotas = (List<Mascota>)
                    this.serializer.Deserialize(reader);
                reader.Close();
                this.DibujarMascotas();
            }
        }
    }
}
