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
    public partial class Form17SumarNumerosListBox : Form
    {
        public Form17SumarNumerosListBox()
        {
            InitializeComponent();
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.lstNumeros.Items.Add(numero);
            this.txtNumero.Focus();
            this.txtNumero.SelectAll();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            int sumaPares = 0;
            int sumaImpares = 0;
            int sumaTotal = 0;
            //RECORREMOS CON UN BUCLE FOREACH TODOS LOS NUMEROS
            //int QUE CONTIENE LA COLECCION GRAFICA
            foreach (int numero in this.lstNumeros.Items)
            {
                sumaTotal += numero;
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }
            this.txtSumaImpares.Text = sumaImpares.ToString();
            this.txtSumaPares.Text = sumaPares.ToString();
            this.txtSumaTotal.Text = sumaTotal.ToString();
        }
    }
}
