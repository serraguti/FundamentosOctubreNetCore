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
    public partial class Form06EmpleadosOficios : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form06EmpleadosOficios()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            string sql = "select distinct OFICIO from EMP";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                this.lstOficios.Items.Add(oficio);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
