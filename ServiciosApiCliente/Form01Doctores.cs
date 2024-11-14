using ServiciosApiCliente.Models;
using ServiciosApiCliente.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciosApiCliente
{
    public partial class Form01Doctores : Form
    {
        ServiceDoctores service;

        public Form01Doctores()
        {
            InitializeComponent();
            this.service = new ServiceDoctores();
            this.CargarDoctoresAsync();
        }

        private async Task CargarDoctoresAsync()
        {
            List<Doctor> doctores = await this.service.GetDoctoresAsync();
            this.lsvDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                ListViewItem item = new ListViewItem();
                item.Text = doc.IdDoctor.ToString();
                item.SubItems.Add(doc.Apellido);
                item.SubItems.Add(doc.Especialidad);
                item.SubItems.Add(doc.Salario.ToString());
                item.SubItems.Add(doc.IdHospital.ToString());
                this.lsvDoctores.Items.Add(item);
            }
        }

        private async void lsvDoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvDoctores.SelectedItems.Count != 0)
            {
                ListViewItem itemSeleccionado = this.lsvDoctores.SelectedItems[0];
                int iddoctor = int.Parse(itemSeleccionado.Text);
                Doctor doctor = await this.service.FindDoctorAsync(iddoctor);
                this.txtIdDoctor.Text = iddoctor.ToString();
                this.txtApellido.Text = doctor.Apellido;
                this.txtEspecialidad.Text = doctor.Especialidad;
                this.txtSalario.Text = doctor.Salario.ToString();
                this.txtHospital.Text = doctor.IdHospital.ToString();
            }
        }
    }
}
