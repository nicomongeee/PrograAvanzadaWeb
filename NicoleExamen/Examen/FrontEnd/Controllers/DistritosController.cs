using FrontEnd.Helpers.Implementations;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FrontEnd.Controllers
{
    public class DistritosController : Controller
    {
        private readonly IDistritosHelper _distritosHelper;

        public DistritosController(IDistritosHelper distritosHelper)
        {
            _distritosHelper = distritosHelper;
        }

        // GET: DistritosController
        public ActionResult Index()
        {
            List<DistritosViewModel> lista = _distritosHelper.GetDistritos();
            return View(lista);
        }

        // GET: DistritosController/Details/5
        public ActionResult Details(int id)
        {
            DistritosViewModel distrito = _distritosHelper.GetDistritos(id);
            return View(distrito);
        }

        // GET: DistritosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DistritosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DistritosViewModel distrito)
        {
            try
            {
                _distritosHelper.AddDistritos(distrito);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
    }
}
