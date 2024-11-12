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
    public partial class Form09IncrementarSalarioEmpleados : Form
    {
        RepositoryEmpleados repo;

        public Form09IncrementarSalarioEmpleados()
        {
            InitializeComponent();
            this.repo = Program.provider.GetService<RepositoryEmpleados>();
            List<string> oficios = this.repo.GetOficios();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }

        private void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncrementoSalarial.Text);
            this.repo.IncrementarSalarioEmpleados(oficio, incremento);
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);
            this.lsvEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                ListViewItem item = new ListViewItem();
                item.Text = emp.Apellido;
                item.SubItems.Add(emp.Oficio);
                item.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(item);
            }
        }
    }
}
