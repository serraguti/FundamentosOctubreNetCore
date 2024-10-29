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
    public partial class Form06DateTime : Form
    {
        public Form06DateTime()
        {
            InitializeComponent();
            //SIEMPRE ESCRIBIREMOS A PARTIR DE ESTA INSTRUCCION
            //NECESITAMOS RECUPERAR LA FECHA ACTUAL
            DateTime fechaActual = DateTime.Now;
            //DIBUJAMOS EN LA CAJA LA FECHA ACTUAL
            this.txtFechaActual.Text = fechaActual.ToString();
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            //NECESITAMOS CAPTURAR LA FECHA QUE TENEMOS EN LA CAJA
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            //EL CONTROL CHECKBOX TIENE UNA PROPIEDAD LLAMADA Checked 
            //QUE INDICA SI ESTA CHEQUEADO O NO
            if (this.chkFormato.Checked == true)
            {
                //DIBUJAMOS EN LA CAJA EL FORMATO DE FECHA LARGO
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                //DIBUJAMOS EN LA CAJA EL FORMATO DE FECHA CORTO
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            //CAPTURAMOS LA FECHA DE LA CAJA
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            //AÑADIMOS 5 DIAS A LA FECHA
            //AUNQUE APLIQUEMOS UN METODO A UN OBJETO, DICHO OBJETO NO CAMBIA
            //DE VALOR.  SOLAMENTE SI IGUALAMOS EL OBJETO, CAMBIARA DE VALOR
            //fecha = fecha.AddDays(5);
            //DIBUJAMOS EN LA CAJA INFERIOR EL NUEVO VALOR
            //CAPTURAMOS EL INCREMENTO DE LA CAJA DE TEXTO
            int incremento = int.Parse(this.txtIncremento.Text);
            //PREGUNTAMOS POR LOS RADIO BUTTONS
            if (this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }else if (this.rdbMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
            this.lblDayOfWeek.Text = fecha.DayOfWeek.ToString();
            this.lblDayOfYear.Text = fecha.DayOfYear.ToString();
        }
    }
}
