using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelFunProj.Models;

namespace ModelFunProj.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            
            Content mess=new Content()
            {
                message = "This is a test message to show in homepage"
            };
            return View(mess);
        }

        [Route("numbers")]
        [HttpGet]
        public IActionResult numbers()
        {
            Number nu1 =new Number(){
                num = 1
            };
            Number nu2 =new Number(){
                num = 2
            };
            Number nu3 =new Number(){
                num = 3
            };
            Number nu4 =new Number(){
                num = 4
            };
            Number nu5 =new Number(){
                num = 5
            };

            List<Number> viewNum = new List<Number>(){
                nu1,nu2,nu3,nu4,nu5
            };
            return View(viewNum);
        }

        public IActionResult alluser()
        {
            User n1 = new User(){
            Firstname = "Michael",
            Lastname = "Jackson"
            };

            User n2 = new User(){
            Firstname = "Henry",
            Lastname = "John"
            };

            User n3 = new User(){
            Firstname = "Alena",
            Lastname = "Kay"
            };

            User n4 = new User(){
            Firstname = "Chicago",
            Lastname = "William"
            };

            List<User> viewName = new List<User>(){
                n1,n2,n3,n4
            };

            return View(viewName);
        }

    }
}
