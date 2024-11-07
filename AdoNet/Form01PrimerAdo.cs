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
            //NECESITAMOS UN CONSTRUCTOR DE CONFIGURACIONES 
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
            
            //CREAMOS EL OBJETO CONNECTION.  DICHO OBJETO, AL SER INSTANCIADO LE DEBEMOS 
            //INDICAR LA CADENA DE CONEXION
            this.cn = new SqlConnection(connectionString);
            //CREAMOS EL COMANDO
            this.com = new SqlCommand();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                //ABRIMOS LA CONEXION
                this.cn.Open();
                this.lblMensaje.Text = "Conectado";
                this.lblMensaje.BackColor = Color.LightGreen;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.Text = "Desconectado";
            this.lblMensaje.BackColor = Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //PARA PODER LEER DATOS, NECESITAMOS QUE LA CONEXION ESTE ABIERTA
            //CONSULTA QUE VAMOS A REALIZAR
            string sql = "select * from EMP";
            //INDICAMOS AL COMANDO QUE CONEXION VA A UTILIZAR
            this.com.Connection = this.cn;
            //DEBEMOS INDICAR EL TIPO DE CONSULTA A REALIZAR
            this.com.CommandType = CommandType.Text;
            //INDICAMOS LA CONSULTA SQL
            this.com.CommandText = sql;
            //A PARTIR DE AQUI, LA CONEXION DEBERIA ESTAR ABIERTA
            //COMO ES UNA CONSULTA DE SELECCION, DEBEMOS EJECUTAR EN EL 
            //COMANDO EL METODO ExecuteReader() QUE NOS DEVUELVE UN 
            //DataReader
            this.reader = this.com.ExecuteReader();
            //YA TENEMOS LOS DATOS AQUI
            //DIBUJAMOS LAS COLUMNAS DE LA CONSULTA
            //TENEMOS UNA PROPIEDAD LLAMADA FieldCount QUE DEVUELVE
            //EL NUMERO DE COLUMNAS
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                //LEEMOS EL TIPO DE DATO DE LA PRIMERA COLUMNA
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }


            //VAMOS A LEER TODOS LOS APELLIDOS
            //EL METODO Read() DEVUELVE UN BOOLEAN MIENTRAS QUE PUEDA LEER
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //AL FINALIZAR LA LECTURA DE DATOS, SIEMPRE DEBEMOS CERRAR LOS 
            //RECURSOS
            this.reader.Close();
        }
    }
}
