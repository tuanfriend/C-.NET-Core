using Microsoft.AspNetCore.Mvc;

namespace PortfolioRoute
{
    public class PortfolioRoute: Controller
    {

        [HttpGet("")]
        public string index(){
            return "This is my index page";
        }

        [HttpGet("project")]
        public string projectpg(){
            return "These are my projects page";
        }

        [HttpGet("{contact}")]
        public string contact(string contact){
            return $"This is my {contact} page!";
        }

    }
}