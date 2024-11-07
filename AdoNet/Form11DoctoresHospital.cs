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
            if (this.lsvDoctores.SelectedItems.Count != 0)
            {
                //RECUPERAMOS EL ID DEL HOSPITAL (Item seleccionado Text)
                ListViewItem itemSeleccionado = this.lsvDoctores.SelectedItems[0];
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
    }
}
