using crud_linq_to_sql_mvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud_linq_to_sql_mvc.Controllers
{
    public class HomeController : Controller
    {
        private StudentDBdbmlDataContext db;
        public HomeController()
        {
            // Get the connection string from Web.config
            string connString = ConfigurationManager.ConnectionStrings["StudentDBConnectionString"]?.ConnectionString;

            // Check if the connection string is null
            if (string.IsNullOrEmpty(connString))
            {
                throw new Exception("Connection string 'StudentDBConnectionString' is missing or empty.");
            }

            // Initialize the data context
            db = new StudentDBdbmlDataContext(connString);

            //string connString = ConfigurationManager.ConnectionStrings["StudentDBConnectionString"].ConnectionString;
            //StudentDBdbmlDataContext db = new StudentDBdbmlDataContext(connString);
        }
        
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            db.Students.InsertOnSubmit(s);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var std = db.Students.Single(x => x.Id == id);
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(int id, Student s)
        {
            Student std = db.Students.Single(x => x.Id == id);
            std.name = s.name;
            std.gender = s.gender;
            std.age = s.age;
            std.standard = s.standard;
            db.SubmitChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var std = db.Students.Single(x => x.Id == id);
            return View(std);
        }

        [HttpPost]
        public ActionResult Delete(int id, Student s)
        {
            Student std = db.Students.Single(x => x.Id == id);
            db.Students.DeleteOnSubmit(std);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var std = db.Students.Single(x => x.Id == id);
            return View(std);
        }
    }
}    