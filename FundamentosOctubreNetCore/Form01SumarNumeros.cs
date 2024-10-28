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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS LOS DATOS DE CADA CAJA DE TEXTO EN UNA 
            //VARIABLE
            int numero1 = int.Parse(this.txtNumero1.Text);
            int numero2 = int.Parse(this.txtNumero2.Text);
            //DECLARAMOS UNA VARIABLE PARA ALMACENAR LA SUMA
            int suma = numero1 + numero2;
            //MOSTRAMOS EL RESULTADO EN EL LABEL DEL FORMULARIO
            this.lblResultado.Text = suma.ToString();
        }
    }
}
