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
    public partial class Form08NumerosPares : Form
    {
        public Form08NumerosPares()
        {
            InitializeComponent();
        }

        private void btnNumerosPares_Click(object sender, EventArgs e)
        {
            //DECLARAMOS UNA VARIABLE PARA MOSTRAR EL RESULTADO DE LOS PARES
            string resultado = "";
            for (int i = 1; i <= 50; i++)
            {
                //DEBEMOS AVERIGUAR SI EL NUMERO ES PAR
                //PREGUNTAMOS SI SU RESTO ENTRE 2 ES CERO
                if (i % 2 == 0)
                {
                    //PARES
                    resultado += i + ", ";
                }
            }
            this.txtResultado.Text = resultado;
        }
    }
}
