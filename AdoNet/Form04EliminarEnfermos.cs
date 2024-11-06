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
    public partial class Form04EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarEnfermos()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarEnfermos();
        }

        private void CargarEnfermos() {
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.cn.Close();
            this.reader.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            //PODEMOS CREAR PARAMETROS EN UNA SOLA LINEA
            //SqlParameter pam = new SqlParameter("@NOMBRE", valor)
            SqlParameter pamInscripcion = new SqlParameter("@inscripcion", inscripcion);
            this.com.Parameters.Add(pamInscripcion);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.lblMensaje.Text = "Enfermos eliminados: " + eliminados;
            this.CargarEnfermos();
        }
    }
}
