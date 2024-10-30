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
    public partial class Form11ClaseChar : Form
    {
        public Form11ClaseChar()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //RECORREMOS TODOS LOS CARACTERES ASCII DE 0 - 255
            for (int i = 0; i <= 255; i++)
            {
                //CONVERTIMOS CADA POSICION i DEL BUCLE 
                //EN CARACTER
                char caracter = (char)i;
                //PREGUNTAR POR CADA VALOR DEL CARACTER
                if (char.IsLetter(caracter) == true)
                {
                    this.txtLetras.Text += caracter;
                }
                else if (char.IsNumber(caracter) == true)
                {
                    this.txtNumeros.Text += caracter;
                }
                else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += caracter;
                }
                else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
