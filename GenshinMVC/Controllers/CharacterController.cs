using GenshinLibrary;
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

        static IList<CharacterVM> characters;
        const int MAX_NUMBER_OF_CHARA = 25;

        static CharacterController()
        {
            characters = LoadCharactersSample();
        }

        //Action Methods

        public ActionResult Index(string message)
        {
            return RedirectToAction("GetCharacters");
        }

        public ActionResult GetCharacters()
        {
            return View(characters);
        }


        //Data Source???
        private static IList<CharacterVM> LoadCharactersSample()
        {
            Random rnd = new Random(MAX_NUMBER_OF_CHARA);

            var characters = new List<CharacterVM>
            {
                new CharacterVM{ Id= GiveMeARandomId(rnd), Name="Venti", Vision = Vision.Anemo },
                new CharacterVM{ Id= GiveMeARandomId(rnd), Name="Diluc", Vision = Vision.Pyro},
                new CharacterVM{ Id= GiveMeARandomId(rnd), Name="Barbara", Vision = Vision.Hydro},
                new CharacterVM{ Id= GiveMeARandomId(rnd), Name ="Qiqi", Vision = Vision.Cryo},
                new CharacterVM{ Id= GiveMeARandomId(rnd), Name ="Xiao", Vision = Vision.Anemo},
                new CharacterVM{ Id= GiveMeARandomId(rnd), Name ="Zhongli", Vision = Vision.Geo}
            };

            return characters;
        }

        private static int GiveMeARandomId(Random rnd)
        {
            return rnd.Next(1, MAX_NUMBER_OF_CHARA);
        }

      

    }
}