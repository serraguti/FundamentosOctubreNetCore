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
    public partial class Form05ModificarSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05ModificarSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarSalas();
        }

        private void CargarSalas()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string sql = "update SALA set NOMBRE=@nuevonombre where NOMBRE=@antiguonombre";
            string antiguoNombre = this.lstSalas.SelectedItem.ToString();
            string nuevoNombre = this.txtNuevaSala.Text;
            SqlParameter pamNew = new SqlParameter("@nuevonombre", nuevoNombre);
            this.com.Parameters.Add(pamNew);
            SqlParameter pamOld = new SqlParameter("@antiguonombre", antiguoNombre);
            this.com.Parameters.Add(pamOld);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.lblMensaje.Text = "Salas modificadas: " + modificados;
            this.CargarSalas();
        }
    }
}
