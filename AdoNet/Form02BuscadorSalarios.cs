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
    public partial class Form02BuscadorSalarios : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorSalarios()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
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
    }
}
