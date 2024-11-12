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
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;

        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryDepartamentos>();
            this.CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lsvDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dept.IdDepartamento.ToString();
                item.SubItems.Add(dept.Nombre);
                item.SubItems.Add(dept.Localidad);
                this.lsvDepartamentos.Items.Add(item);
            }
        }

        private void lsvDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvDepartamentos.SelectedItems.Count != 0)
            {
                ListViewItem itemSeleccionado = this.lsvDepartamentos.SelectedItems[0];
                int id = int.Parse(itemSeleccionado.Text);
                Departamento departamento = this.repo.FindDepartamento(id);
                this.txtIdDepartamento.Text = departamento.IdDepartamento.ToString();
                this.txtNombre.Text = departamento.Nombre;
                this.txtLocalidad.Text = departamento.Localidad;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.InsertarDepartamento(nombre, localidad);
            this.CargarDepartamentos();
            this.txtIdDepartamento.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
        }

        private void btnModificarDepartamento_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.ModificarDepartamento(id, nombre, localidad);
            this.CargarDepartamentos();
            this.txtIdDepartamento.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            ListViewItem itemSeleccionado = this.lsvDepartamentos.SelectedItems[0];
            int id = int.Parse(itemSeleccionado.Text);
            this.repo.EliminarDepartamento(id);
            this.CargarDepartamentos();
            this.txtIdDepartamento.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
        }
    }
}
