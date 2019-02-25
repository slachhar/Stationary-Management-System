using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_Api.Controllers
{
    public class InstitutionsController : Controller
    {
        // GET: Institutions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Institutions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Institutions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Institutions/Create
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

        // GET: Institutions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Institutions/Edit/5
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

        // GET: Institutions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Institutions/Delete/5
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
