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
    public partial class Form03NumerosMayorMenor : Form
    {
        public Form03NumerosMayorMenor()
        {
            InitializeComponent();
        }

        private void btnMostrarMayor_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.txtNumero1.Text);
            int numero2 = int.Parse(this.txtNumero2.Text);
            //DECLARAMOS UNA VARIABLE PARA SABER EL NUMERO MAYOR
            int mayor = 0;
            if (numero1 > numero2)
            {
                mayor = numero1;
            }
            else
            {
                mayor = numero2;
            }
            this.lblResultado.Text = "El número mayor es " + mayor;
        }
    }
}
