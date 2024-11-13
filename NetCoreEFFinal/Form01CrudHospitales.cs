using Microsoft.Extensions.DependencyInjection;
using NetCoreEFFinal.Models;
using NetCoreEFFinal.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetCoreEFFinal
{
    public partial class Form01CrudHospitales : Form
    {
        RepositoryHospitales repo;

        public Form01CrudHospitales()
        {
            InitializeComponent();
            this.repo = Program.Provider.GetService<RepositoryHospitales>();
            this.CargarHospitalesAsync();
        }

        //NECESITAMOS UN METODO ASINCRONO PARA CARGAR LOS HOSPITALES
        public async Task CargarHospitalesAsync()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            this.lsvHospitales.Items.Clear();
            foreach (Hospital hospital in hospitales)
            {
                ListViewItem item = new ListViewItem();
                item.Text = hospital.IdHospital.ToString();
                item.SubItems.Add(hospital.Nombre);
                item.SubItems.Add(hospital.Direccion);
                item.SubItems.Add(hospital.Telefono);
                item.SubItems.Add(hospital.Camas.ToString());
                this.lsvHospitales.Items.Add(item);
            }
        }


        private async void lsvHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvHospitales.SelectedItems.Count != 0)
            {
                ListViewItem item = this.lsvHospitales.SelectedItems[0];
                int idhospital = int.Parse(item.Text);
                Hospital hospital = await this.repo.FindHospitalAsync(idhospital);
                this.txtIdHospital.Text = hospital.IdHospital.ToString();
                this.txtNombre.Text = hospital.Nombre;
                this.txtDireccion.Text = hospital.Direccion;
                this.txtTelefono.Text = hospital.Telefono;
                this.txtCamas.Text = hospital.Camas.ToString();
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int idhospital = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repo.InsertarHospitalAsync(idhospital, nombre, direccion, telefono, camas);
            await this.CargarHospitalesAsync();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int idhospital = int.Parse(this.txtIdHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repo.ModificarHospitalAsync(idhospital, nombre, direccion, telefono, camas);
            await this.CargarHospitalesAsync();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int idhospital = int.Parse(this.txtIdHospital.Text);
            await this.repo.EliminarHospitalAsync(idhospital);
            await this.CargarHospitalesAsync();
        }
    }
}
