using System;
using System.Collections.Generic;

namespace GradeBook
{
    /*
     * CLASS 
     * - is like a blueprint. Used to define object of certain types. 
     */
    class Book
    {
        /*
         * FIELDS
         */
        private List<double> grades; // List
        private string name;


        /*
         * CONSTRUCTOR
         * - is called by using the keyword "new" when creating a instance of a class e.g. new Book();.
         */
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; // Keyword "this" refers to the field "name" of this class.
        }

        /*
         * METHODS
         */
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            double highestGrade = double.MinValue; // Init to a low value so every value we are comparing to is higher.
            double lowestGrade = double.MaxValue;
            double averageGrade = 0.0;

            foreach (var grade in grades)
            {
                highestGrade = Math.Max(grade, highestGrade);
                lowestGrade = Math.Min(grade, lowestGrade);
                averageGrade += grade;
            }
            averageGrade /= grades.Count;

            Console.WriteLine($"Highest grade: {highestGrade:N1}.");
            Console.WriteLine($"Lowest grade: {lowestGrade:N1}.");
            Console.WriteLine($"The average grade is {averageGrade:N1}."); // {averageGrade:N1} is formatting the value to a rounded one decimal number.
        }

    }
}