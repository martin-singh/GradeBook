namespace GradeBook
{
    // This interface is used by the class Book.
    public interface IBook
    {
        // PROPERTY
        string Name { get; } // Should be at least a readable by a "get" for those who implement this interface.

        // METHODS
        void AddGrade(double grade);

        Statistics GetStatistics();

        // EVENT
        event GradeAddedDelegate GradeAdded;
    }
}
