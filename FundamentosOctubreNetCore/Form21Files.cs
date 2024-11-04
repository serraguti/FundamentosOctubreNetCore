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

namespace FundamentosOctubreNetCore
{
    public partial class Form21Files : Form
    {
        string rutaFichero;

        public Form21Files()
        {
            InitializeComponent();
            //TENEMOS DOS FORMAS DE ESCRIBIR UNA RUTA DENTRO DEL PROGRAMA
            //LA RUTA A MI FICHERO ESTARA EN Documents. C:\Users\Serra\Documents
            //EN C# LA CONTRABARRA INDICA UN CARACTER ESPECIAL DEL LENGUAJE
            //POR EJEMPLO, UN ENTER \n O UN TABULADOR \t
            //1) UTILIZAMOS DOBLE CONTRABARRA PARA LAS RUTAS
            //this.rutaFichero = "C:\\Users\\Serra\\Documents\\test.txt";
            //2) UTILIZAMOS @ ANTES DEL STRING PARA QUE SEA LITERAL
            this.rutaFichero = @"C:\Users\Serra\Documents\test.txt";
        }

        //DEBEMOS UTILIZAR OPERACIONES ASINCRONAS
        private async void btnLeerFichero_Click(object sender, EventArgs e)
        {
            //VAMOS A UTILIZAR LA RUTA QUE TENEMOS A NIVEL DE CLASE
            FileInfo file = new FileInfo(this.rutaFichero);
            //CON LA CLASE TEXTREADER INDICAMOS QUE VAMOS A LEER UN FICHERO
            //DE TEXTO PLANO
            //AL CREAR EL OBJETO, DEBEMOS ASEGURARNOS QUE LO HA CREADO
            //ANTES DE UTILIZARLO
            using (TextReader reader = file.OpenText())
            {
                //AQUI EL OBJETO ESTARA 100% DISPONIBLE
                //SI TENEMOS METODOS ASINCRONOS, DEBEMOS UTILIZARLOS
                //LOS METODOS ASYNC FINALIZAN CON DICHA PALABRA
                //LA LLAMADA SE REALIZA CON await
                string contenido = await reader.ReadToEndAsync();
                //CERRAMOS EL FICHERO (SIEMPRE)
                reader.Close();
                this.txtContenido.Text = contenido;
            }
        }

        private async void btnGuardarFichero_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.rutaFichero);
            using (TextWriter writer = file.CreateText())
            {
                //RECUPERAMOS EL CONTENIDO ESCRITO EN LA CAJA
                string contenido = this.txtContenido.Text;
                //ESCRIBIMOS EL CONTENIDO EN EL FICHERO
                await writer.WriteAsync(contenido);
                //SIEMPRE QUE TRABAJEMOS CON FICHEROS, TENEMOS 
                //QUE APLICAR UN METODO LLAMADO Flush PARA LIBERAR LA MEMORIA
                await writer.FlushAsync();
                //CERRAMOS EL FICHERO
                writer.Close();
                this.txtContenido.Text = "";
                MessageBox.Show("Texto guardado");
            }
        }
    }
}
