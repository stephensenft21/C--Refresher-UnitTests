using System;
using System.Collections.Generic;
using System.Linq;
namespace GradeBook {
   public class Book {
        public Book(string name) {
            Name = name;
        }
        public string Name { get; set; }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0) {
                grades.Add(grade);
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double grade in grades) 
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            result.Average = Math.Round(result.Average,2);

            return result;
        }
        public void ListGrades()
        {
            Console.WriteLine(String.Join(", ", grades));
        }
        public void CalculateStats()
        {
            foreach (var grade in grades) 
            {
                avgGrade += grade;
                highestGrade = Math.Max(grade, highestGrade);
                lowestGrade = Math.Min(grade, lowestGrade);
            }
            avgGrade /= grades.Count;
        }
        public void ShowStats()
        {
            CalculateStats();
            Console.WriteLine($"The average grade for {Name} is: {avgGrade:N1}");
            Console.WriteLine($"The highest grade for {Name} is: {highestGrade}");
            Console.WriteLine($"The lowest grade for {Name} is: {lowestGrade}");
        }
        private List<double> grades = new List<double>()
        {
            99.7, 100.0, 84.31, 92.0
        };
        private double avgGrade = 0.0;
        private double highestGrade = double.MinValue;
        private double lowestGrade = double.MaxValue;
    }
}