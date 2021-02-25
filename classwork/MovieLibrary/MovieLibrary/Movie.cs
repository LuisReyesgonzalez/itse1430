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
    // class-members ::== field | method | property | ctor
    // field ::= [modifiers] T identifier [ = E];
    //method ::= [modifiers] (T|void) identifer ([parameters]) {S*}
    // modifers ::= [public | internal]

    /// <summary>Represents a movie</summary>
    /// <remarks>
    /// whre you put additional comments that may be useful to someone.
    /// </remarks>
    public class Movie
    {
        //Constructors- Create an instance of the type
        // Bear minimal to create an instance
        // Method declaration with no return type and name is always the type name
        // Use a constructor ONLy when field initializers will not work
        //  1. Non-primitive field that requires complex initialization
        //  2. One field relies ob tge value of another field
        //  3.(Deprecated) allow createing and setting the most common properties 
        //  4. Allow setting of properties that are not writable
        public Movie()// defualt construction
        {
            //Initialize the fields that cannot be initialized using the field initializer syntax
            _description = _title;
        }
        //Allows you to create the instance and set a common property all at once
        public Movie (string title)
        {
            _title=title;
        }

        //Method - provide functionality to a class (functions)
        //Methods are verbs representing action
        //Methods are always Pascal cased

        //this is a reference to the instance the method is being called
        /// <summary> Determines if movie is black and white </summary>
        /// <returns> Returns true if movie is black and white.</returns>
        public bool IsBlackAndWhite(/*Movie this */)
        {
           var isOld = ReleaseYear< 1940;
            // var isOld =this.releaseYear< 1940;

            //only case where 'this' make sense
            //var title = "";
            //title =this.title;

            var note = "";
            note =Title;
            return isOld;
        }

        /// <summary>do something complex.</summary>
        /// <param name="age">The age of the movie when restored./param>\>
        /// <param name="enable">Determines if movie has been restored</param>
        public void DoComplex(int age, bool enable)
        { }

        // Problems with fields
        //   1) Can be read or written at will
        //   2) Calculated and must be updated whenever variant values are changed
        //   3) Can never change type from int
        //   4) What happens if it is negative
        // 5) Cannot initialize to another field
        //public int AgeInYears = DateTime.Today.Year - releaseYear;

        public int AgeInYears
        {
            get {
                if (DateTime.Now.Year < ReleaseYear)
                    return 0;

                return DateTime.Today.Year - ReleaseYear;
            }
            //set { }
        }

        /// <summary>Validates the movie data is correct.</summary>
        /// <param name="error">determines if movie has beeen restored</param>
        /// <returns>True if movie is valid</returns>
        public bool Validate(out string error)
        {
        //Title is required
        if (String.IsNullOrEmpty(Title))
            {
                
                error = "title is required. ";
                return false;
            };
            //Release year >= 1900
            if (ReleaseYear < 1900)
            {
                error = "Release year must be >= 1900.";
                return false;
            };
            // run lengtj >= 0
            if (RunLength<0)
            {
                error = "Run length must be >= 0.";

                return false;
            };
            error = "";
            return true;
        }
       
        // properties - expose data using methods (simple field syntax to call a complex method
      
        //Null handling
        //null cialescing operator ::= E ?? E
        //  Find first non-null value
        // equivalent to (E1 != null) ? E1:E2
        //left associative k, can be combined (E1?? E2?? E3)
        // can still return null
        //null condition ::= e ? member 
        // Evaluates expression and if instance is not null , invokes member, or skips if it is 

        
        public string Title
        {
            //getter - string Title()
            get // string get_Title()
            {
                //Return title if not null or empty string otherwise
                return _title ??  ""; // return (_title != null) ? _title : "";

            }
            //setter - void identifier ( T value )
            set   // void set_Title ( string value )
            {
                _title =(value!=null)?value.Trim() : null;

            }
        }


        //Fields - variables that store data
        /// <summary> Gets or sets the title. </summary>
        // fields are initialized early in the process to 0 can be change to another value
        // fields are initialized in on underlined order
        //fields should always be preceded by an underscore
        // NEVER expose a field publicly
        private string _title="";
        public string Description
        {
            //get { return (_description != null) ? _description : ""; }
            get { return _description ?? ""; }
            set { _description = value; }
        }
    
        private string _description ="" ;

        // public int ReleaseYear
        // {
        //     get { return _releaseYear; }
        //     set { _releaseYear = value; }
        // }
        // private int _releaseYear=1900;

        public int ReleaseYear{get;set;}

        //public int RunLength // full property syntax
        //{
        //    get { return _runLength; }
        //    set { _runLength = value; }
        //}
        //private int _runLength;

        //auto property syntax- compiler will auto generate the full property
        public int RunLength { get; set; } = MinimumReleaseYear;//= 1900;
       
        /// <summary>Gets or sets the rating</summary>
        public string Rating
        {
            //get { return (_rating != null) ? _rating : ""; }
            get { return (_rating != null) ? _rating : ""; }
            set { _rating = value; }
        }
        private string _rating = "";

        /// <summary>Gets or sets the classic indicator.</summary>
        public bool IsClassic
        {
            get { return _isClassic; }
            set { _isClassic = value; }
        }
        private bool _isClassic;

        //auto properties can be getter or setter only if needed
        public int Age { get; }//=10;
        //private readonly int_age;


        public int RestrictedProperty
        {
            get;
            private set;

        }

        internal int InternalProperty{ get; private set; }

        //Allowed to expose a field if const or const
       //const-glorified,name literal; value baked in to usage at compile time (primitive and value will neever chage)
        //readonly-const named variable; value refenced at runtime
        public const int MinimumReleaseYear = 1900;
        public readonly DateTime MinimumReleaseDate = new DateTime(1900, 1, 1);

        //private string _note;
    }
}
