using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_Api.Controllers
{
    public class InventariesController : Controller
    {
        // GET: Inventaries
        public ActionResult Index()
        {
            return View();
        }

        // GET: Inventaries/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inventaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventaries/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventaries/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inventaries/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventaries/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inventaries/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
