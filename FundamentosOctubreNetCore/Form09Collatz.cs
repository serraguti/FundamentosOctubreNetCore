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
    public partial class Form09Collatz : Form
    {
        public Form09Collatz()
        {
            InitializeComponent();
        }

        private void btnCollatz_Click(object sender, EventArgs e)
        {
            string resultado = "";
            //NECESITAMOS EL NUMERO INICIAL
            int numero = int.Parse(this.txtNumero.Text);
            //NUESTRA CONDICION SERA QUE MIENTRAS QUE NUMERO NO SEA 1
            while (numero != 1)
            {
                //COMPROBAMOS SI EL NUMERO ES PAR
                if (numero % 2 == 0)
                {
                    //PAR
                    numero = numero / 2;
                }
                else
                {
                    //IMPAR
                    numero = numero * 3 + 1;
                }
                resultado += numero + ", ";
            }
            this.txtResultado.Text = resultado;
        }
    }
}
