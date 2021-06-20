using System;
using System.Collections.Generic;

namespace GradeBook
{
    /*
     * ACCESS MODIFERS
     * - public: available cross the entire solution, 
     *   internal:  available inside the project.
     *   private: available inside of a class.
     */

    /*
     * CLASS 
     * - is like a blueprint. Used to define object of certain types. 
     * - inheritens is defined as "class : base class".
     */
    public class InMemoryBook : Book
    {
        
        private List<double> grades; // List

        /*
         * CONSTRUCTOR
         * - is called by using the keyword "new" when creating a instance of a class e.g. new Book();.
         * - since our base class "Book" has a constructor which take a param, we need to pass a param to that constructor as well by using "class : base(param)"
         */
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            this.Name = name; // Keyword "this" refers to the field "name" of this class.
        }

        /*
         * METHODS
         */
        public override void AddGrade(double grade)
        {
            // A grade should be between 0-100.
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

                // Invoke the delegate.
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}"); // Throwing a exception.
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            foreach (var grade in grades)
            {
                stats.Add(grade);
            }

            return stats;
        }

    }
}