using FrontEnd.Helpers.Implementations;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class ShippersController : Controller
    {

        IShippersHelper ShippersHelper;
        
        public ShippersController(IShippersHelper shippersHelper)
        {
            ShippersHelper = shippersHelper;
        }

        // GET: ShippersController
        public ActionResult Index()
        {
            List<ShippersViewModel> lista = ShippersHelper.GetShippers();
            return View(lista);
        }

        // GET: ShippersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShippersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShippersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShippersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShippersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShippersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShippersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
