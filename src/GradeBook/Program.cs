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
            gradebook.ShowStats();
        }
    }
}