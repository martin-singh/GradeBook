using System;

namespace GradeBook
{
    // This class is used as a base class to class Book.
    public class NamedObject
    {
        /*
         * FIELD
         * - incapsulate state and store data for a object.
         * - name convention: private --> starts with a lowercase, public --> uppcase.
         */
        private string name;


        /*
         * PROPERTY
         * - is similar to fields but it has a different syntax and more powerful features eg. statements such as null value.
         * - has a backing field behind.
         * - auto property is definied as Name { get; set; }
         */
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        /*
         * CONSTRUCTOR
         * - every class that inherits from this class also need to pass a param responding to this param as ": base(param)".
         */
        public NamedObject(string name)
        {
            Name = name;
        }
    }
}
