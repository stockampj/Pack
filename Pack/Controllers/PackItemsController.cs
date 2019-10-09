using Microsoft.AspNetCore.Mvc;
using Pack.Models;
using System.Collections.Generic;

namespace Pack.Controllers
{
    public class PackItemsController : Controller
    {

        [HttpPost("/packitems")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/packitems/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}