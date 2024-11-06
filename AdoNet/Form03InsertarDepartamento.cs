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
    public partial class Form03InsertarDepartamento : Form
    {
        SqlConnection cn;
        SqlCommand com;

        public Form03InsertarDepartamento()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            string numero = this.txtIdDepartamento.Text;
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            string sql = "insert into DEPT values ("
                + numero + ", '" + nombre + "', '" + localidad + "')";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            //ENTRAR Y SALIR
            this.cn.Open();
            //COMO ES UNA CONSULTA DE ACCION (INSERT) DEBEMOS UTILIZAR
            //EL METODO ExecuteNonQuery() QUE NOS DEVUELVE EL NUMERO DE REGISTROS
            //AFECTADOS
            int registros = this.com.ExecuteNonQuery();
            //SALIMOS
            this.cn.Close();
            this.lblMensaje.Text = "Registros insertados: " + registros;
        }

        private void btnInsertarDepartamentoParams_Click(object sender, EventArgs e)
        {
            string sql = "insert into DEPT values (@numero, @nombre, @localidad)";
            //DEBEMOS CREAR UN PARAMETRO POR CADA VALOR
            //LOS VALORES DEBEN SER DEL MISMO TIPO DEL CAMPO/COLUMNA
            int numero = int.Parse(this.txtIdDepartamento.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            //CREAMOS LOS PARAMETROS CON SUS VALORES
            SqlParameter pamNumero = new SqlParameter();
            pamNumero.ParameterName = "@numero";
            pamNumero.Value = numero;
            this.com.Parameters.Add(pamNumero);
            SqlParameter pamNombre = new SqlParameter();
            pamNombre.ParameterName = "@nombre";
            pamNombre.Value = nombre;
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamLocalidad = new SqlParameter();
            pamLocalidad.ParameterName = "@localidad";
            pamLocalidad.Value = localidad;
            this.com.Parameters.Add(pamLocalidad);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            //CADA VEZ QUE EJECUTEMOS, DEBEMOS ELIMINAR LOS PARAMETROS DE LA COLECCION
            this.com.Parameters.Clear();
            this.lblMensaje.Text = "Registros insertados: " + registros;
        }
    }
}
