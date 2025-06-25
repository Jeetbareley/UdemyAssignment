using Microsoft.AspNetCore.Mvc;

namespace S13_Environments.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("/")]
        //[Route("some-route")]
        public IActionResult Index()
        {
            ViewBag.EnvironmentName = _webHostEnvironment.EnvironmentName;
            return View();
        }
        //[Route("some-route")]
        //public IActionResult other()
        //{
        //    return View();
        //}
        //[Route("Error")]
        //public IActionResult Error()
        //{
        //    return View();
        //}
    }
}
