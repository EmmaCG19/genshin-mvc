using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenshinDAL;
using GenshinMVC.Helpers;

namespace GenshinMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            //Instancio por única vez el DALMapper
            var mapper = new CharacterDALMapper(new CharactersDAL());

        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Character");
        }

    }
}