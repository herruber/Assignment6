using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment6.Models;

namespace Assignment6.Controllers
{
    public class ClassController : Controller
    {
        Repository.Repo repo = new Repository.Repo();

        // GET: Class
        public ActionResult Index()
        {
            return View(repo.GetAllStudents());
        }


        public ActionResult Create()
        {
            ViewBag.ClassID = new SelectList(repo.GetAllClasses(), "ClassID", "ClassName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {

            if (ModelState.IsValid)
            {
                repo.AddStudent(student);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}