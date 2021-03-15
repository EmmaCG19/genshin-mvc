using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinLibrary
{
    public class Character
    {
        public const int MIN_LEVEL = 1;
        public const int MAX_LEVEL = 90;
        public const int NUMBER_OF_ABILITIES = 3;
        private int _lvl;

        public Character()
        {
            Abilities = new Ability[NUMBER_OF_ABILITIES];
            _lvl = MIN_LEVEL;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Vision Vision { get; set; }
        public int Lvl
        {
            get { return _lvl; }
            set
            {
                #region Check if the level is valid
                try
                {
                    if (value > MAX_LEVEL || value < MIN_LEVEL)
                    {
                        throw new NotImplementedException($"Lvl is not between {MIN_LEVEL} and {MAX_LEVEL}");
                    }

                    _lvl = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Lvl couldn't be assigned because { e.Message }");
                }
                #endregion
            }
        }
        public Region Region { get; set; }
        public Ability[] Abilities { get; set; }
    }
}
