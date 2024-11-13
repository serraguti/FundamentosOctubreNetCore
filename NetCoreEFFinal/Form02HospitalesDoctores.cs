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

namespace NetCoreEFFinal
{
    public partial class Form02HospitalesDoctores : Form
    {
        RepositoryHospitales repo;
        public Form02HospitalesDoctores()
        {
            InitializeComponent();
            this.repo = Program.Provider.GetService<RepositoryHospitales>();
            this.CargarHospitalesAsync();
        }

        private async Task CargarHospitalesAsync()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hospital in hospitales)
            {
                this.lstHospitales.Items.Add(hospital.IdHospital);
            }
        }

        private async Task CargarDoctoresHospitalAsync(int idhospital)
        {
            List<Doctor> doctores = await this.repo.GetDoctoresHospitalAsync(idhospital);
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

        private async void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstHospitales.SelectedIndex != -1)
            {
                int idhospital = int.Parse(this.lstHospitales.SelectedItem.ToString());
                await this.CargarDoctoresHospitalAsync(idhospital);
            }
        }

        private async void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            int idhospital = int.Parse(this.lstHospitales.SelectedItem.ToString());
            int incremento = int.Parse(this.txtIncrementoSalarial.Text);
            await this.repo.IncrementarSalarioDoctoresHospitalAsync(idhospital, incremento);
            await this.CargarDoctoresHospitalAsync(idhospital);
        }
    }
}
