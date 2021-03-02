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
    }
}
