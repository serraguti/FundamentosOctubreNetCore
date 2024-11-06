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
    public partial class Form08DepartamentosEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form08DepartamentosEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            string sql = "select * from DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.lstDepartamentos.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select EMP.APELLIDO "
                + " from EMP "
                + " inner join DEPT "
                + " on EMP.DEPT_NO = DEPT.DEPT_NO "
                + " where DEPT.DNOMBRE=@departamento";
            string nombre = this.lstDepartamentos.SelectedItem.ToString();
            SqlParameter pamDepartamento = new SqlParameter("@departamento", nombre);
            this.com.Parameters.Add(pamDepartamento);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
