using Microsoft.AspNetCore.Mvc;
using ProyectoDatos.Data;
using ProyectoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDatos.Controllers
{
    public class HospitalesController : Controller
    {
        HospitalContext context;

        public HospitalesController()
        {
            this.context = new HospitalContext();
        }
        public IActionResult Index()
        {
            List<Hospital> hospitales = this.context.GetHospitales();
            return View(hospitales);
        }

        public IActionResult Details(int idhosp)
        {
            Hospital hosp = this.context.BuscarHospital(idhosp);
            return View(hosp);
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int idhospit)
        {
            int eliminados = this.context.EliminarHospital(idhospit);
            ViewData["mensaje"] = "Hospitales eliminados: " + eliminados;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hospital hospital)
        {
            //MODEL BINDING
            int respuesta = this.context.InsertarHospital(hospital.IdHospital, hospital.Nombre,
                hospital.Direccion, hospital.Telefono, hospital.Camas);
            ViewData["mensaje"] = "Hospitales insertados: " + respuesta;
            //return View("Delete");
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int idhospi)
        {
            Hospital hospital = this.context.BuscarHospital(idhospi);
            return View(hospital);
        }

        [HttpPost]
        public IActionResult Edit(Hospital hosp)
        {
            this.context.UpdateHospital(hosp.IdHospital, hosp.Nombre
                , hosp.Direccion, hosp.Telefono, hosp.Camas);
            return RedirectToAction("Index");
        }

        public IActionResult HospitalDetalles()
        {
            List<Hospital> hospitales = this.context.GetHospitales();
            return View(hospitales);
        }

        [HttpPost]
        public IActionResult HospitalDetalles(int id)
        {
            Hospital hospital = this.context.BuscarHospital(id);
            //ViewBag.Nombre = hospital.Nombre;
            //ViewBag.Direccion = hospital.Direccion;
            //ViewBag.Telefono = hospital.Telefono;
            //ViewBag.Camas = hospital.Camas;
            ViewData["hospital"] = hospital;
            List<Hospital> hospitales = this.context.GetHospitales();
            return View(hospitales);
        }
    }
}
