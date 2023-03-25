namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
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
        public void Test_CreateDatabaseWith2Elements()
        {
            // Act
            _database = new Database(new Person(1, "Pesho"), new Person(2, "Gosho"));

            Person firstPerson = _database.FindById(1);
            Person secondPerson = _database.FindById(2);

            // Assert
            Assert.AreEqual(2, _database.Count);
            Assert.AreEqual("Pesho", firstPerson.UserName);
            Assert.AreEqual("Gosho", secondPerson.UserName);
        }

        [Test]
        public void Test_AddMethodElement()
        {
            // Act
            _database.Add(new Person(1, "Pesho"));

            Person result = _database.FindById(1);

            // Assert
            Assert.AreEqual(1, _database.Count);

            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Pesho", result.UserName);

        }

        [Test]
        public void Test_ShouldThrowIfMoreThanMaxLenght()
        {
            Person[] people = CreateFullArray();

            _database = new Database(people);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => _database.Add(new Person(17, "Pesho")));

            Assert.That(ex.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void Test_AddShouldThrowIfNotUniqueUsername()
        {
            _database.Add(new Person(1, "Pesho"));

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => _database.Add(new Person(17, "Pesho")));

            Assert.That(ex.Message, Is.EqualTo("There is already user with this username!"));
        }

        [Test]
        public void Test_AddShouldThrowIfNotUniqueId()
        {
            _database.Add(new Person(1, "Pesho"));

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => _database.Add(new Person(1, "Gosho")));

            Assert.That(ex.Message, Is.EqualTo("There is already user with this Id!"));
        }


        [Test]
        public void Test_RemoveFromEmptyDatabase_ShouldThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() => _database.Remove());
        }
        
        [Test]
        
        public void Test_RemoveShoudlRemoveLastElement()
        {
            _database = new Database(new Person(1, "Pesho"), new Person(2, "Gosho"));           
        
            _database.Remove();

            Person firstPerson = _database.FindById(1);   
        
            Assert.AreEqual(1, _database.Count);
            Assert.AreEqual("Pesho", firstPerson.UserName);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => _database.FindByUsername("Gosho"));

            Assert.That(ex.Message, Is.EqualTo("No user is present by this username!"));
        }
        
        [Test]       
        public void Test_FindByUsername_ShouldThrowExIfUsername_IsNullOrEmpty()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => _database.FindByUsername(null));

            Assert.That(ex.ParamName, Is.EqualTo("Username parameter is null!"));

            ArgumentNullException emptyEx = Assert.Throws<ArgumentNullException>(() => _database.FindByUsername(string.Empty));

            Assert.That(emptyEx.ParamName, Is.EqualTo("Username parameter is null!"));
        }

        [Test]
        public void Test_FindByUsername_ShouldThrowExIfUsername_DoesNotExist()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => _database.FindByUsername("Gosho"));

            Assert.That(ex.Message, Is.EqualTo("No user is present by this username!"));
        }

        [Test]
        public void Test_FindByUser_PositiveTest_ByUsername()
        {

            _database = new Database(new Person(1, "Pesho"), new Person(2, "Gosho"));

            Person person = _database.FindByUsername("Gosho");

            Assert.AreEqual("Gosho", person.UserName);
            Assert.AreEqual(2, person.Id);
        }

        [Test]
        public void Test_FindById_ShouldThrowExIfId_IsLessThanZero()
        {
            ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => _database.FindById(-2));

            Assert.That(ex.ParamName, Is.EqualTo("Id should be a positive number!"));
        }

        [Test]
        public void Test_FindById_ShouldThrowExIfId_DoesNotExist()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => _database.FindById(8));

            Assert.That(ex.Message, Is.EqualTo("No user is present by this ID!"));
        }

        [Test]
        public void Test_FindById_PositiveTest_ById()
        {

            _database = new Database(new Person(1, "Pesho"), new Person(2, "Gosho"));

            Person person = _database.FindById(2);

            Assert.AreEqual("Gosho", person.UserName);
            Assert.AreEqual(2, person.Id);
        }

        private Person[] CreateFullArray()
        {
            Person[] persons = new Person[16];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, i.ToString());
            }

            return persons;
        }
    }
}