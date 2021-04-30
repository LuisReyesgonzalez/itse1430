using System;

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
        public override string ToString ()
        {
            return Name;
        }

        /// <summary>Validates nane for the character is correct.</summary>

        public bool Validate ( out string error )
        {
            //major issue here
            //Name is required
            if (String.IsNullOrEmpty(Name))
            {
                error = "Name is required. ";
                return false;
            };
            if (Strength<=0)
            {
                error = "Strength must be greater than 0.";

                return false;
            };
            if (Intelligence<=0)
            {
                error = "Intelligence must be greater than 0.";

                return false;
            }; if (Agility<=0)
            {
                error = "Agility must be greater than 0.";

                return false;
            };
            if (Constitution<=0)
            {
                error = "Constitution must be greater than 0.";

                return false;
            };
            if (Charisma<=0)
            {
                error = "Charisma must be greater than 0.";

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
        /// <summary>Unique</summary>
        public int Id { get; set; }
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


