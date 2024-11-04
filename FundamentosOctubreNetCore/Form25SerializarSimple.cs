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
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks.Sources;

namespace FundamentosOctubreNetCore
{
    public partial class Form25SerializarSimple : Form
    {
        //NECESITAMOS UN OBJETO PARA REALIZAR LA SERIALIZACION
        XmlSerializer serializer;

        public Form25SerializarSimple()
        {
            InitializeComponent();
            //CADA OBJETO SERIALIZER ESTA ESPECIALIZADO EN UNA CLASE DETERMINADA
            //DEBEMOS INDICAR LA CLASE QUE ALMACENAREMOS EN SU INTERIOR
            //PARA INDICAR LA CLASE QUE VAMOS A ALMACENAR SE UTILIZA LA SINTAXIS
            // typeof(CLASE)
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            //CREAMOS UN NUEVO OBJETO MASCOTA
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Anyos = int.Parse(this.txtEdad.Text);
            //DEBEMOS ALMACENAR LA INFORMACION EN UN FICHERO FISICO CON 
            //FORMATO XML.  PARA ELLO, SE UTILIZA LA CLASE StreamWriter
            //SI NO LE DECIMOS RUTA, LO ALMACENA DONDE TENGAMOS EL PROYECTO
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                //DEBEMOS SERIALIZAR EL OBJETO MASCOTA CON UN METODO
                //LLAMADO Serialize
                this.serializer.Serialize(writer, mascota);
                //COMO ESTAMOS ESCRIBIENDO EN UN FICHERO, UTILIZAMOS Flush
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }

        private async void btnLeerMascota_Click(object sender, EventArgs e)
        {
            //PARA LEER EL FICHERO, UTILIZAMOS StreamReader
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                //DENTRO DEL FICHERO, TENEMOS UN XML QUE REPRESENTA LA MASCOTA
                //MEDIANTE EL METODO Deserialize, EL PROPIO LENGUAJE YA SABE INTERPRETAR
                //Y RECONOCER EL OBJETO
                Mascota mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtRaza.Text = mascota.Raza;
                this.txtNombre.Text = mascota.Nombre;
                this.txtEdad.Text = mascota.Anyos.ToString();
            }
        }
    }
}
