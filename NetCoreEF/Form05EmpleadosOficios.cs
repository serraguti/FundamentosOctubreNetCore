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
    public partial class Form05EmpleadosOficios : Form
    {
        RepositoryEmpleados repo;

        public Form05EmpleadosOficios()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
            //RECUPERAMOS TODOS LOS EMPLEADOS Y DIBUJAMOS LOS OFICIOS EN LA LISTA
            List<Empleado> empleados = this.repo.GetEmpleados();
            foreach (Empleado emp in empleados)
            {
                this.lstOficios.Items.Add(emp.Oficio);
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
