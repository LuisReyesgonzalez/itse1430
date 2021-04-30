using System;
using System.Collections.Generic;
using System.Linq;


namespace MovieLibrary
{
  /// <summary>Reperesents a database of movie. </summary>
    public  class MovieDatabase
    {

        public Movie Add (Movie movie, out string error)
        {
            //Validation 
             if(movie ==null)
            {
                error="movie is null";
                return null;
            };
            if (movie.Validate(out error))
                return null;

            //Must be unique
            var existing = FindByTitle(movie.Title);
            if(existing !=null)
            {
                error="Movie title must be unique";
                return null;
            };
            //Add the movie
            _movies[0]=movie;

            return movie;
        }

        public Movie[] GetAll()
        {
            return _movies;
        }

        private Movie FindByTitle(string title)
        {
            return null;
        }
        //Array declaration
        // Array specification is part of the type
        //Arrays are always open(meaning no row size). multiple dimensions have find size columns
        //Arrays are reference types (nullable, they follow reference semantics)
        //Arrays are, for the most part, listed to 2 billion
        
        //Array size 
        //Can be any size >= 0
        //Does not have to be a compile time constant 
        //No need gpt some constant soze value
        //Size is determinable at runtime (mo0 need for a size parameter in function)
        
        //Array Behavior
        //Bounds checking always happens
        //Zero initialized
        //Can be empty
        // Indexing is zero base 
        private readonly Movie[] _movies=new Movie [100];
    }
}
