using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers

{
    public class FormController : Controller
    {
        static List<StudentModel> students = new List<StudentModel>();
        // GET: FormController

        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {

            return View();
        }

        // GET: FormController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormController/Create
        [HttpPost]
        public string Create(IFormCollection collection)
        {
            try
            {
                return collection["name"];
            }
            catch
            {
                return "fail";
            }
        }

        [HttpPost]
        public string Create2(StudentModel student)
        {
            try
            {
                return student.name+" "+student.surname+" "+student.no;
            }
            catch
            {
                return "fail";
            }
        }

        public IActionResult Save(StudentModel student)
        {
            return View(student);
        }
        public void SaveList(StudentModel student)
        {
            students.Add(student);
        }

        public IActionResult SeeList(StudentModel student)
        {
            return View(students);
        }

        // GET: FormController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormController/Edit/5
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

        // GET: FormController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormController/Delete/5
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
