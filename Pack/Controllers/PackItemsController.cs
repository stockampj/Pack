using Microsoft.AspNetCore.Mvc;
using Pack.Models;
using System.Collections.Generic;

namespace Pack.Controllers
{
    public class PackListsController : Controller
    {

        [HttpGet("/packlists")]
        public ActionResult Index()
        {
            return View();
        }
    }
}