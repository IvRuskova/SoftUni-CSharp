namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class Tests
    {
        //Fields
        private UniversityLibrary library;

        //Tests
        [SetUp]
        public void Setup()
        {
            library = new UniversityLibrary();
        }

        [Test]
        public void ConstructorShouldWorkPoperly()
        {
            Assert.IsNotNull(library);

            Type expectedType = typeof(List<TextBook>);
            Type actualType = library.Catalogue.GetType();
            Assert.AreEqual(expectedType, actualType);
        }
        [Test]
        public void ReturnTextBookMethodShouldWorkCorrectly()
        {
            TextBook book = new TextBook("Harry Potter", "J.K.Rowling", "Fantastics");
            book.Holder = "I.V.R.";
            library.AddTextBookToLibrary(book);

            string expectedMessage = $"{book.Title} is returned to the library.";
            string actualMessage = library.ReturnTextBook(1);
            Assert.AreEqual(expectedMessage, actualMessage);
            Assert.AreEqual(book.Holder, String.Empty);
        }
    }
}