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
    public partial class Form10PracticasBucles : Form
    {
        public Form10PracticasBucles()
        {
            InitializeComponent();
        }

        private void btnTablaMultiplicar_Click(object sender, EventArgs e)
        {
            //PODEMOS COMPROBAR SI LA CAJA DE TEXTO ESTA VACIA O NO
            if (this.txtNumero.Text == "")
            {
                MessageBox.Show("El número no puede estar vacío");
            }
            else
            {
                //RECUPERAMOS EL TEXTO DE LA CAJA
                string textoCaja = this.txtNumero.Text;
                //DECLARAMOS EL NUMERO PARA LA CAJA
                int numero;
                //MEDIANTE TRYPARSE, PREGUNTAMOS SI PUEDE HACER LA CONVERSION O NO
                if (int.TryParse(textoCaja, out numero))
                {
                    string resultado = "";
                    //REALIZAMOS UN BUCLE DE 1 A 10
                    for (int i = 1; i <= 10; i++)
                    {
                        int operacion = numero * i;
                        resultado += operacion + ", ";
                    }
                    this.txtResultado.Text = resultado;
                }
                else
                {
                    MessageBox.Show("Solo números en la caja");
                }
            }
        }

        private void btnNumerosImpares_Click(object sender, EventArgs e)
        {
            int inicio = int.Parse(this.txtInicio.Text);
            int fin = int.Parse(this.txtFin.Text);
            if (inicio > fin)
            {
                MessageBox.Show("El inicio debe ser inferior al final.");
            }
            else
            {
                //QUEREMOS LOS NUMEROS IMPARES
                //VAMOS A PREGUNTAR SI EL NUMERO DE INICIO ES PAR
                if (inicio % 2 == 0)
                {
                    //EL INICIO ES PAR
                    //LE SUMAMOS UNO PARA QUE SEA IMPAR
                    inicio += 1;
                }
                //YA SABEMOS QUE ES IMPAR, PUES REALIZAMOS UN BUCLE DESDE EL INICIO
                //Y CON UN INCREMENTO DE 2 EN 2.
                string resultado = "";
                for (int i = inicio; i <= fin; i += 2)
                {
                    resultado += i + ", ";
                }
                this.txtResultado.Text = resultado;
            }
        }
    }
}
