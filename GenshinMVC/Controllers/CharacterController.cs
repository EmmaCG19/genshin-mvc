using GenshinDAL;
using GenshinLibrary;
using GenshinMVC.Helpers.DALMapper;
using GenshinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenshinMVC.Controllers
{
    public class CharacterController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("GetCharacters");
        }

        public ActionResult GetCharacters()
        {
            var characters = CharacterDALMapper.List();
            return View(characters);
        }

    }
}