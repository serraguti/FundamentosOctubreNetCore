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
            }
            else
            {
                this.lblResultado.Text = "Mail correcto";
            }
            //VUESTROS IF A PARTIR DE AQUI
        }
    }
}
