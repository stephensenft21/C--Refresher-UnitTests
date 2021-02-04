using System;
using System.Collections.Generic;
using System.Linq;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book gradebook = new Book("Biology Class");
            gradebook.AddGrade(74.2);
            var stats = gradebook.GetStatistics();
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}