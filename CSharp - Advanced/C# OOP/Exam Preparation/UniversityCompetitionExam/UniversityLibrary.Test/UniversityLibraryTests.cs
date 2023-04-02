namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using System;

    public class UniversityLibraryTests
    {
        private TextBook textBook;
        private string title = "1984";
        private string authour = "George Orwell";
        private string category = "Disthopy";

        private UniversityLibrary lib;

        [SetUp]
        public void Setup()
        {
            textBook = new TextBook(title, authour, category);
            lib = new UniversityLibrary();
        }

        [Test]
        public void TestTextbookConstructor_SetsValuesCorrectly()
        {
            Assert.AreEqual(textBook.Category, category);
            Assert.AreEqual(textBook.Author, authour);
            Assert.AreEqual(textBook.Title, title);

        }

        [Test]
        public void AddTextBookWorksCorrectly()
        {
            string result = lib.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.InventoryNumber, 1);
            Assert.AreEqual(lib.Catalogue.Count, 1);
            Assert.AreEqual(lib.Catalogue[0].Title, title);

            Assert.AreEqual(result, $"Book: 1984 - 1{Environment.NewLine}Category: Disthopy{Environment.NewLine}Author: George Orwell".TrimEnd());
        }

        [Test]
        public void LoanTextbookTests()
        {
            lib.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.Holder, null);

            string result = lib.LoanTextBook(1, "Pesho");

            Assert.AreEqual(textBook.Holder, "Pesho");
            Assert.AreEqual(result, $"{title} loaned to Pesho.");

            result = lib.LoanTextBook(1, "Pesho");
            Assert.AreEqual(result, $"Pesho still hasn't returned {textBook.Title}!");

        }

        [Test]
        public void ReturnTextbookTests()
        {
            lib.AddTextBookToLibrary(textBook);
            string result = lib.LoanTextBook(1, "Pesho");

            result = lib.ReturnTextBook(1);

            Assert.AreEqual("", textBook.Holder);
            Assert.AreEqual($"{textBook.Title} is returned to the library.", result);
        }
    }
}