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
    public partial class Form06VistaEmpleados : Form
    {
        RepositoryVistaEmpleados repo;

        public Form06VistaEmpleados()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryVistaEmpleados>();
        }

        private void btnCargarVistaEmpleados_Click(object sender, EventArgs e)
        {
            List<EmpleadoDepartamento> empleados = this.repo.GetEmpleadosDepartamentos();
            this.lsvVistaEmpleados.Items.Clear();
            foreach (EmpleadoDepartamento empleado in empleados)
            {
                ListViewItem item = new ListViewItem();
                item.Text = empleado.IdEmpleado.ToString();
                item.SubItems.Add(empleado.Apellido);
                item.SubItems.Add(empleado.Oficio);
                item.SubItems.Add(empleado.Salario.ToString());
                item.SubItems.Add(empleado.Departamento);
                item.SubItems.Add(empleado.Localidad);
                this.lsvVistaEmpleados.Items.Add(item);
            }
        }
    }
}
