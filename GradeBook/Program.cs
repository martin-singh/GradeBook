using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Martin's Grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();
            // {value:N1} is formatting the value to a rounded one decimal number.
            Console.WriteLine($"The lowest grade is {stats.Low:N1}.");
            Console.WriteLine($"The highest grade is {stats.High:N1}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}.");
        }
    }
}
