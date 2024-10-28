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
    public partial class Form02PositivoNegativoCero : Form
    {
        public Form02PositivoNegativoCero()
        {
            InitializeComponent();
        }

        private void btnEvaluarNumero_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text != "")
            {
                //CAPTURAMOS EL NUMERO DE LA CAJA DE TEXTO
                int numero = int.Parse(this.txtNumero.Text);
                //DEBEMOS PREGUNTAS POR LAS DIFERENTES OPCIONES QUE 
                //TENEMOS EN EL PROGRAMA: POSITIVO, NEGATIVO O CERO
                if (numero > 0)
                {
                    this.lblResultado.Text = "POSITIVO";
                }
                else if (numero < 0)
                {
                    this.lblResultado.Text = "NEGATIVO";
                }
                else
                {
                    this.lblResultado.Text = "CERO";
                }
            }
            else
            {
                MessageBox.Show("Debe escribir un número");
            }
        }
    }
}
