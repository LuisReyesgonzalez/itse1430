﻿//Luis Reyes
//ITSE1430
//Character Collections
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class MemoryCharacterRoster : ICharacterRoster
    {
        public Character Add ( Character character, out string error )
        {
            //Validation
            //Check for null and valid Character
            if (character==null)
            {
                error="Character is null";
                return null;
            };
            if (!character.Validate(out error))
                return null;
            //not needed
            var existing = FindByName(character.Name);
            if (existing !=null)
            {
                error="Character name must be unique";
                return null;
            };
            //add movie
            character.Id=++_id;
            _characters.Add(CloneCharacter(character));

            return character;
        }
        public void Delete ( int id, out string error )
        {
            //Validation
            if (id <= 0)
            {
                error="Id must be greater than zero.";
                return;
            };
            error=null;

            //Delete
            var existing = FindById(id);
            if (existing !=null)
                _characters.Remove(existing);
        }
        public Character Get ( int id, out string error )
        {
            //Validation
            if (id <= 0)
            {
                error="Id must be greater than zero.";
                return null;
            };
            error=null;

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
                items[index++]=CloneCharacter(item);
            return items;
        }
        public void Update ( int id, Character character, out string error )
        {
            //Validation
            //Check for null and valid Character
            if (character==null)
            {
                error="Character is null";
                return;
            };
            if (!character.Validate(out error))
                return;
            //id Validation
            if (id <= 0)
            {
                error="Id must be greater than zero.";
                return;
            };
            error=null;
            //name
            var existing = FindByName(character.Name);
            if (existing !=null&& existing.Id != id)
            {
                error="Character name must be unique";
                return;
            };
            //Must be there
            existing = FindById(id);
            if (existing ==null)
            {
                error="Character must be exist";
                return;
            };

            error=null;

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
