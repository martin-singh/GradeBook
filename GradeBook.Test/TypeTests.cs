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
            InMemoryBook book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.AreEqual("New Name", book1.Name);
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [TestMethod]
        public void CSharpIsPassByValue()
        {
            InMemoryBook book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.AreEqual("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [TestMethod]
        public void CanSetNameFromRefernce()
        {
            // This test is about reference types.
            InMemoryBook book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.AreEqual("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [TestMethod]
        public void GetBookReturnsDiffrentObject()
        {
            // This test is about reference types.
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = GetBook("Book 2");

            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);
            Assert.AreNotSame(book1, book2);
        }

        [TestMethod]
        public void TwoVariablesCanRefSameObject()
        {
            // This test is about reference types.
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = book1;

            Assert.AreEqual("Book 1", book2.Name);
            Assert.AreSame(book1, book2);
        }

        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
