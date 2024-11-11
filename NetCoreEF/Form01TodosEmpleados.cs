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
    public partial class Form01TodosEmpleados : Form
    {
        RepositoryEmpleados repo;
        public Form01TodosEmpleados()
        {
            InitializeComponent();
            //EN LUGAR DE CREAR EL REPOSITORIO, DEBEMOS RECUPERARLO DE 
            //PROGRAM
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
        }

        private void btnCargarEmpleados_Click(object sender, EventArgs e)
        {
            //UTILIZAMOS TODO LO REALIZADO Y DIBUJAMOS
            List<Empleado> empleados = this.repo.GetEmpleados();
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido + " - " + emp.Oficio);
            }
        }
    }
}
