using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagement.BLL.Contracts;

namespace StudentManagement.Controllers
{
    public class SchoolController : Controller
    {
        protected ISchoolManager SchoolManager;

        public SchoolController(ISchoolManager manager)
        {
            SchoolManager = manager;
        }
        //
        // GET: /School/
        public ActionResult Index()
        {
            var school = SchoolManager.GetAll();
            return View(school);
        }

        //
        // GET: /School/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /School/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /School/Create
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

        //
        // GET: /School/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /School/Edit/5
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

        //
        // GET: /School/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /School/Delete/5
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
