using Microsoft.AspNetCore.Mvc;
using Pack.Models;
using System.Collections.Generic;

namespace Pack.Controllers
{
    public class PackItemsController : Controller
    {

        [HttpPost("/packitems")]
        public ActionResult Index(string name, string size)
        {
            PackItem packItem = new PackItem(name,size);
            List<PackItem> packList = PackItem.PackList;
            
            return View("Index",packList);
        }

        [HttpGet("/packitems/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}