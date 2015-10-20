using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class BootstrapController : Controller
    {
        //Displaying Bootstrap Pager
        public ActionResult Pager()
        {
            return View();
        }

        // Displaying a Wait Message on an MVC Page
        public ActionResult WaitMessage()
        {
            return View();
        }

        //Customization Code Snippet Project
        public ActionResult Accordion()
        {
            return View();
        }

        public ActionResult BootstrapAccordion()
        {
            return View();
        }

        // GET: Bootstrap
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bootstrap/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bootstrap/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bootstrap/Create
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

        // GET: Bootstrap/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bootstrap/Edit/5
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

        // GET: Bootstrap/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bootstrap/Delete/5
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
