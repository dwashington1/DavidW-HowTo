using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var HT = new How_ToEntities();
            return View(HT.HowTos.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}