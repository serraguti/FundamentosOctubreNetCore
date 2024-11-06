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
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            //LLAMAMOS AL METODO DEL REPOSITORIO DE INSERTAR
            this.repo.InsertarDepartamento(id, nombre, localidad);
        }
    }
}
