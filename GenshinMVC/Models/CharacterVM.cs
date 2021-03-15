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
    }
}