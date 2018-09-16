using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace houston_data_visuallizor.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
