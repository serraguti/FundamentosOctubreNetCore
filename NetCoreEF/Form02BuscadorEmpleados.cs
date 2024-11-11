using Microsoft.Extensions.DependencyInjection;
using NetCoreEF.Data;
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
    public partial class Form02BuscadorEmpleados : Form
    {
        RepositoryEmpleados repo;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
        }

        private void btnBuscarSalarios_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.txtSalario.Text);
            List<Empleado> empleados = this.repo.GetEmpleadosSalario(salario);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Salario);
            }
        }

        private void btnBuscarOficios_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }
    }
}
