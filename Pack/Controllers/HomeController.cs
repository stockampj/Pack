  
using Microsoft.AspNetCore.Mvc;

namespace Pack.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}