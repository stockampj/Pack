using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
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