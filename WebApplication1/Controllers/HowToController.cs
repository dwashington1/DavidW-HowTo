using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HowToController : Controller
    {
        // GET: HowTo
        public ActionResult Index()
        {
            var HT = new How_ToEntities();
            return View(HT.HowTos.ToList());
        }
        public ActionResult MakePizza()
        {
            var HT = new How_ToEntities();
            return View();
        }
        public ActionResult TricepPushup()
        {
            var HT = new How_ToEntities();
            return View();
        }
        public ActionResult PawnChess()
        {
            var HT = new How_ToEntities();
            return View();
        }
        public ActionResult Freestyle()
        {
            var HT = new How_ToEntities();
            return View();
        }
        public ActionResult Lightbulb()
        {
            var HT = new How_ToEntities();
            return View();
        }
    }
}