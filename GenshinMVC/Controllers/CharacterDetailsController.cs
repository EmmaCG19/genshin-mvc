using GenshinDAL;
using GenshinMVC.Helpers;
using GenshinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenshinMVC.Controllers
{
    public class CharacterDetailsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult EditCharacter(int id)
        {
            return CharacterDetails(id, "EditCharacter");
        }

        [HttpGet]
        [ActionName("View")]
        public ActionResult ViewCharacter(int id)
        {
            return CharacterDetails(id, "ViewCharacter");
        }

        [NonAction]
        public ActionResult CharacterDetails(int id, string viewName)
        {
            CharacterVM model = CharacterDALMapper.FindById(id);

            if (model == null)
            {
                return View("Error");
            }

            return View(viewName, model);
        }

    }
}