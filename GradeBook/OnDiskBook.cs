using System;
using System.IO;

namespace GradeBook
{
    internal class OnDiskBook : Book
    {
        public OnDiskBook(string name) : base(name)
        {
        }

        public override void AddGrade(double grade)
        {
            // The using statement cleans up needed resources after execution so a writer.Close() or .Dispose() isn't needed.
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override event GradeAddedDelegate GradeAdded;
        
        public override Statistics GetStatistics()
        {
            Statistics stats = new Statistics();

            using(var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = double.Parse(line);
                    stats.Add(number);
                    line = reader.ReadLine();
                }
            }
            return stats;
        }
    }
}