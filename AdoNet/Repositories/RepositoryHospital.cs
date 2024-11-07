using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdoNet.Models;

namespace AdoNet.Repositories
{
    public class RepositoryHospital
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospital()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
        }

        //METODO PARA RECUPERAR TODOS LOS HOSPITALES List<Hospital>
        public List<Hospital> GetHospitales()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //CREAMOS LA COLECCION DE HOSPITALES
            List<Hospital> lista = new List<Hospital>();
            while (this.reader.Read())
            {
                //CREAMOS UN OBJETO HOSPITAL POR CADA FILA
                Hospital hospital = new Hospital();
                //ASIGNAMOS LOS VALORES DEL READER A CADA PROPIEDAD DEL HOSPITAL
                hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.Camas = int.Parse(this.reader["NUM_CAMA"].ToString());

            }
        }
    }
}
