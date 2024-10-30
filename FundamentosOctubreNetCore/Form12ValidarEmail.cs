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
    public partial class Form12ValidarEmail : Form
    {
        public Form12ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidaremail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            //NECESITAMOS BUSCAR UNA @
            if (email.Contains("@") == false)
            {
                this.lblResultado.Text = "No existe @ en el mail";
            }else if (email.IndexOf(".") == -1)
            {
                this.lblResultado.Text = "Debe existir un punto";
            }else if (email.StartsWith("@") == true)
            {
                this.lblResultado.Text = "@ al inicio del mail";
            }else if (email.EndsWith("@") == true)
            {
                this.lblResultado.Text = "@ al final del email";
            }else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Existe más de una @ en el mail";
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Debemos tener un punto despues de la @";
            }
            else
            {
                //CAPTURAMOS LA POSICION DEL ULTIMO PUNTO
                int ultimoPunto = email.LastIndexOf(".");
                //DEBEMOS QUEDARNOS CON EL DOMINIO, PERO SIN EL PUNTO
                //email@dominio.com
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Mail correcto";
                }
                else
                {
                    this.lblResultado.Text = "El dominio debe ser de 2 a 4 caracteres";
                }
            }
        }
    }
}
