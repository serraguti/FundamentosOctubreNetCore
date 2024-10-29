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
    public partial class Form05DiaNacimiento : Form
    {
        public Form05DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDiaNacimiento_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            //15/06/1997
            if (mes == 1)
            {
                mes = 13;
                anyo = anyo - 1;
            }else if (mes == 2)
            {
                mes = 14;
                anyo = anyo - 1;
            }
            //COMENZAMOS A REALIZAR LAS OPERACIONES MATEMATICAS
            //Multiplicar el Mes más 1 por 3 y dividirlo entre 5
            int op1 = ((mes + 1) * 3) / 5;
            //Dividir el año entre 4
            int op2 = anyo / 4;
            //Dividir el año entre 100
            int op3 = anyo / 100;
            //Dividir el año entre 400
            int op4 = anyo / 400;
            //Sumar el día, el doble del mes, el año, el resultado de la operación 1
            //, el resultado de la operación 2, menos el resultado de la operación 3
            //más la operación 4 más 2.
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            //Dividir el resultado anterior entre 7.
            int op6 = op5 / 7;
            //Restar el número del paso 5 con el número del paso 6 por 7.
            int resultado = op5 - (op6 * 7);
            if (resultado == 0)
            {
                this.lblDiaSemana.Text = "SABADO";
            }else if (resultado == 1)
            {
                this.lblDiaSemana.Text = "DOMINGO";
            }else if (resultado == 2)
            {
                this.lblDiaSemana.Text = "LUNES";
            }else if (resultado == 3)
            {
                this.lblDiaSemana.Text = "MARTES";
            }else if (resultado == 4)
            {
                this.lblDiaSemana.Text = "MIERCOLES";
            }else if (resultado == 5)
            {
                this.lblDiaSemana.Text = "JUEVES";
            }else if (resultado == 6)
            {
                this.lblDiaSemana.Text = "VIERNES";
            }
            else
            {
                this.lblDiaSemana.Text = "Tenemos un error, Houston";
            }
        }
    }
}
