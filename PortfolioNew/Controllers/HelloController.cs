using Microsoft.AspNetCore.Mvc;

namespace PortfolioNew.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpGet("project")]
        public ViewResult project(){
            return View("project");
        }

        [HttpGet("contact")]
        public ViewResult contact(){
            return View("contact");
        }

        [HttpGet("razor")]
        public ViewResult razor(){
            return View("razor");
        }

        [HttpGet("time")]
        public ViewResult time(){
            return View("time");
        }
    }
}