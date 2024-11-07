using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form10DepartamentosListView : Form
    {
        RepositoryDepartamentos repo;

        public Form10DepartamentosListView()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            //RECORREMOS TODOS LOS DEPARTAMENTOS PARA EL DIBUJO
            foreach (Departamento dept in departamentos)
            {
                //POR CADA DEPARTAMENTO, QUEREMOS UNA FILA EN EL DIBUJO
                ListViewItem item = new ListViewItem();
                //EN LA PRIMERA COLUMNA DIBUJAMOS EL NUMERO DEL DEPARTAMENTO
                item.Text = dept.IdDepartamento.ToString();
                //EL RESTO DE COLUMNAS EN EL ORDEN QUE HAYAMOS REALIZADO EL DIBUJO
                item.SubItems.Add(dept.Nombre);
                item.SubItems.Add(dept.Localidad);
                //AGREGAMOS CADA ITEM AL CONTROL LISTVIEW
                this.lsvDepartamentos.Items.Add(item);
            }
        }
    }
}
