//Luis Reyes
//ITSE1430
//Character Creator SQL Database
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator
{
    public class ObjectValidator
    {
       


        public List<ValidationResult> TryValidate ( IValidatableObject value )
        {
            var context = new ValidationContext(value);
            var errors = new List<ValidationResult>();

            Validator.TryValidateObject(value, context, errors, true);
            return errors;
        }
        public void Validate (IValidatableObject value)
        {
            var context = new ValidationContext(value);
            Validator.ValidateObject(value, context, true);
        }

        
    }
}
