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

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EL INDICE PUEDE CAMBIAR A -1 PORQUE ESTAMOS ELIMINANDO ELEMENTOS
            //DEBERIAMOS SIEMPRE PREGUNTAR SI TENEMOS ELEMENTOS SELECCIONADOS
            //EN ESTE EVENTO
            if (this.lstElementos.SelectedIndex != -1)
            {
                //TENEMOS UN ELEMENTO SELECCIONADO
                this.lblIndexSeleccionado.Text = "Indice: "
                    + this.lstElementos.SelectedIndex;
                this.lblItemSeleccionado.Text = "Item: "
                    + this.lstElementos.SelectedItem;
            }
        }

        private void btnRecorrerElementos_Click(object sender, EventArgs e)
        {
            //QUEREMOS RECORRER TODOS LOS ELEMENTOS DE LA COLECCION
            //DEL LISTBOX
            //DIBUJAMOS TODOS LOS ELEMENTOS EN UN string EN UN LABEL
            string data = "";
            //UTILIZAMOS UN BUCLE FOREACH DE REFERENCIA
            foreach (string elemento in this.lstElementos.Items)
            {
                data += elemento;
            }
            this.lblIndexSeleccionado.Text = data;
        }
    }
}
