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

        private void lsvHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EN UN EVENTO DE UN LISTVIEW, SIEMPRE DEBEMOS PREGUNTAR SI 
            //TENEMOS ALGO SELECCIONADO
            if (this.lsvHospitales.SelectedItems.Count != 0)
            {
                //RECUPERAMOS EL ID DEL HOSPITAL (Item seleccionado Text)
                ListViewItem itemSeleccionado = this.lsvHospitales.SelectedItems[0];
                //RECUPERAMOS EL CODIGO DEL HOSPITAL
                int idhospital = int.Parse(itemSeleccionado.Text);
                //CARGAMOS LOS DOCTORES
                this.CargarDoctores(idhospital);
            }
        }

        //METODO PARA CARGAR LOS DOCTORES DE UN HOSPITAL
        private void CargarDoctores(int idhospital)
        {
            List<Doctor> doctores = this.repo.GetDoctoresHospital(idhospital);
            this.lsvDoctores.Items.Clear();
            foreach (Doctor doc in doctores)
            {
                //CREAMOS UN LISTVIEWITEM POR CADA DOCTOR
                ListViewItem item = new ListViewItem();
                item.Text = doc.IdDoctor.ToString();
                item.SubItems.Add(doc.Apellido);
                item.SubItems.Add(doc.Especialidad);
                item.SubItems.Add(doc.Salario.ToString());
                item.SubItems.Add(doc.IdHospital.ToString());
                //AGREGAMOS EL ITEM AL DIBUJO DEL LISTVIEW
                this.lsvDoctores.Items.Add(item);
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            //HOSPITAL SELECCIONADO EN EL LISTVIEW
            ListViewItem itemSeleccionado = this.lsvHospitales.SelectedItems[0];
            //RECUPERAMOS EL ID DEL HOSPITAL QUE EL TEXT
            int idhospital = int.Parse(itemSeleccionado.Text);
            int incremento = int.Parse(this.txtIncrementoSalarial.Text);
            //LLAMAMOS AL REPOSITORIO E INCREMENTAMOS
            int registros = this.repo.IncrementarSalarioDoctores(incremento, idhospital);
            //RECARGAMOS LA LISTA DE LOS DOCTORES
            this.CargarDoctores(idhospital);
            MessageBox.Show("Doctores modificados " + registros);
        }

        private void btnModificarEspecialidad_Click(object sender, EventArgs e)
        {
            //NECESITAMOS EL ITEM SELECCIONADO DEL DOCTOR
            ListViewItem itemDoctorSeleccionado = this.lsvDoctores.SelectedItems[0];
            //RECUPERAMOS EL ID DEL DOCTOR
            int iddoctor = int.Parse(itemDoctorSeleccionado.Text);
            //RECUPERAMOS LA NUEVA ESPECIALIDAD
            string especialidad = this.txtNuevaEspecialidad.Text;
            this.repo.ModificarEspecialidadDoctor(especialidad, iddoctor);
            //DEBEMOS RECARGAR EL DIBUJO, PARA ELLO, RECUPERAMOS EL ITEM SELECCIONADO DEL HOSPITAL
            ListViewItem itemHospitalSeleccionado = this.lsvHospitales.SelectedItems[0];
            int idhospital = int.Parse(itemHospitalSeleccionado.Text);
            this.CargarDoctores(idhospital);
        }
    }
}
