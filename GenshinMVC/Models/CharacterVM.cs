using GenshinLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GenshinMVC.Models
{
    public class CharacterVM
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A vision must be selected")]
        public Vision Vision { get; set; }
        [Required(ErrorMessage = "A region must be selected")]
        public Region Region { get; set; }
        [Required(ErrorMessage = "A weapon type must be selected")]
        public WeaponType Weapon { get; set; }
    }
}

