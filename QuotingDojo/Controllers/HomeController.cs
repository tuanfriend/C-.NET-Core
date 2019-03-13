using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("quotedash")]
        public IActionResult quotedash()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quote");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            ViewBag.Quotes = AllQuotes;
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            // other code
            string query = $"INSERT INTO quote (name, content) VALUES ('{Request.Form["name"]}', '{Request.Form["quote"]}')";
            DbConnector.Execute(query);
            return RedirectToAction("quotedash");
        }

    }
}
