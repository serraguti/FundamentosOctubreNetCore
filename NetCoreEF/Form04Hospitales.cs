using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Models;
using NetCoreEF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreEF
{
    public partial class Form04Hospitales : Form
    {
        RepositoryHospital repo;

        public Form04Hospitales()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryHospital>();
        }

        private void btnCargarHospitales_Click(object sender, EventArgs e)
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lsvHospitales.Items.Clear();
            foreach (Hospital h in hospitales)
            {
                ListViewItem item = new ListViewItem();
                item.Text = h.IdHospital.ToString();
                item.SubItems.Add(h.Nombre);
                item.SubItems.Add(h.Direccion);
                item.SubItems.Add(h.Telefono);
                item.SubItems.Add(h.Camas.ToString());
                this.lsvHospitales.Items.Add(item);
            }
        }

        private void lsvHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvHospitales.SelectedItems.Count != 0)
            {
                ListViewItem itemSeleccionado = this.lsvHospitales.SelectedItems[0];
                int idhospital = int.Parse(itemSeleccionado.Text);
                Hospital hospital = this.repo.FindHospital(idhospital);
                this.txtNombre.Text = hospital.Nombre;
                this.txtDireccion.Text = hospital.Direccion;
                this.txtCamas.Text = hospital.Camas.ToString();
            }
        }
    }
}
