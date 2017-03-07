using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Added on 3-7-2017 for testing
            return View();
        }
    }
}
