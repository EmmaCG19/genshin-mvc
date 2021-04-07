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
        public ActionResult Index(int id, bool edit)
        {
            CharacterVM model = CharacterDALMapper.FindById(id);

            if (model != null)
            {
                if (edit)
                {
                    return RedirectToAction("EditCharacter", "CharacterDetails", model);
                }
                else
                {
                    return RedirectToAction("ViewCharacter", "CharacterDetails", model);
                }
            }
            else
            {
                return View("Error");
            }


        }

        [HttpGet]
        public ActionResult EditCharacter(CharacterVM character)
        {
            return Content($"<h1>{character.Name} - Edit</h1>");
        }

        [HttpGet]
        public ActionResult ViewCharacter(CharacterVM character)
        {
            return Content($"<h1>{character.Name} - Edit</h1>");
        }

    }
}