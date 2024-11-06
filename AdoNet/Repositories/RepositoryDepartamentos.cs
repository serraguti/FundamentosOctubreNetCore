using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdoNet.Models;

namespace AdoNet.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        //EN EL CONSTRUCTOR LO QUE HAREMOS SERA INSTANCIAR LOS OBJETOS
        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;User ID=SA;";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        //METODO PARA PODER INSERTAR UN DEPARTAMENTO
        public void InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@id, @nombre, @localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamLocalidad);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        public void EliminarDepartamento(int id)
        {
            string sql = "delete from DEPT where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        public void ModificarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@localidad where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamLocalidad);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        //EL SIGUIENTE METODO DEBE DEVOLVER UN CONJUNTO DE DEPARTAMENTOS
        // List<Departamento>
        public List<Departamento> GetDepartamentos()
        {
            string sql = "select * from DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //DEBEMOS CREAR UNA NUEVA COLECCION PARA RELLENARLA CON LOS DATOS
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                //EXTRAEMOS LOS DATOS DEL READER
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                //POR CADA DATO QUE TENGAMOS EN LA TABLA, DEBEMOS CREAR 
                //UN NUEVO MODEL DEPARTAMENTO
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                //CADA DEPARTAMENTO MODEL QUE HEMOS CREADO, LO DEBEMOS
                //GUARDAR DENTRO DE LA COLECCION
                departamentos.Add(dept);
            }
            //LIBERAMOS LOS RECURSOS
            this.reader.Close();
            this.cn.Close();
            //DEVOLVEMOS LA COLECCION DE MODELS
            return departamentos;
        }
    }
}
