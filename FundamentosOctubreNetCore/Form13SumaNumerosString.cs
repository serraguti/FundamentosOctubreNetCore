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
    public partial class Form13SumaNumerosString : Form
    {
        public Form13SumaNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            //1234
            //DECLARAMOS LA SUMA
            //TODA VARIABLE DEBE SER INICIALIZADA/INSTANCIADA
            int suma = 0;
            //RECORREMOS LA LONGITUD DEL TEXTO
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                //CAPTURAMOS CADA CARACTER DEL TEXTO EN SU POSICION i
                char caracter = textoNumeros[i];
                //CONVERTIMOS CADA CARACTER A NUMERO (conversion explicita)
                int numero = int.Parse(caracter.ToString());
                //INCREMENTAMOS LA SUMA CON CADA NUMERO
                suma += numero;
            }
            this.lblResultado.Text = "La suma de " + textoNumeros 
                + " es " + suma.ToString();
        }
    }
}
