using System;

namespace MovieLibrary
{
    public class ObjectValidator
    {
        //Multiple constructors hidden by accessibility
        private ObjectValidator ()
        {
            //Initialize();
            //Do initialization
        }

        //Constructor chaining - pne const4ructor calls another constructor
        // Follow ctor parameter list with a colon and 'thos' (arguement)
        //  Chained constructor is called before the current ctor's body executes
        private ObjectValidator (int value): this()
        {
           // Initialize();
           
        }
        public ObjectValidator(Movie movie ): this(1)
        {
            _movie = movie;
           // Initialize();
        }


        //Anyone can call who has acess
        private void Initialize ()
        {
            //initialization??
        }
        public string Validate()
        {
            if (_movie.Validate(out var message))
                return "";
            return message;
        }
        private Movie _movie;
    
        //notes
        void DemoTypeDifferences ()
        {
            //Different kinds of types -  reference type or value type
            // All types are one or the other, never both
            //Memory -Value types are stored on the stack, ref tpyes are stored on the hea[ (memory)
            //Nullability - value types cannot be null, rey types default to null
            //assignment -value types ALWAYS copy the value, ref types copy the reference
            // Equility - value types are equal if values they contain are equal (value semantics),
             // ref types are equal iff they the same object in memory (reference seman tics)
            //          Can be customized to a degree
            // Inheritance- value types cannot be derived fro,, ref types can
            // default cotr - value types always have one, ref types give yoyu complete control over ctor
            // Immutability (guideline) - value types should be imutable, ref types don't care
            //How do you know which kind?
            //Value types - all primitives (expect string) are value types; structs
            //reference Types - class


            int valueType = 123;
            //valueType = null; cannot assign null to a value type
            int valueType2 = valueType;//pass by value,always copy by value


            Movie referenceType= new Movie();
            referenceType =null; //Allowed because ref types can be null 
            Movie referenceType2 = referenceType; //copy the reference to the new variable, both refer to the same instance in memory
        }
    
    
    
    }
    
}
