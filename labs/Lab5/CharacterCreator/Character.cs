using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace CharacterCreator
{
    public class Character : IValidatableObject
    {
        public Character ()// defualt construction
        {
            //Initialize the fields that cannot be initialized using the field initializer syntax
            _biography = _name;
        }
      
      

        /// <summary>Validates nane for the character is correct.</summary>

       

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            var errors = new List<ValidationResult>();
            if (String.IsNullOrEmpty(Name))
                errors.Add(new ValidationResult( "Name is required. "));
         
            if (Strength<=0)
                errors.Add(new ValidationResult("Strength must be greater than 0."));
            if (Intelligence<=0)
                errors.Add(new ValidationResult("Intelligence must be greater than 0."));
             if (Agility<=0)
                errors.Add(new ValidationResult("Agility must be greater than 0."));
            if (Constitution<=0)
                errors.Add(new ValidationResult("Constitution must be greater than 0."));
            if (Charisma<=0)
                errors.Add(new ValidationResult("Charisma must be greater than 0."));
            return errors;

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


