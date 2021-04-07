using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinLibrary
{
    public class Character
    {
        private const int NUMBER_OF_ABILITIES = 3;

        public Character()
        {
            Abilities = new Ability[NUMBER_OF_ABILITIES];
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public Vision Vision { get; set; }
        public WeaponType CanWield { get; set; }
        public Ability[] Abilities { get; set; }
    }
}

