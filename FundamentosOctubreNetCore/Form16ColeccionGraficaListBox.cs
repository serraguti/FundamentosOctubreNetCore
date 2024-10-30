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
    public partial class Form16ColeccionGraficaListBox : Form
    {
        public Form16ColeccionGraficaListBox()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elemento);
        }
    }
}
