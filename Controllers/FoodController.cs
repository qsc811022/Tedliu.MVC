using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Tedliu.MVC.Models.DomainModel;
using Tedliu.MVC.Models.Service;

namespace Tedliu.MVC.Controllers
{
    public class FoodController : Controller
    {
        Service service = new Service();
        // GET: Food
        public ActionResult Index()
        {
            var data = service.getll();
            return View(data);
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Food/Create
        [HttpPost]
        public ActionResult Create(FoodTable Model)
        {
            try
            {
                // TODO: Add insert logic here
                service.Create(Model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Edit/5
        public ActionResult Edit(int id)
        {
            var data = service.getid(id);
            return View(data);
        }

        // POST: Food/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection,FoodTable model)
        {
            try
            {
                // TODO: Add update logic here
                service.Edit(id,model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Delete/5
        public ActionResult Delete(int id)
        {
            var data = service.getid(id);
            return View();
        }

        // POST: Food/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                service.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
