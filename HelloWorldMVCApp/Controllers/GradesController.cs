using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldMVCApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace HelloWorldMVCApp.Controllers
{


    public class GradesController : Controller
    {
        private readonly HelloWorldContext _context;

        public GradesController(HelloWorldContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Grades.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            GradesModel model = new GradesModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(GradesModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _context.Add(model);
            _context.SaveChanges();

            return View("Details", model);
        }


    }
}
