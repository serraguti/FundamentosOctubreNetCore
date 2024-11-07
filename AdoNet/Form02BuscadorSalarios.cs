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
using Microsoft.Extensions.Configuration;

namespace AdoNet
{
    public partial class Form02BuscadorSalarios : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorSalarios()
        {
            InitializeComponent();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //DEBEMOS INDICAR EL NOMBRE DE NUESTRO FICHERO JSON
            //Y LA UBICACION (PATH) DE DICHO FICHERO
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //CONSTRUIMOS EL FICHERO PARA NUESTRA APP
            IConfigurationRoot configuration = builder.Build();
            //DENTRO DE UN FICHERO DE SETTINGS TENEMOS ZONAS CONOCIDAS
            //"ConnectionStrings"...
            //Y PARA RECUPERAR LOS VALORES, SIMPLEMENTE TENEMOS QUE SABER
            //SU KEY (SQLExpress)
            string connectionString = configuration.GetConnectionString("SQLExpress");
            //string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarEmpleadosSalario_Click(object sender, EventArgs e)
        {
            //VAMOS A REALIZAR TODO A LA VEZ, COMO EN REALIDAD SE HACE
            //ENTRAR Y SALIR
            string datoSalario = this.txtSalario.Text;
            string sql = "select * from EMP where SALARIO >= " + datoSalario;
            //INDICAMOS LA CONEXION PARA EL COMANDO
            this.com.Connection = this.cn;
            //INDICAMOS EL TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //INDICAMOS LA CONSULTA
            this.com.CommandText = sql;
            //ABRIMOS LA CONEXION
            this.cn.Open();
            //EJECUTAMOS LA CONSULTA CON EL COMANDO
            this.reader = this.com.ExecuteReader();
            //DIBUJAMOS LOS DATOS EN EL FORMULARIO (LISTBOX)
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                //EXTRAEMOS LOS DATOS QUE DESEAMOS DIBUJAR
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + salario);
            }
            //UNA VEZ QUE HEMOS FINALIZADO LAS CONSULTAS, DEBEMOS CERRAR TODO
            this.reader.Close();
            this.cn.Close();
        }

        private void btnBuscarEmpleadosOficio_Click(object sender, EventArgs e)
        {
            string datoOficio = this.txtOficio.Text;
            string sql = "select * from EMP where OFICIO='" + datoOficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + oficio);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
