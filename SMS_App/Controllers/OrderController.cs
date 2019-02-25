using SMS_App.Business.Models;
using SMS_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SMS_App.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.GetResponse("api/Orders/"+ id);
            response.EnsureSuccessStatusCode();
            //return RedirectToAction("GetAllProducts");
            Order order = new Order();
            if (response.IsSuccessStatusCode)
            {
                var readTask = response.Content.ReadAsAsync<Order>();
                readTask.Wait();

                order = readTask.Result;
            }
            return View(order);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View("CreateOrder");
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Order order)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.PostResponse("api/Orders", order);
            response.EnsureSuccessStatusCode();
            //return RedirectToAction("GetAllProducts");
            return View("CreateOrder");
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Order order)
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.PutResponse("api/Orders", order);
                response.EnsureSuccessStatusCode();
                //return RedirectToAction("GetAllProducts");

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.GetResponse("api/Orders/" + id);
            response.EnsureSuccessStatusCode();
            //return RedirectToAction("GetAllProducts");
            Order order = new Order();
            if (response.IsSuccessStatusCode)
            {
                var readTask = response.Content.ReadAsAsync<Order>();
                readTask.Wait();

                order = readTask.Result;
            }
            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.DeleteResponse("api/orders/"+ id);
                response.EnsureSuccessStatusCode();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
