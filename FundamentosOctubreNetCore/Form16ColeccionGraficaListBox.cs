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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //PARA ELIMINAR UN ELEMENTO DE UNA COLECCION, TENEMOS 2 OPCIONES
            //1) BORRAR POR EL OBJETO.  SI TENEMOS REPETIDOS, SE COMPORTA RARO
            //2) BORRAR POR EL INDICE/POSICION
            //PRIMERO VAMOS A BORRAR POR EL OBJETO DE LA COLECCION
            //RECUPERAMOS EL ELEMENTO SELECCIONADO DE LA COLECCION
            //string elementoSeleccionado = this.lstElementos.SelectedItem.ToString();
            ////ELIMINAMOS EL OBJETO DE LA COLECCION (Remove(elemento))
            //this.lstElementos.Items.Remove(elementoSeleccionado);
            //RECUPERAMOS EL INDICE DEL ELEMENTO SELECCIONADO
            int indiceSeleccionado = this.lstElementos.SelectedIndex;
            //ELIMINAMOS POR INDICE (RemoveAt(indice))
            this.lstElementos.Items.RemoveAt(indiceSeleccionado);
        }
    }
}
