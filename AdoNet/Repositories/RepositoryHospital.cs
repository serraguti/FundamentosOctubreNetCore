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
                //AGREGAMOS EL HOSPITAL A LA COLECCION 
                lista.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            //DEVOLVEMOS LA COLECCION DE HOSPITALES
            return lista;
        }

        //METODO PARA DEVOLVER LOS DOCTORES POR ID DE HOSPITAL
        public List<Doctor> GetDoctoresHospital(int idhospital)
        {
            string sql = "select * from DOCTOR where HOSPITAL_COD=@idhospital";
            this.com.Parameters.AddWithValue("@idhospital", idhospital);
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //CREAMOS LA COLECCION A DEVOLVER
            List<Doctor> lista = new List<Doctor>();
            while (this.reader.Read())
            {
                //CREAMOS UN DOCTOR POR CADA FILA DEL READER
                Doctor doc = new Doctor();
                doc.IdDoctor = int.Parse(this.reader["DOCTOR_NO"].ToString());
                doc.Apellido = this.reader["APELLIDO"].ToString();
                doc.Especialidad = this.reader["ESPECIALIDAD"].ToString();
                doc.Salario = int.Parse(this.reader["SALARIO"].ToString());
                doc.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                lista.Add(doc);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return lista;
        }

        public int IncrementarSalarioDoctores(int incremento, int idhospital)
        {
            string sql = "update DOCTOR set SALARIO = SALARIO + @incremento where HOSPITAL_COD=@idhospital";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@idhospital", idhospital);
            this.com.CommandText = sql;
            this.cn.Open();
            int registros = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return registros;
        }

        public void ModificarEspecialidadDoctor(string especialidad, int iddoctor)
        {
            string sql = "update DOCTOR set ESPECIALIDAD=@especialidad where DOCTOR_NO=@iddoctor";
            this.com.Parameters.AddWithValue("@especialidad", especialidad);
            this.com.Parameters.AddWithValue("@iddoctor", iddoctor);
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
