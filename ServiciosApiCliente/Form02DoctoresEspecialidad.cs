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
    public partial class Form02DoctoresEspecialidad : Form
    {
        ServiceDoctores service;

        public Form02DoctoresEspecialidad()
        {
            InitializeComponent();
            this.service = new ServiceDoctores();
            this.CargarEspecialidades();
        }

        private async Task CargarEspecialidades()
        {
            List<string> especialidades = await this.service.GetEspecialidadesAsync();
            this.lstEspecialidades.Items.Clear();
            foreach (string especialidad in especialidades)
            {
                this.lstEspecialidades.Items.Add(especialidad);
            }
        }

        private async void lstEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEspecialidades.SelectedIndex != -1)
            {
                string especialidad = this.lstEspecialidades.SelectedItem.ToString();
                List<Doctor> doctores = await this.service.GetDoctoresEspecialidadAsync(especialidad);
                this.lsvDoctores.Items.Clear();
                foreach (Doctor doc in doctores)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = doc.Apellido;
                    item.SubItems.Add(doc.Especialidad);
                    item.SubItems.Add(doc.Salario.ToString());
                    this.lsvDoctores.Items.Add(item);
                }
            }
        }
    }
}
