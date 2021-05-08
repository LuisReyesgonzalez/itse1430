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
    public class MemoryCharacterRoster : ICharacterRoster
    {
        public Character Add (Character character)
        {
            //Validation
            //Check for null and valid Character
            if (character==null)
                throw new ArgumentNullException(nameof(character));

            new ObjectValidator().Validate(character);

            var existing = FindByName(character.Name);
            if (existing !=null)
            {
                throw new InvalidOperationException("Character Name must be unique. ");
            };
            //add movie
            character.Id=++_id;
            _characters.Add(CloneCharacter(character));
            return character;
        }
        public void Delete ( int id )
        {
            //Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id),"Id must be greater than 0.");
          
            //Delete
            var existing = FindById(id);
            if (existing !=null)
                _characters.Remove(existing);
        }
        public Character Get ( int id )
        {
            //Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0."); ;
            //GET
            var existing = FindById(id);
            if (existing !=null)
                return null;
            return CloneCharacter(existing);
        }

        // public Character[] GetAll ()
        public IEnumerable<Character> GetAll ()

        {
            var items = new Character[_characters.Count];
            int index = 0;
            foreach (var item in _characters)
                yield return CloneCharacter(item);
        }
        public void Update ( int id, Character character)
        {   
            //id Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
           
            //Validation
            //Check for null and valid Character
            if (character==null)
                throw new ArgumentNullException(nameof(character));
            new ObjectValidator().Validate(character);

            //name validation
            var existing = FindByName(character.Name);
            if (existing !=null && existing.Id!=id)
            {
                throw new InvalidOperationException("Character Name must be unique. ");
            };

            //Must be there
            existing = FindById(id) ?? throw new Exception("character does not exist."); 
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
        private Character FindByName ( string name )
        {
            foreach (var item in _characters)
            {
                if (String.Compare(item.Name, name, true)==0)
                    return item;
            };
            return null;
        }
        private readonly List<Character> _characters = new List<Character>();
        private int _id;

    }
}
