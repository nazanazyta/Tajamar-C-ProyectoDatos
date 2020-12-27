using Microsoft.AspNetCore.Mvc;
using ProyectoDatos.Data;
using ProyectoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDatos.Controllers
{
    public class EmpleadosController : Controller
    {
        EmpleadosContext context;

        public EmpleadosController()
        {
            this.context = new EmpleadosContext();
        }

        public IActionResult Index()
        {
            List<Empleado> empleados = this.context.GetEmpleados();
            return View(empleados);
        }

        public IActionResult Details(int idemp)
        {
            Empleado emp = this.context.BuscarEmpleado(idemp);
            return View(emp);
        }

        public IActionResult Buscador()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buscador(String oficio, int salario)
        {
            List<Empleado> empleados = this.context.GetEmpleadosOficioSalario(oficio, salario);
            if (empleados == null)
            {
                ViewData["mensaje"] = "No existen empleados con esas características";
                return View();
            }
            else
            {
                return View(empleados);
            }
        }
    }
}
