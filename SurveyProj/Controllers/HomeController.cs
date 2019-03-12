using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyProj.Models;

namespace SurveyProj.Controllers
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
        public IActionResult submit(Survey newsurvey){
            
            return View("result",newsurvey);
        }

    }
}
