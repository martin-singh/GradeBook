namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
        // CONSTRUCTOR
        public Book(string name) : base(name)
        {
        }

        /*
         * METHODS
         * - The classes, who inherits from this class, also need to implement and override this methods.
         */
        public abstract void AddGrade(double grade);
        public abstract event GradeAddedDelegate GradeAdded;
        public abstract Statistics GetStatistics();
    }
}
