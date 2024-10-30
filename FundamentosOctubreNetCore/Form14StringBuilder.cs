using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Text;

namespace FundamentosOctubreNetCore
{
    public partial class Form14StringBuilder : Form
    {
        public Form14StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            //NECESITAMOS UN CRONOMETRO PARA MEDIR EL TIEMPO
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            //INICIAMOS EL CRONOMETRO
            krono.Start();
            for (int i = 0; i < cadena.Length; i++)
            {
                //HOLA
                //RECUPERAMOS LA ULTIMA LETRA DEL TEXTO
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA DEL TEXTO
                //HOL
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS EN LA CADENA EN LA POSICION DEL BUCLE i
                //AHOL
                cadena = cadena.Insert(i, letra.ToString());         
            }
            //DETENEMOS EL CRONOMETRO 
            krono.Stop();
            //TIENE UN PAR DE PROPIEDADES DE TIPO TIME QUE NOS DICEN 
            //EL TIEMPO QUE HA TARDADO EN SEGUNDOS...
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds
                + ", Milisegundos: " + krono.ElapsedMilliseconds;
            this.txtTexto.Text = cadena;
        }
    }
}
