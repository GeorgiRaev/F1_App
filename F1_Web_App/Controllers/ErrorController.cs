using Microsoft.AspNetCore.Mvc;

namespace F1_Web_App.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/404")]
        public IActionResult Error404()
        {
            return View();
        }

        [Route("Error/500")]
        public IActionResult Error500()
        {
            return View();
        }
    }
}
