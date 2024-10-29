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
            for (int i = 2; i <= 50; i+=2)
            {
                resultado += i + ",";
            }
            this.txtResultado.Text = resultado;
        }
    }
}
