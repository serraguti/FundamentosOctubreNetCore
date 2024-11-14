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
    }
}
