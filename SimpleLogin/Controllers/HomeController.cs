using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleLogin.Models;
using Microsoft.AspNetCore.Http;

namespace SimpleLogin.Controllers
{
    public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("create/product")]
    public IActionResult CreateProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpPost("create/user")]
    public IActionResult CreateUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpGet("success")]
    public string Success()
    {
        return "You have successfully submitted!";
    }
}
}
