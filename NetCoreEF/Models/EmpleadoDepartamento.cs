using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEF.Models
{
    [Table("EMPLEADOSDEPARTAMENTOS")]
    public class EmpleadoDepartamento
    {
        [Key]
        [Column("IDEMPLEADO")]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        public string Apellido { get; set; }
        [Column("OFICIO")]
        public string Oficio { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("DNOMBRE")]
        public string Departamento { get; set; }
        [Column("LOC")]
        public string Localidad { get; set; }
    }
}
