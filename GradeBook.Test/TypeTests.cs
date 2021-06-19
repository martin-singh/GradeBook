using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GradeBook.Test
{
    [TestClass]
    public class TypeTests
    {
        /*
         * TYPES
         * - Value types such as int, double etc. is defined by the "struct" keyword.
         * - Reference types is build as a class for instance the Book in this example. String is also a reference type, even if behaves as a value type.
         */
        [TestMethod]
        public void CSharpCanPassByRef()
        {
            // It's possible to pass by reference by using the keyword "ref" as a param.
            Book book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.AreEqual("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [TestMethod]
        public void CSharpIsPassByValue()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.AreEqual("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [TestMethod]
        public void CanSetNameFromRefernce()
        {
            // This test is about reference types.
            Book book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.AreEqual("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [TestMethod]
        public void GetBookReturnsDiffrentObject()
        {
            // This test is about reference types.
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);
            Assert.AreNotSame(book1, book2);
        }

        [TestMethod]
        public void TwoVariablesCanRefSameObject()
        {
            // This test is about reference types.
            Book book1 = GetBook("Book 1");
            Book book2 = book1;

            Assert.AreEqual("Book 1", book2.Name);
            Assert.AreSame(book1, book2);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
