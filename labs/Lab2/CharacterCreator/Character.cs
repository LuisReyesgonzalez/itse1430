using System;

namespace CharacterCreator
{
    public class Character
    {
        public Character ()// defualt construction
        {
            //Initialize the fields that cannot be initialized using the field initializer syntax
            _description = _name;
        }
        //Allows you to create the instance and set a common property all at once
        public Character ( string Name, int Strength, int Intelligence, int Agility, int Constitution, int Charisma )
        {
            _name=Name;
            _strength=Strength;
            _intelligence= Intelligence;
            _agility = Agility;
            _constitution=Constitution;
            _charisma=Charisma;

        }


        /// <summary>Validates the movie data is correct.</summary>
        /// <param name="error">determines if movie has beeen restored</param>
        /// <returns>True if movie is valid</returns>
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
            //getter - string Name()
            get {
                //Return Name if not null or empty string otherwise
                return _name ??"";
            }
            set { _name = value?.Trim() ?? ""; }
        }
        /// <summary> Gets or sets the name. </summary>
        private string _name = "";
        private int _strength;
        private int _intelligence;
        private int _agility;
        private int _constitution;
        private int _charisma;

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";
        public string profession

        {
            //getter - string Name()
            get {
                //Return Name if not null or empty string otherwise
                return _name ??"";
            }
            set { _name = value?.Trim() ?? ""; }
        }

        public string race

        {
            //getter - string Name()
            get {
                //Return Name if not null or empty string otherwise
                return _name ??"";
            }
            set { _name = value?.Trim() ?? ""; }
        }
        public int Strength{ get; set; }
        public int Intelligence{ get; set; }
        public int Agility{ get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

    }
}


