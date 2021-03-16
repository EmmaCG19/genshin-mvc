using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenshinMVC.Controllers
{
    public class CharacterDetailsController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            return View();
        }
    }
}