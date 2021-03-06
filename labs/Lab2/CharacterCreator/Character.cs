﻿using System;

namespace CharacterCreator
{
    public class Character
    {
        public Character ()// defualt construction
        {
            //Initialize the fields that cannot be initialized using the field initializer syntax
            _biography = _name;
        }
      
        public Character ( string Name,string Race,string Profession, int Strength, int Intelligence, int Agility, int Constitution, int Charisma )
        {
            _name=Name;
            _race=Race;
            _profession=Profession;
            _strength=Strength;
            _intelligence= Intelligence;
            _agility = Agility;
            _constitution=Constitution;
            _charisma=Charisma;

        }


        /// <summary>Validates nane for the character is correct.</summary>
        
        public bool Validate ( out string error )
        {
            //Name is required
            if (String.IsNullOrEmpty(Name))
            {
                error = "Name is required. ";
                return false;
            };
            error = "";
            return true;
        }



        public string Name
        {
            get {
                
                return _name ??"";
            }
            set { _name = value?.Trim() ?? ""; }
        }
        /// <summary> Gets or sets the name. </summary>
        private string _name = "";
        private string _race = "";
        private string _profession = "";
        private int _strength;
        private int _intelligence;
        private int _agility;
        private int _constitution;
        private int _charisma;

        public string Biography
        {
            get { return _biography ?? ""; }
            set { _biography = value; }
        }
        private string _biography = "";
        public string profession

        {
            //getter - string Name()
            get {
                return _profession ??"";
            }
            set { _profession = value?.Trim() ?? ""; }
        }

        public string race

        {
            //getter - string Name()
            get {
                return _race ??"";
            }
            set { _race = value?.Trim() ?? ""; }
        }
        public int Strength{ get; set; }
        public int Intelligence{ get; set; }
        public int Agility{ get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

    }
}


