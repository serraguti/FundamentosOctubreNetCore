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
    public partial class Form04MayorTresNumeros : Form
    {
        public Form04MayorTresNumeros()
        {
            InitializeComponent();
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.txtNumero1.Text);
            int numero2 = int.Parse(this.txtNumero2.Text);
            int numero3 = int.Parse(this.txtNumero3.Text);
            int mayor = 0;
            int menor = 0;
            int intermedio = 0;
            //DEBEMOS COMPARAR EL NUMERO 1 CON EL RESTO DE NUMEROS QUE TENGAMOS
            //VOY A UTILIZAR EN LA COMPARACION TAMBIEN SI SON IGUALES >=
            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
            }else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }
            //COMPARAMOS LOS NUMEROS ENTRE SI CON EL OPERANDO DE <=
            if (numero1 <= numero2 && numero1 <= numero3)
            {
                menor = numero1;
            }else if (numero2 <= numero1 && numero2 <= numero3)
            {
                menor = numero2;
            }
            else
            {
                menor = numero3;
            }
            //PARA EL INTERMEDIO, VAMOS A SUMAR TODOS LOS NUMEROS QUE TENEMOS
            int suma = numero1 + numero2 + numero3;
            //EL INTERMEDIO SERA LA SUMA MENOS EL MAYOR Y EL MENOR
            intermedio = suma - mayor - menor;
            this.lblMayor.Text = "Mayor: " + mayor;
            this.lblMenor.Text = "Menor: " + menor; 
            this.lblIntermedio.Text = "Intermedio " + intermedio;
        }
    }
}
