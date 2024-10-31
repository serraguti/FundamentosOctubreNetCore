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
    public partial class Form19SumarBotonesNumeros : Form
    {
        public Form19SumarBotonesNumeros()
        {
            InitializeComponent();
            //RECORREMOS TODOS LOS CONTROLES DEL FORMULARIO MEDIANTE 
            //LA COLECCION CONTROLS
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    //ASOCIAMOS DINAMICAMENTE EL BOTON AL METODO DE EVENTO
                    c.Click += SumarNumeros;
                }
            }
        }

        //CREAMOS UN METODO DE EVENTO
        void SumarNumeros(object sender, EventArgs e)
        {
            //RECUPERAMOS EL TEXTO DEL LABEL PARA LA SUMA
            int suma = int.Parse(this.lblSuma.Text);
            //CAPTURAMOS EL BOTON QUE HA PULSADO EL USUARIO (sender)
            Button boton = (Button)sender;
            //RECUPERAMOS EL NUMERO DEL BOTON PULSADO
            int numero = int.Parse(boton.Text);
            //REALIZAMOS LA SUMA
            suma += numero;
            //DIBUJAMOS EN EL LABEL LA SUMA
            this.lblSuma.Text = suma.ToString();
        }
    }
}
