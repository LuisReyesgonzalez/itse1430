
//Luis Reyes
//ITSE1430
//Character Creator SQL Database
using System.Collections.Generic;

namespace CharacterCreator
{
    public interface ICharacterRoster
    {
        Character Add ( Character character);
        void Delete ( int id );
        Character Get ( int id );
        IEnumerable<Character> GetAll ();
        void Update ( int id, Character character);
    }
}