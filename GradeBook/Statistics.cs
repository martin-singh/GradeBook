using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Statistics
    {
        // FIELDS
        public double Low; // Lowest grade
        public double High; // Highest grade
        public double Sum;
        public int Count;

        // PROPERTIES
        public double Average // Average grade
        {
            get
            {
                return Sum / Count;
            }
        }
        public char LetterGrade
        {
            get
            {
                switch (Average)
                {
                    case double avg when avg >= 90.0:
                        return 'A';

                    case double avg when avg >= 80.0:
                        return 'B';
 
                    case double avg when avg >= 70.0:
                        return 'C';

                    case double avg when avg >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        }

        // CONSTRUCTOR
        public Statistics()
        {
            // Low and High are inits to high/low so every value they're compared to is lower/higher.
            Low = double.MaxValue;
            High = double.MinValue;
            Sum = 0.0;
            Count = 0;
        }

        // METHOD
        public void Add(double number)
        {
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
            Sum += number;
            Count++;
        }
    }
}
