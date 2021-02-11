using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    //Name rules for types
    //Noun, no abbreviations or acronyms
    //Pascal Cased

    //this keyword is only usable inside a type
    //it represents the current instance/object
    //it is used to distinguish class members from local identifiers

    //accessibility - compile time access given to the code (type,member, function,ect) for something
    //public -usable by anyone
    //private - only usable by defining type
    //internal(default for types): only usable in defining assembly

    //class-delcaration::= [modifiers] class identifier {class-members*}
    // class-members ::== field
    // field ::= [modifiers] T identifier [ = E];
    // modifers ::= [public | internal]

    /// <summary>Represents a movie</summary>
    /// <remarks>
    /// whre you put additional comments that may be useful to someone.
    /// </remarks>
    public class Movie
    {
        //Fields - variables that store data
        /// <summary> Gets or sets the title. </summary>
        // fields are initialized early in the process to 0 can be change to another value
        // fields are initialized in on underlined order
        public string title; 
        public string description ="" ;
        public int releaseYear=1900;
        public int runLength;
        public string rating="";
        public bool isClassic;
    }
}
