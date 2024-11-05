using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        //NECESITAMOS UN OBJETO PARA CONECTAR
        SqlConnection cn;
        //NECESITAMOS UN OBJETO PARA EJECUTAR LAS CONSULTAS
        SqlCommand com;
        //NECESITAMOS UN OBJETO PARA LEER LOS DATOS
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            //AL INICIAR LA CLASE, DEBEMOS INICIALIZAR LOS OBJETOS DE 
            //ACCESO A DATOS.
            //NECESITAMOS LA CADENA DE CONEXION A SQL SERVER
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;Trust Server Certificate=True";
            //CREAMOS EL OBJETO CONNECTION.  DICHO OBJETO, AL SER INSTANCIADO LE DEBEMOS 
            //INDICAR LA CADENA DE CONEXION
            this.cn = new SqlConnection(connectionString);
            //CREAMOS EL COMANDO
            this.com = new SqlCommand();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //ABRIMOS LA CONEXION
            this.cn.Open();
            this.lblMensaje.Text = "Conectado";
            this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.Text = "Desconectado";
            this.lblMensaje.BackColor = Color.Red;
        }
    }
}
