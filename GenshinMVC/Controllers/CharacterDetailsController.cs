using GenshinDAL;
using GenshinLibrary;
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
        const string ACTUAL_NAME_KEY = "actualName";

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

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditCharacter(CharacterVM model)
        {
            if (ModelState.IsValid)
            {
                if (IsNameAvailable(model.Name))
                {
                    #region Update character info
                    try
                    {
                        UpdateInfo(model);
                        return RedirectToAction("Index", "Character");

                    }
                    catch (Exception e)
                    {
                        ViewBag.ErrorMessage = e.Message;
                        return View("Error");
                    }
                    #endregion
                }
                else
                {
                    //Add custom error to the ModelState if the character already exists
                    ModelState.AddModelError("Name", "That name already exists");
                }
            }

            return View("EditCharacter", model);
        }

        [NonAction]
        public ActionResult CharacterDetails(int id, string viewName)
        {
            CharacterVM model = CharacterDALMapper.FindById(id);

            if (model == null)
            {
                return View("Error");
            }

            //Get actual name and save it in a temporary state object
            TempData[ACTUAL_NAME_KEY] = model.Name;

            return View(viewName, model);
        }

        [NonAction]
        public void UpdateInfo(CharacterVM character)
        {
            var model = new CharacterVM()
            {
                Id = character.Id,
                Name = character.Name,
                Region = character.Region,
                Weapon = character.Weapon,
                Vision = character.Vision
            };

            CharacterDALMapper.Update(model);
        }

        private bool IsNameAvailable(string name)
        {
            if (CharacterDALMapper.FindByName(name) is null)
            {
                return true;
            }
            else
            {
                //Get actual name
                var actualName = TempData.ContainsKey(ACTUAL_NAME_KEY)
                                                        ? TempData[ACTUAL_NAME_KEY].ToString()
                                                        : String.Empty;

                //Store the actual name again for further invalid requests
                TempData[ACTUAL_NAME_KEY] = actualName;

                if (name.Equals(actualName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;

                }

            }

            return false;

        }


    }
}
