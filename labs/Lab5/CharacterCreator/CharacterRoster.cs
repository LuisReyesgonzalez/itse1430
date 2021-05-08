//Luis Reyes
//ITSE1430
//Character Creator SQL Database
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace CharacterCreator
{
    public abstract class CharacterRoster : ICharacterRoster
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
            return AddCore(character);
        }

        protected abstract Character AddCore ( Character character );

        public void Delete ( int id )
        {
            //Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id),"Id must be greater than 0.");

            //Delete
            DeleteCore(id);
        }

        protected abstract void DeleteCore ( int id );

        public Character Get ( int id )
        {
            //Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0."); ;
            //GET
            return GetCore(id);

        }

        protected abstract Character GetCore ( int id );

        // public Character[] GetAll ()
        public IEnumerable<Character> GetAll ()

        {
            //never return null;
            return GetAllCore() ??  Enumerable.Empty<Character>();
        }

        protected abstract IEnumerable<Character> GetAllCore ();

        public void Update ( int id, Character character)
        {   
            //id Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than 0.");
           
            new ObjectValidator().Validate(character);

            //name validation
            var existing = FindByName(character.Name);
            if (existing !=null && existing.Id!=id)
                throw new InvalidOperationException("Character Name must be unique. ");
            
            UpdateCore(id, character);
         
        }

        protected abstract void UpdateCore (int id, Character character );


        protected virtual Character FindByName ( string name )
        {
            foreach (var item in GetAllCore())
            {
                if (String.Compare(item.Name, name, true)==0)
                    return item;
            };
            return null;
        }
    }
}
