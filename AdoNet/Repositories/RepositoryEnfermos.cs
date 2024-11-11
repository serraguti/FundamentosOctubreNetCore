using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryEnfermos
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryEnfermos()
        {
            string connectionString = Program.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
        }

        public List<Enfermo> GetEnfermos()
        {
            string sql = "select * from ENFERMO";
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Enfermo> lista = new List<Enfermo>();
            while (this.reader.Read()){
                Enfermo enfermo = new Enfermo();
                enfermo.Inscripcion = int.Parse(this.reader["INSCRIPCION"].ToString());
                enfermo.Apellido = this.reader["APELLIDO"].ToString();
                enfermo.Direccion = this.reader["DIRECCION"].ToString();
                enfermo.FechaNacimiento = DateTime.Parse(this.reader["FECHA_NAC"].ToString());
                enfermo.Nss = int.Parse(this.reader["NSS"].ToString());
                lista.Add(enfermo);
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public void EliminarEnfermo(int inscripcion)
        {
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            this.com.Parameters.AddWithValue("@inscripcion", inscripcion);
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
