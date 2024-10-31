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
    public partial class Form18EventosMetodos : Form
    {
        public Form18EventosMetodos()
        {
            InitializeComponent();
            //ASOCIAMOS EL CLICK DE CADA BOTON A EL METODO
            //DE EVENTO BotonPulsado
            this.button1.Click += BotonPulsado;
            this.button2.Click += BotonPulsado;
            this.button3.Click += BotonPulsado;
        }

        //VAMOS A CREAR UN METODO PROPIO DE EVENTO PARA QUE LOS 
        //TRES BOTONES LO LEAN AL SER PULSADOS
        void BotonPulsado(object sender, EventArgs e)
        {
            //Y SI NECESITAMOS SABER QUE BOTON HEMOS PULSADO?
            //QUIERO DIFERENCIAR EL BOTON PULSADO
            //LA SOLUCION ESTA EN sender
            //sender ES EL CONTROL QUE HA REALIZADO LA LLAMADA
            //EN ESTE EJEMPLO, TODOS SON BOTONES
            //CAPTURAMOS EL BOTON PULSADO
            Button boton = (Button)sender;
            boton.BackColor = Color.Yellow;
            //MessageBox.Show("Pulsado");
        }

        private void lblRaton_Click(object sender, EventArgs e)
        {

        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloLetras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar: ES EL CARACTER QUE SE HA PULSADO
            //e.Handled = true; SE ENCARGA DE MANEJAR DE FORMA MANUAL EL EVENTO
            //DICHO DE OTRA FORMA, ME DEJA HACERLO A MI.
            //TENGO ALGUNA FORMA MILAGROSA DE SABER SI UN CARACTER ES LETRA O NO???
            // char.IsLetter()
            //A LO MEJOR, DESEAMOS DEJAR MAS CARACTERES, POR EJEMPLO, ESPACIOS
            //QUE SUCEDE SI NECESITAMOS CARACTERES ESPECIALES QUE NO PUEDO ESCRIBIR
            //POR EJEMPLO, LA TECLA DE BORRAR (BACK)
            //TENEMOS UNA ENUMERACION QUE SE LLAMA Keys Y NOS OFRECE LOS CODIGOS ASCII
            //DE TODAS LAS TECLAS
            //PODEMOS CONVERTIR EL CODIGO ASCII A CHAR Y PREGUNTAR POR UNA TECLA ESPECIAL
            //COMO UN ENTER O UN BACK POR EJEMPLO
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
