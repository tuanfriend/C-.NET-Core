using Microsoft.AspNetCore.Mvc;

namespace HelloASPPro
{
    public class HomeController : Controller
    {   
        //request
        // Make rount to http:localhost:5000/
        [Route("")]
        [HttpGet] //If we want to use get request [HttpGet] and Post request is [HttpPost] , default is get
        public ViewResult HiThere(){
            //it will go to Views/Home/HiThere.cshtml first
            // if not found file HiThere.cshtml it will go to folder shared Views/Shared/HiThere.cshtml
            ViewBag.Example = "Test viewbag function";
            return View("Index");
        }

        //Route localhost/hello
        //[Route("hello")]
       // [HttpGet] we can use follow below don't have to use [Route("/hello")]
        [HttpGet("hellolala")]
        public string hello(){
            return "Hello Again";
        }

        // localhost:5000/user/{username}
        [HttpGet("user/{username}")]
        public string user(string username)
        {
            return $"Hello {username}";
        }

        // localhost:5000/user/{username}/{location}
        [HttpGet("user/{username}/{location}")]
        public string userlocal(string username, string location){
            if(location == "Chicago")
                return $"Hello {username} from {location} Go Bears!";
            return $"Hello {username} from {location}";
        }

        //This is redirect to function name
        [HttpGet("test")]
        public RedirectToActionResult test(){
            return RedirectToAction("hello");
        }

        //This is redirect to url
        [HttpGet("test2")]
        public RedirectResult test2(){
            return Redirect("viewtest");
        }

        //This is function view test cshtml file
        [HttpGet("viewtest")]
        public ViewResult viewtest(){
            return View("test");
        }

        //This is redirect to function name with some parameter
        [HttpGet("test3")]
        public RedirectToActionResult test3(){
            var paramet = new{username="Tom", location="Seattle"};
            return RedirectToAction("userlocal", paramet);
        }

        //This is test Json
        [HttpGet("json/{username}/{location}")]
        public JsonResult jsonuser(string username, string location){
            var paramet = new{user=username,city=location};
            var newarr = new string[]
            {
                "Tom","Tram","Tuan"
            };
            return Json(paramet);
        }

        //This is test IActionResult
        [HttpGet("acti/{username}/{location}")]
        public IActionResult acti(string username, string location){
            var paramet = new{user=username,city=location};
            if(location=="Seattle"){
                return Json(paramet);
            }else{
                return View("index");
            }
            return RedirectToAction("HiThere");
        }

        [HttpGet("viewbag")]
        public IActionResult viewbagfx(){
            ViewBag.Example = "Test viewbag function2";
            return View("index");
        }
    }
}