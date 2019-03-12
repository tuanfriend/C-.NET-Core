using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DsurveyProj.Models;

namespace DsurveyProj.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("submit")]
        [HttpPost]
        public IActionResult submit(Survey newsurvey)
        {

            if (ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return View("result", newsurvey);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }

        }

    }
}
