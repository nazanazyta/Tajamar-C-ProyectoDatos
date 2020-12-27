using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;            //DATATABLE
using System.Data.SqlClient;  //DATAADAPTER
using ProyectoDatos.Models;

namespace ProyectoDatos.Data
{
    public class EmpleadosContext
    {
        SqlDataAdapter ad;
        DataTable tabla;

        public EmpleadosContext()
        {
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.ad = new SqlDataAdapter("select * from emp", cadena);
            this.tabla = new DataTable();
            this.ad.Fill(this.tabla);
        }

        public List<Empleado> GetEmpleados()
        {
            //PARA PODER RECUPERAR DATOS CON LINQ DE UN
            //DATATABLE NECESITAMOS SU COLECCIÓN ENUMERABLE
            //tabla.AsEnumerable()
            var consulta = from datos in this.tabla.AsEnumerable()
                           select datos;
            //LA CONSULTA ES UN OBJETO ENUMERABLE QUE ESTÁ COMPUESTO
            //POR ROWS Y CADA ROW ESTÁ COMPUESTA POR FIELDS
            List<Empleado> empleados = new List<Empleado>();
            foreach (var row in consulta)
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = row.Field<int>("emp_no");
                emp.Apellido = row.Field<String>("apellido");
                emp.Oficio = row.Field<String>("oficio");
                emp.Salario = row.Field<int>("salario");
                emp.Departamento = row.Field<int>("dept_no");
                empleados.Add(emp);
            }
            return empleados;
        }

        public Empleado BuscarEmpleado(int idempleado)
        {
            //NECESITAMOS UNA CONSULTA CON UN WHERE
            var consulta = from datos in this.tabla.AsEnumerable()
                           where datos.Field<int>("emp_no") == idempleado
                           select datos;
            //CON EL MÉTODO .First() PODEMOS RECUPERAR
            //LA PRIMERA FILA DE UNA CONSULTA
            var row = consulta.First();
            Empleado emp = new Empleado();
            emp.IdEmpleado = row.Field<int>("emp_no");
            emp.Apellido = row.Field<String>("apellido");
            emp.Oficio = row.Field<String>("oficio");
            emp.Salario = row.Field<int>("salario");
            emp.Departamento = row.Field<int>("dept_no");
            return emp;
        }

        public List<Empleado> GetEmpleadosOficioSalario(String oficio, int salario)
        {
            var consulta = from datos in this.tabla.AsEnumerable()
                           where datos.Field<String>("oficio").ToLower() == oficio.ToLower()
                           && datos.Field<int>("salario") >= salario
                           select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                List<Empleado> empleados = new List<Empleado>();
                foreach (var row in consulta)
                {
                    Empleado emp = new Empleado();
                    emp.IdEmpleado = row.Field<int>("emp_no");
                    emp.Apellido = row.Field<String>("apellido");
                    emp.Oficio = row.Field<String>("oficio");
                    emp.Salario = row.Field<int>("salario");
                    emp.Departamento = row.Field<int>("emp_no");
                    empleados.Add(emp);
                }
                return empleados;
            }
        }
    }
}
