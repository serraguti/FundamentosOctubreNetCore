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
    public partial class Form15Isbn : Form
    {
        public Form15Isbn()
        {
            InitializeComponent();
        }

        private void btnComprobarIsbn_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            if (isbn.Length != 10)
            {
                MessageBox.Show("El número ISBN debe tener 10 caracteres");
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int operacion = numero * (i + 1);
                    suma += operacion;
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "ISBN correcto";
                }
                else
                {
                    this.lblResultado.Text = "El número introducido no es ISBN correcto";
                }
            }
        }
    }
}
