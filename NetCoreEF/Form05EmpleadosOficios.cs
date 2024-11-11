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
            //REALIZAMOS UNA CONSULTA PARA RECUPERAR LOS DIFERENTES OFICIOS
            List<string> oficios = this.repo.GetOficios();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }
            //RECUPERAMOS TODOS LOS EMPLEADOS Y DIBUJAMOS TODOS LOS EMPLEADOS
            //AL INICIO DE LA APLICACION
            List<Empleado> empleados = this.repo.GetEmpleados();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }
    }
}
