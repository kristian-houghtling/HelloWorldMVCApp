using HelloWorldMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelloWorldMVCApp.Controllers
{
    public class StudentController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


        //public IActionResult Create()
        //{
        //    Student model = new Student();
        //    return View(model);

        //}

        [HttpGet]
        public IActionResult Create()
        {
            Student model = new Student();
            var x = new List<Student>()
            {
                new Student{status = "Yes",  hasPassed = false},
                new Student{status = "No",  hasPassed = false},
            };

            return View(model);
        }

        //[HttpGet]
        //public IActionResult Create(List<Student> list)
        //{
        //    var list = new List<Student>
        //    {
        //        new Student{Passing = "Yes",  hasPassed = false},
        //        new Student{Passing = "No", hasPassed= false}
        //    };

        //    return View(list);
        //}

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View("Details", model);
        }




    }
}
