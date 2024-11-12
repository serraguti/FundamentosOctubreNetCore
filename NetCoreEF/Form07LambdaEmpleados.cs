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
    public partial class Form07LambdaEmpleados : Form
    {
        RepositoryEmpleados repo;

        public Form07LambdaEmpleados()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
            List<int> departamentos = this.repo.GetNumerosDepartamento();
            this.cmbDepartamentos.Items.Clear();
            foreach (int id in departamentos)
            {
                this.cmbDepartamentos.Items.Add(id.ToString());
            }
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idDepartamento = int.Parse(this.cmbDepartamentos.SelectedItem.ToString());
            ResumenEmpleados resumen = this.repo.GetResumenEmpleadosDepartamento(idDepartamento);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in resumen.Empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Salario);
            }
            this.txtPersonas.Text = resumen.Personas.ToString();
            this.txtMaximoSalario.Text = resumen.MaximoSalario.ToString();
            this.txtMinimoSalario.Text = resumen.MinimoSalario.ToString();
        }
    }
}
