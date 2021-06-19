using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Test
{
    [TestClass]
    public class BookTests
    {
        // A test method can be divided into three sections as definied below.
        [TestMethod]
        public void CheckStatistics()
        {
            // ARRANGE
            Book book = new Book("Test's Grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            // ACT
            var result = book.GetStatistics();

            // ASSERT
            Assert.AreEqual(77.5, result.Low);
            Assert.AreEqual(90.5, result.High);
            Assert.AreEqual(85.6, result.Average, 1); // The last param (delta) definies the precision.
        }
    }
}
