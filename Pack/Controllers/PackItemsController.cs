using Microsoft.AspNetCore.Mvc;
using Pack.Models;
using System.Collections.Generic;

namespace Pack.Controllers
{
    public class PackItemsController : Controller
    {
        [HttpGet("/packitems/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/packitems")]
        public ActionResult Index(string name, string size)
        {
            PackItem packItem = new PackItem(name,size);
            List<PackItem> packList = PackItem.PackList;
            
        
            return View("Index",packList);
        }
        
        [HttpPost("/packitems/update")]
        public ActionResult Index(List <int> item )
        {
            List<PackItem> packList = PackItem.PackList;
            foreach(PackItem itemObj in packList)
            {
                itemObj.Packed = false;
            }
            foreach(int id in item)
            {
               PackItem packItem = PackItem.SearchID(id);
               packItem.Packed =  true;
            }
            return View("Index",packList);
        }

        
    }
}