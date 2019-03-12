using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPass.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPass.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            RandomString newpass = new RandomString();
            ViewBag.newpass = newpass.RandomWord();
            
            if(HttpContext.Session.GetInt32("count") == null){
                HttpContext.Session.SetInt32("count", 1);
                ViewBag.Count = HttpContext.Session.GetInt32("count");
            }else{
                HttpContext.Session.SetInt32("count", (int)HttpContext.Session.GetInt32("count")+1);
                ViewBag.Count = HttpContext.Session.GetInt32("count");
            }
            return View();
        }

        [HttpGet("clear")]
        public IActionResult Clear(){
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }

    }
}
