using Microsoft.Extensions.Configuration;
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
    public partial class Form12Settings : Form
    {
        public Form12Settings()
        {
            InitializeComponent();
        }

        private void btnLeerSettings_Click(object sender, EventArgs e)
        {
            //DEBEMOS RECUPERAR CONFIGURATION DESDE PROGRAM
            IConfigurationRoot configuration = Program.GetConfiguration();
            //DENTRO DE UN FICHERO DE SETTINGS TENEMOS ZONAS CONOCIDAS
            //"ConnectionStrings"...
            //Y PARA RECUPERAR LOS VALORES, SIMPLEMENTE TENEMOS QUE SABER
            //SU KEY (SQLExpress)
            string cadenaConexion = configuration.GetConnectionString("SQLExpress");
            this.lblCadenaConexion.Text = cadenaConexion;
            //SI NO ES UNA ZONA CONOCIDA (Imagenes y Colores)
            //LOS DATOS SE RECUPERAN MEDIANTE GetSection("KEY:SUBKEY")
            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;
            //this.pictureBox1.Image = Image.FromFile("ruta de mi ordenador");
            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);
            string colorFondo = configuration.GetSection("Colores:fondo").Value;
            string colorLetra = configuration.GetSection("Colores:letra").Value;
            this.btnLeerSettings.BackColor = Color.FromName(colorFondo);
            this.btnLeerSettings.ForeColor = Color.FromName(colorLetra);
        }
    }
}
