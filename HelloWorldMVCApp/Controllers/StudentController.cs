using HelloWorldMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;  //remeber to bring in this for the grades list assignment

namespace HelloWorldMVCApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly HelloWorldContext _context;

        public StudentController(HelloWorldContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Students.ToList();
            return View(model);
        }


        //public IActionResult Create()
        //{
        //    Student model = new Student();
        //    return View(model);

        //}

        [HttpGet]
        public IActionResult Create()
        {

            //Create an instance of the DataContext Class
            //in order to properly connect to our dtatabase
            //HelloWorldContext context = new HelloWorldContext();

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

            //Save the Data
            _context.Add(model); //Adding the data to the context
            _context.SaveChanges();  //Saving the data to the table
            return View("Details", model);
        }




    }
}
