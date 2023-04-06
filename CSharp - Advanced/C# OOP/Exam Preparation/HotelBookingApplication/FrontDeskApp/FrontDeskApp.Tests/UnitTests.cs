using FrontDeskApp;
using NUnit.Framework;
using System;

namespace BookigApp.Tests
{
    [TestFixture]
    public class Tests
    {
        private Hotel hotel;

        [SetUp]
        public void Setup()
        {
            hotel = new Hotel("Gosho", 5);
        }

        [Test]
        public void Test_ConstructorSetsFullNameAndCategoryCorrectly()
        {
            string expectedFullName = "Gosho";
            int expectedCategory = 5;

            Assert.AreEqual(expectedFullName, hotel.FullName);
            Assert.AreEqual(expectedCategory, hotel.Category);

        }
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        [TestCase("     ")]
        public void Test_FullNameThrowsExWhenValueIsNullOrWhiteSpace(string fullName) 
        {
            Assert.Throws<ArgumentNullException>(() => new Hotel(fullName, 5));
        }

        [TestCase(-10)]
        [TestCase(0)]
        [TestCase(6)]
        [TestCase(10)]
        public void Test_CategoryThrowsExWhenValueIsZeroOrSix( int category)
        {
            Assert.Throws<ArgumentException>(() => new Hotel("Gosho", category));
        }
        [Test]
        public void Test_AddRoomCorrectly()
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
        }
        [TestCase(-10)]
        [TestCase(0)]
        public void Test_BookRoomThrowsExWhereThereAreNoAdults(int adults)
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(adults, 2, 3, 200));
        }
        [TestCase(-10)]
        [TestCase(-1)]
        public void Test_BookRoomThrowsExWhereChildrenAreLessThanZero(int children)
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(3, children, 3, 200));
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void Test_BookRoomThrowsExWhereResidenceDurationIsLessThanZero(int recidenceDuraton)
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(3, 2, recidenceDuraton, 200));
        }

        [Test]
        public void Test_BookRoomNoTurnoverWhenNotEnoughBeds()
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            hotel.BookRoom(4,1,2,100);

            Assert.That(hotel.Turnover, Is.EqualTo(0));
        }

        [Test]
        public void Test_BookRoomNoBookingWhenBudgetTooLow()
        {
            Room room = new(3, 70);

            hotel.AddRoom(room);

            hotel.BookRoom(4, 0, 2, 100);

            double expectedTurnover = 0;

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
            Assert.That(hotel.Bookings.Count, Is.EqualTo(0));
            Assert.That(expectedTurnover, Is.EqualTo(0));
        }

        [Test]
        public void Test_BookRoomBooksRoomCorrectly()
        {
            Room room = new(5, 70);

            hotel.AddRoom(room);
            hotel.BookRoom(4, 1, 2, 150);

            double expectedTurnover = 140;

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
            Assert.That(hotel.Bookings.Count, Is.EqualTo(1));
            Assert.That(expectedTurnover, Is.EqualTo(hotel.Turnover));
        }
    }
}