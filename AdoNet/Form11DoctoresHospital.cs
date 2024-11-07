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
    public partial class Form11DoctoresHospital : Form
    {
        RepositoryHospital repo;

        public Form11DoctoresHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lsvHospitales.Items.Clear();
            foreach (Hospital h in hospitales)
            {
                //POR CADA FILA, CREAMOS UN NUEVO ListViewItem
                ListViewItem item = new ListViewItem();
                item.Text = h.IdHospital.ToString();
                item.SubItems.Add(h.Nombre);
                item.SubItems.Add(h.Direccion);
                item.SubItems.Add(h.Telefono);
                item.SubItems.Add(h.Camas.ToString());
                //AGREGAMOS EL ITEM AL CONTROL LISTVIEW
                this.lsvHospitales.Items.Add(item);
            }
        }
    }
}
