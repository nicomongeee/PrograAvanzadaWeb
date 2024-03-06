using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FrontEnd.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadosHelper _empleadosHelper;

        public EmpleadosController(IEmpleadosHelper empleadosHelper)
        {
            _empleadosHelper = empleadosHelper;
        }

        // GET: EmpleadosController
        public ActionResult Index()
        {
            List<EmpleadosViewModel> lista = _empleadosHelper.GetEmpleados();
            return View(lista);
        }

        // GET: EmpleadosController/Details/5
        public ActionResult Details(int id)
        {
            EmpleadosViewModel empleado = _empleadosHelper.GetEmpleados(id);
            return View(empleado);
        }

        // GET: EmpleadosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadosViewModel empleado)
        {
            try
            {
                _empleadosHelper.AddEmpleados(empleado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadosController/Edit/5
        public ActionResult Edit(int id)
        {
            EmpleadosViewModel empleado = _empleadosHelper.GetEmpleados(id);
            return View(empleado);
        }

        // POST: EmpleadosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadosViewModel empleado)
        {
            try
            {
                _empleadosHelper.UpdateEmpleados(empleado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadosController/Delete/5
        public ActionResult Delete(int id)
        {
            EmpleadosViewModel empleado = _empleadosHelper.GetEmpleados(id);
            return View(empleado);
        }

        // POST: EmpleadosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _empleadosHelper.DeleteEmpleados(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
