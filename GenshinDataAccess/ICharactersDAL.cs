using GenshinLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinDAL
{
    public interface ICharactersDAL
    {
        IList<Character> List();
        void Add(Character character);
        void Update(Character character);
        void Delete(int characterId);
        Character FindById(int characterId);
        Character FindByName(string characterName);
    }
}
