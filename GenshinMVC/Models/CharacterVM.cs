using GenshinLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenshinMVC.Models
{
    public class CharacterVM
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Vision Vision { get; set; }
        public Region Region { get; set; }
        public WeaponType Weapon { get; set; }
    }
}

//public CharacterVM(Character character)
//{
//    Name = character.Name;
//    Id = character.Id.Value;
//    Vision = character.Vision;
//    Region = character.Region;
//    Weapon = character.CanWield;
//}