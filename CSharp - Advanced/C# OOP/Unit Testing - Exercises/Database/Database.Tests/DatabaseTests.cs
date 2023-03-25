namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database _database;
        //Arange
        [SetUp]
        public void SetUp()
        {
            _database = new Database();
        }

        [TearDown]
        public void TearDown()
        {
            _database = null;
        }

        [Test]
        public void Test_CreateConstructorWithElements()
        {
            // Act
            _database = new Database(1,2,3,4,5,6,7,8);

            // Assert
            Assert.AreEqual(8, _database.Count);
        }

        [Test]
        public void Test_AddMethodElement()
        {
            // Act
            _database.Add(5);

            int[] result = _database.Fetch();

            // Assert
            Assert.AreEqual(1, _database.Count);

            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(1, result.Length);

        }

        [Test]
        public void Test_AddShould_ThrowExeptionIfMoreThan16()
        {
            //Act
            _database = new Database(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);

            // Assert
            Assert.Throws<InvalidOperationException> (() => _database.Add(5));      
        }

        [Test]
        public void Test_RemoveFromEmptyDatabase_ShouldThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() => _database.Remove());
        }

        [Test]

        public void Test_RemoveShoudlRemoveLastElement()
        {
            _database = new Database(1,2);

            _database.Remove();

            var result = _database.Fetch();

            Assert.AreEqual(1, _database.Count);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(1, result[0]);
        }

        [Test]

        public void Test_FetchDataFromDatabase()
        {
            _database = new Database(1,2,3);

            var result = _database.Fetch();

            Assert.That(new int[] { 1, 2, 3 }, Is.EqualTo(result));
        }
    }
}
