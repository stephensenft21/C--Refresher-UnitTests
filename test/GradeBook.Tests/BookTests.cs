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
            book.AddGrade(74.2);
            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(90.04, result.Average);
            Assert.Equal(100.0, result.High);
            Assert.Equal(74.2, result.Low);
        }
    }
}
