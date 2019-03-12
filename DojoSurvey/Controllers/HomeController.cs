using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public IActionResult index(){
            return View("index");
        }


//This's working too, we have 2 ways to do
        // [HttpPost("submit")]
        // public IActionResult submit(){
        //     ViewBag.Name = Request.Form["name"];
        //     ViewBag.Local = Request.Form["location"];
        //     ViewBag.Lang = Request.Form["lang"];
        //     ViewBag.Comment = Request.Form["cm"];
        //     return View("result");
        // }

        [HttpPost("submit")]
        public IActionResult submit(string nnname, string location, string lang, string cm){
            ViewBag.Name = nnname;
            ViewBag.Local = location;
            ViewBag.Lang = lang;
            ViewBag.Comment = cm;
            return View("result");
        }
    }
}