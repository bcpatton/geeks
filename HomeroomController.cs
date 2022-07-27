using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATSGeeks.Controllers
{
    public class HomeroomController : Controller
    {
        // GET: Homeroom
        public ActionResult Index()
        {
            return View();
        }
    }
}