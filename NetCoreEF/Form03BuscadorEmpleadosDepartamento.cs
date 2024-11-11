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
    public partial class Form03BuscadorEmpleadosDepartamento : Form
    {
        RepositoryEmpleados repo;

        public Form03BuscadorEmpleadosDepartamento()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            int iddepartamento = int.Parse(this.txtDepartamento.Text);
            List<Empleado> empleados = this.repo.GetEmpleadosDepartamento(iddepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado empleado in empleados)
            {
                this.lstEmpleados.Items.Add(empleado.Apellido + " - " + empleado.IdDepartamento);
            }
        }
    }
}
