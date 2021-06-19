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
     */
    public class Book
    {
        /*
         * FIELDS
         * - name convention: private --> starts with a lowercase, public --> uppcase.
         */
        private List<double> grades; // List
        public string Name;


        /*
         * CONSTRUCTOR
         * - is called by using the keyword "new" when creating a instance of a class e.g. new Book();.
         */
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name; // Keyword "this" refers to the field "name" of this class.
        }

        /*
         * METHODS
         */
        public void AddGrade(double grade)
        {
            // A grade should be between 0-100.
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}"); // Throwing a exception.
            }
        }

        public Statistics GetStatistics()
        {
            var stats = new Statistics();
            // stats.Low and stats.High are inits to high/low so every value they're compared to is lower/higher.
            stats.Low = double.MaxValue;
            stats.High = double.MinValue;
            stats.Average = 0.0;

            foreach (var grade in grades)
            {
                stats.Low = Math.Min(grade, stats.Low);
                stats.High = Math.Max(grade, stats.High);
                stats.Average += grade;
            }
            stats.Average /= grades.Count;

            switch (stats.Average)
            {
                case double avg when avg >= 90.0:
                    stats.LetterGrade = 'A';
                    break;
                case double avg when avg >= 80.0:
                    stats.LetterGrade = 'B';
                    break;
                case double avg when avg >= 70.0:
                    stats.LetterGrade = 'C';
                    break;
                case double avg when avg >= 60.0:
                    stats.LetterGrade = 'D';
                    break;
                default:
                    stats.LetterGrade = 'F';
                    break;
            }

            return stats;
        }

    }
}