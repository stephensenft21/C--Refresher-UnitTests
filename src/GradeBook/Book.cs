using System;
using System.Collections.Generic;
using System.Linq;
namespace GradeBook {
    class Book {
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
        public void ListGrades()
        {
            Console.WriteLine(String.Join(", ", grades));
        }
        public void CalculateStats()
        {
            foreach (double grade in grades) 
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