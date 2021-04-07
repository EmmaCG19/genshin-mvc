using GenshinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinMVC.Helpers
{
    public interface ICharacterDALMapper
    {
        IList<CharacterVM> List();
        void Add(CharacterVM character);
        void Update(CharacterVM character);
        void Delete(int characterId);
        CharacterVM FindById(int characterId);
    }
}
