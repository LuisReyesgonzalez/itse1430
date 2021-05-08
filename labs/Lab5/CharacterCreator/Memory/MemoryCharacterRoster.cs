//Luis Reyes
//ITSE1430
//Character Creator SQL Database
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class MemoryCharacterRoster : CharacterRoster
    {
        protected override Character AddCore (Character character)
        {
            //add movie
            character.Id=++_id;
            _characters.Add(CloneCharacter(character));
            return character;
        }
        protected override void DeleteCore ( int id )
        {
          
            //Delete
            var existing = FindById(id);
            if (existing !=null)
                _characters.Remove(existing);
        }
        protected override Character GetCore ( int id )
        {
            //GET
            var existing = FindById(id);
            if (existing !=null)
                return null;
            return CloneCharacter(existing);
        }

        // public Character[] GetAll ()
        protected override IEnumerable<Character> GetAllCore ()

        {
           
            foreach (var item in _characters)
                yield return CloneCharacter(item);
        }
        protected override void UpdateCore ( int id, Character character)
        {   
            //Must be there
           var  existing = FindById(id) ?? throw new Exception("character does not exist."); 
            //Update the character
            CopyCharacter(existing, character);
        }
        //Cloning the info of the character
        private Character CloneCharacter ( Character character )
        {
            var target = new Character() {
                Id=character.Id
            };
            CopyCharacter(target, character);
            return target;
        }
        private void CopyCharacter ( Character target, Character source )
        {
            target.Name= source.Name;
            target.profession = source.profession;
            target.race=source.race;
            target.Strength=source.Strength;
            target.Intelligence=source.Intelligence;
            target.Agility=source.Agility;
            target.Constitution=source.Constitution;
            target.Charisma=source.Charisma;
            target.Biography=source.Biography;
        }

        private Character FindById ( int id )
        {
            foreach (var item in _characters)
            {
                if (item.Id ==id)
                    return item;
            };
            return null;

        }

        private readonly List<Character> _characters = new List<Character>();
        private int _id;

    }
}
