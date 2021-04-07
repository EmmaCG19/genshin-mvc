using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinLibrary
{
    public class CharacterPlayable: Character
    {
        public const int MIN_LEVEL = 1;
        public const int MAX_LEVEL = 90;

        public CharacterPlayable()
        {
            _lvl = MIN_LEVEL;
        }

        private int _lvl;
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
    }
}
