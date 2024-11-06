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
    public partial class Form07ResumenHospitales : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader; 

        public Form07ResumenHospitales()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            string sql = "select * from HOSPITAL";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstHospitales.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select COUNT(*) as PERSONAS, MAX(DOCTOR.SALARIO) as MAXIMOSALARIO "
                + ", MIN(DOCTOR.SALARIO) AS MINIMOSALARIO"
                + ", HOSPITAL.NOMBRE "
                + " from DOCTOR "
                + " inner join HOSPITAL "
                + " on DOCTOR.HOSPITAL_COD = HOSPITAL.HOSPITAL_COD "
                + " where HOSPITAL.NOMBRE=@nombre "
                + " group by HOSPITAL.NOMBRE";
            string nombre = this.lstHospitales.SelectedItem.ToString();
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(pamNombre);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string personas = this.reader["PERSONAS"].ToString();
                string maximoSalario = this.reader["MAXIMOSALARIO"].ToString();
                string minimoSalario = this.reader["MINIMOSALARIO"].ToString();
                this.txtDoctores.Text = personas;
                this.txtMaximoSalario.Text = maximoSalario;
                this.txtMinimoSalario.Text = minimoSalario;
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
