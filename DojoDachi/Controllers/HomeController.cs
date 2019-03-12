using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("count") == null)
            {
                HttpContext.Session.SetInt32("Fullness", 20);
                HttpContext.Session.SetInt32("Happiness", 20);
                HttpContext.Session.SetInt32("Meals", 3);
                HttpContext.Session.SetInt32("Energy", 50);
                HttpContext.Session.SetInt32("count", 1);
            }
            else
            {


                if (HttpContext.Session.GetInt32("Fullness") >= 100 && HttpContext.Session.GetInt32("Happiness") >= 100 && HttpContext.Session.GetInt32("Energy") >= 100)
                {
                    HttpContext.Session.SetString("text", "Congratulation, You Won!!!!");
                    ViewBag.button = "<a href='/reset'><button>Reset</button></a>";
                }


            }

            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.text = HttpContext.Session.GetString("text");
            return View();
        }

        [Route("test")]
        [HttpGet]
        public IActionResult test()
        {
            HttpContext.Session.SetInt32("Fullness", 100);
            HttpContext.Session.SetInt32("Happiness", 100);
            HttpContext.Session.SetInt32("Energy", 100);
            return RedirectToAction("Index");
        }

        [Route("reset")]
        [HttpGet]
        public IActionResult reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [Route("feed")]
        [HttpGet]
        public IActionResult feed()
        {
            Random rand = new Random();
            if (HttpContext.Session.GetInt32("Meals") <= 0)
            {
                HttpContext.Session.SetString("text", "Not enough meal huhu");
            }
            else
            {
                int chance = rand.Next(0, 4);
                int numchange = rand.Next(5, 11);
                if (chance == 1)
                {
                    HttpContext.Session.SetInt32("Meals", (int)HttpContext.Session.GetInt32("Meals") - 1);
                    HttpContext.Session.SetString("text", "You played and lose 1 Meals");
                }
                else
                {
                    HttpContext.Session.SetInt32("Meals", (int)HttpContext.Session.GetInt32("Meals") - 1);
                    HttpContext.Session.SetInt32("Fullness", (int)HttpContext.Session.GetInt32("Fullness") + numchange);
                    HttpContext.Session.SetString("text", "You played with your Fullness +" + numchange);
                }
            }
            return RedirectToAction("Index");
        }

        [Route("play")]
        [HttpGet]
        public IActionResult play()
        {
            Random rand = new Random();
            if (HttpContext.Session.GetInt32("Energy") <= 0)
            {
                HttpContext.Session.SetString("text", "Not enough Energy huhu");
            }
            else
            {
                int chance = rand.Next(0, 4);
                int numchange = rand.Next(5, 11);
                if (chance == 1)
                {
                    HttpContext.Session.SetInt32("Energy", (int)HttpContext.Session.GetInt32("Energy") - 5);
                    HttpContext.Session.SetString("text", "You played and lose 5 Energy");
                }
                else
                {
                    HttpContext.Session.SetInt32("Energy", (int)HttpContext.Session.GetInt32("Energy") - 5);
                    HttpContext.Session.SetInt32("Happiness", (int)HttpContext.Session.GetInt32("Happiness") + numchange);
                    HttpContext.Session.SetString("text", "You played with your Happiness +" + numchange);
                }

            }
            return RedirectToAction("Index");
        }

        [Route("work")]
        [HttpGet]
        public IActionResult work()
        {
            Random rand = new Random();
            if (HttpContext.Session.GetInt32("Energy") <= 0)
            {
                HttpContext.Session.SetString("text", "Not enough Energy huhu");
            }
            else
            {
                int numchange = rand.Next(1, 4);
                HttpContext.Session.SetInt32("Energy", (int)HttpContext.Session.GetInt32("Energy") - 5);
                HttpContext.Session.SetInt32("Meals", (int)HttpContext.Session.GetInt32("Meals") + numchange);
                HttpContext.Session.SetString("text", "You working so your Meal +" + numchange);
            }
            return RedirectToAction("Index");
        }

        [Route("sleep")]
        [HttpGet]
        public IActionResult sleep()
        {
            Random rand = new Random();
            if (HttpContext.Session.GetInt32("Fullness") <= 0 || HttpContext.Session.GetInt32("Happiness") <= 0)
            {
                HttpContext.Session.SetString("text", "You can't go to sleep now");
            }
            else
            {
                HttpContext.Session.SetInt32("Happiness", (int)HttpContext.Session.GetInt32("Happiness") - 5);
                HttpContext.Session.SetInt32("Energy", (int)HttpContext.Session.GetInt32("Energy") + 15);
                HttpContext.Session.SetInt32("Fullness", (int)HttpContext.Session.GetInt32("Fullness") - 5);
                HttpContext.Session.SetString("text", "You are slept very well so Energy + 15");
            }
            return RedirectToAction("Index");
        }

    }
}
