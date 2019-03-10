using Microsoft.AspNetCore.Mvc;
namespace testForm
{
    public class testForm : Controller
    {
        [HttpPost("")]

        public IActionResult Method(string TextField, int NumberField)
        {
            // Do something with form input
        
        }
    }
}