using GenshinDAL;
using GenshinLibrary;
using GenshinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenshinMVC.Helpers
{
    public class CharacterDALMapper
    {
        static ICharactersDAL _dal;

        public CharacterDALMapper(ICharactersDAL dal)
        {
            _dal = dal;
        }

        public static void Add(CharacterVM character)
        {
            _dal.Add(MapToCharacter(character));
        }

        public static void Delete(int characterId)
        {
            _dal.Delete(characterId);
        }

        public static CharacterVM FindById(int characterId)
        {
            return MapToCharacterModel(_dal.FindById(characterId));
        }

        public static CharacterVM FindByName(string characterName)
        {
            return MapToCharacterModel(_dal.FindByName(characterName));
        }

        public static IList<CharacterVM> List()
        {
            IList<Character> charactersDAL = _dal.List();
            IList<CharacterVM> charactersModel = new List<CharacterVM>();

            foreach (var c in charactersDAL)
            {
                charactersModel.Add(MapToCharacterModel(c));
            }

            return charactersModel;
        }

        public static void Update(CharacterVM character)
        {
            try
            {
                _dal.Update(MapToCharacter(character));

            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.Message);
            }
        }


        static Character MapToCharacter(CharacterVM characterModel)
        {
            return new Character()
            {
                Id = characterModel.Id,
                Name = characterModel.Name,
                Region = characterModel.Region,
                Vision = characterModel.Vision,
                CanWield = characterModel.Weapon,
            };
        }

        static CharacterVM MapToCharacterModel(Character character)
        {
            if (character != null)
            {
                return new CharacterVM()
                {
                    Id = character.Id.Value,
                    Name = character.Name,
                    Region = character.Region,
                    Weapon = character.CanWield,
                    Vision = character.Vision
                };

            }

            return null;
        }

    }
}