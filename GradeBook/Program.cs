using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Martin's Grade book");
            book.GradeAdded += OnGradeAdded; // Raising the event.

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                string input = Console.ReadLine();

                if(input == "q")
                {
                    break; // This will exit the loop.
                }

                try
                {
                    double grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                // Catching exceptions.
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"For the grade book named {book.Name}");
            // {value:N1} is formatting the value to a rounded one decimal number.
            Console.WriteLine($"The lowest grade is {stats.Low:N1}.");
            Console.WriteLine($"The highest grade is {stats.High:N1}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}.");
            Console.WriteLine($"The letter grade is {stats.LetterGrade}.");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }

    }
}
