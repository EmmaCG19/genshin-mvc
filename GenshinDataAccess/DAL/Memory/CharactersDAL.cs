using GenshinLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenshinDAL
{
    public class CharactersDAL : ICharactersDAL
    {
        public const int NUMBER_OF_CHARA = 25;
        private static IList<Character> _characters;
        private static Random _rnd;

        static CharactersDAL()
        {
            _rnd = new Random(NUMBER_OF_CHARA);
            _characters = LoadCharactersSample();
        }

        public void Save(Character character)
        {
            try
            {
                if (character.Id.HasValue)
                {
                    Update(character);
                }
                else
                {
                    Add(character);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private static IList<Character> LoadCharactersSample()
        {
            var characters = new List<Character>
            {
                new Character{ Id= GiveMeARandomId(), Name="Venti", Vision = Vision.Anemo, CanWield = WeaponType.Bow, Region = Region.Mondstadt },
                new Character{ Id= GiveMeARandomId(), Name="Diluc", Vision = Vision.Pyro, CanWield = WeaponType.Claymore, Region = Region.Mondstadt},
                new Character{ Id= GiveMeARandomId(), Name="Barbara", Vision = Vision.Hydro, CanWield = WeaponType.Catalyst, Region = Region.Mondstadt},
                new Character{ Id= GiveMeARandomId(), Name ="Qiqi", Vision = Vision.Cryo, CanWield = WeaponType.Sword, Region = Region.Liyue},
                new Character{ Id= GiveMeARandomId(), Name ="Xiao", Vision = Vision.Anemo, CanWield = WeaponType.Polearm, Region = Region.Liyue},
                new Character{ Id= GiveMeARandomId(), Name ="Zhongli", Vision = Vision.Geo, CanWield = WeaponType.Polearm, Region = Region.Liyue}
            };

            return characters;
        }

        private static int GiveMeARandomId()
        {
            return _rnd.Next(1, NUMBER_OF_CHARA);
        }

        public void Add(Character character)
        {
            character.Id = GiveMeARandomId();

            _characters.Add(character);

        }

        public void Delete(int characterId)
        {
            var characterToDelete = FindById(characterId);

            if (characterToDelete != null)
            {
                _characters.Remove(characterToDelete);
            }
        }

        public IList<Character> List()
        {
            return _characters;
        }

        public void Update(Character character)
        {
            var characterToUpdate = FindById(character.Id.Value);

            if (characterToUpdate != null)
            {
                characterToUpdate.Name = character.Name;
                characterToUpdate.Region = character.Region;
                characterToUpdate.CanWield = character.CanWield;
                characterToUpdate.Abilities = character.Abilities;
                characterToUpdate.Vision = character.Vision;
            }

        }

        public Character FindById(int characterId)
        {
            return _characters.Where(c => c.Id == characterId).FirstOrDefault();
        }
    }
}
