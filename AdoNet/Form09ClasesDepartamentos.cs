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
    public partial class Form09ClasesDepartamentos : Form
    {
        RepositoryDepartamentos repo;

        public Form09ClasesDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.CargarDepartamentos();
        }

        public void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento d in departamentos)
            {
                this.lstDepartamentos.Items.Add
                    (d.IdDepartamento + " - " + d.Nombre + " - " + d.Localidad);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            //LLAMAMOS AL METODO DEL REPOSITORIO DE INSERTAR
            this.repo.InsertarDepartamento(id, nombre, localidad);
            this.CargarDepartamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdDepartamento.Text);
            this.repo.EliminarDepartamento(id);
            this.CargarDepartamentos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.repo.ModificarDepartamento(id, nombre, localidad);
            this.CargarDepartamentos();
        }
    }
}
