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
    public partial class Form13EliminarEnfermos : Form
    {
        RepositoryEnfermos repo;

        public Form13EliminarEnfermos()
        {
            InitializeComponent();
            this.repo = new RepositoryEnfermos();
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            this.lsvEnfermos.Items.Clear();
            foreach (Enfermo enfermo in enfermos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = enfermo.Inscripcion.ToString();
                item.SubItems.Add(enfermo.Apellido);
                item.SubItems.Add(enfermo.Direccion);
                item.SubItems.Add(enfermo.FechaNacimiento.ToShortDateString());
                item.SubItems.Add(enfermo.Sexo);
                item.SubItems.Add(enfermo.Nss.ToString());
                this.lsvEnfermos.Items.Add(item);
            }
        }

        private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            ListViewItem itemSeleccionado = this.lsvEnfermos.SelectedItems[0];
            int inscripcion = int.Parse(itemSeleccionado.Text);
            this.repo.EliminarEnfermo(inscripcion);
            this.CargarEnfermos();
        }
    }
}
