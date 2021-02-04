using System;
using Xunit;

namespace GradeBook.BookTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange 
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            //act


            //assert

        }
    }
}
