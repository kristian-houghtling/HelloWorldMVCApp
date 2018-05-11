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
        public IActionResult Index()
        {
            return View();
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
            return View("Details", model);
        }


    }
}
