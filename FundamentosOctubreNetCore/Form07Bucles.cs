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
    public partial class Form07Bucles : Form
    {
        public Form07Bucles()
        {
            InitializeComponent();
        }

        private void btnEjemploFor_Click(object sender, EventArgs e)
        {
            //EN UN BUCLE FOR, DEBEMOS INDICAR UNA VARIABLE QUE SERA 
            //EL INICIO.  DICHA VARIABLE, SOLAMENTE LA PODEMOS UTILIZAR
            //DENTRO DEL BUCLE { ... }
            //HACEMOS UN BUCLE DE 1 A 7

            //for (int i = 1; i <= 7; i++)
            //{
            //    resultado = resultado + i + ", ";
            //    //resultado += i + ", ";
            //}
            string resultado = "";
            for (int i = 50; i >= 1; i--)
            {
                resultado += i + ", ";
            }
            this.txtResultado.Text = resultado;
        }

        private void btnEjemploWhile_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int contador = 1;
            while (contador <= 7)
            {
                resultado += contador + ", ";
                //DEBEMOS HACER QUE SALGA DEL BUCLE ALGUNA VEZ
                contador += 1;
            }
            this.txtResultado.Text = resultado;
            //PODEMOS REALIZAR LO MISMO EN UN BUCLE WHILE QUE EN UN FOR
            //POR EJEMPLO, EL CODIGO QUE HEMOS UTILIZADO DE 1 - 7
            //LOS BUCLES WHILE FUNCIONAN CON UNA CONDICION
            //NECESITAMOS "ALGO" QUE INDIQUE NUESTRA CONDICION
            //Y, DENTRO DEL BUCLE, DEBEMOS CAMBIAR DICHA CONDICION


            //bool respuesta = true;
            //while (respuesta == true)
            //{
            //    //SE VA A QUEDAR AQUI DENTRO
            //    this.txtResultado.AppendText("@");
            //    //DEBEMOS CAMBIAR LA CONDICION 
            //    //SI LA LONGITUD DEL TEXTO DE LA CAJA LLEGA A 100
            //    //DENTRO DE .Text DE UNA CAJA TENEMOS UNA PROPIEDAD LLAMADA 
            //    //.TextLength QUE NOS INDICA LA LONGITUD DE UN TEXTO
            //    int longitud = this.txtResultado.TextLength;
            //    if (longitud == 100)
            //    {
            //        respuesta = false;
            //    }
            //}
        }
    }
}
