using Microsoft.AspNetCore.Mvc;

namespace S13_Environments.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("some-route")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("some-route")]
        public IActionResult other()
        {
            return View();
        }
        //[Route("Error")]
        //public IActionResult Error()
        //{
        //    return View();
        //}
    }
}
