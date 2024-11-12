using NetCoreEF.Data;
using NetCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region VISTAS

/*
    CREATE VIEW EMPLEADOSDEPARTAMENTOS
    AS
	    select EMP.EMP_NO as IDEMPLEADO, EMP.APELLIDO
	    , EMP.OFICIO, EMP.SALARIO
	    , DEPT.DNOMBRE, DEPT.LOC
	    from EMP
	    inner join DEPT
	    on EMP.DEPT_NO = DEPT.DEPT_NO
    GO
*/

#endregion

namespace NetCoreEF.Repositories
{
    public class RepositoryVistaEmpleados
    {
        EmpleadosContext context;

        public RepositoryVistaEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<EmpleadoDepartamento> GetEmpleadosDepartamentos()
        {
            var consulta = from datos in this.context.EmpleadosDepartamentos
                           select datos;
            return consulta.ToList();
        }
    }
}
