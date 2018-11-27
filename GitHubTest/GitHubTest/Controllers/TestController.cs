using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTest.Controllers
{
    public class TestController : Controller
    {
        // Added in 2nd Branch
        public ActionResult Index()
        {
            return View();
        }
    }
}