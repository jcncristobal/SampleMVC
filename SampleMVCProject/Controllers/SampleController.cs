using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCProject.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
       // public ActionResult Index()
       public ActionResult Index()
        {
            //return "<div>This is sample</div>";
            ViewBag.MyProperty1 = "test";
            ViewBag.MyIntProperty = 1;

            return View();
        }

        public String Welcome(int id, String name, int age = 12 )
        {
            return String.Format("<div>This is sample welcome Name: {0}    Age:{1}   ID:{2}</div>", name, age, id);
            //return "test";
         
        }
    }
}