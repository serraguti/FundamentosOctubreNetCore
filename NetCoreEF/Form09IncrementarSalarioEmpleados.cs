using Microsoft.Extensions.DependencyInjection;
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

        }
    }
}
