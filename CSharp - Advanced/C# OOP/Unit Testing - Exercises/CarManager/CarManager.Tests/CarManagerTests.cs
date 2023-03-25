namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;
        //Arange
        [SetUp]
        public void Setup()
        {
            car = new Car("Audi", "R8", 10, 100);
        }

        [TearDown]
        public void TearDown()
        {
            car = null;
        }

        [Test]
        public void Test_ConstructorShouldCreateCar()
        {
            car = new Car("Audi", "R8", 10, 100);

            Assert.AreEqual("Audi", car.Make);
            Assert.AreEqual("R8", car.Model);
            Assert.AreEqual(10, car.FuelConsumption);
            Assert.AreEqual(100, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_CreateCarFails_IfMakeIsNullOrEmpty(string make)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car(make, "R8", 10, 100));

            Assert.That(ex.Message, Is.EqualTo("Make cannot be null or empty!"));
        }

        //[Test]
        //public void Test_CreateCarFails_IfMakeIsEmpty()
        //{
        //    ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car//(string.Empty, "R8", 10, 100));
        //
        //    Assert.That(ex.Message, Is.EqualTo("Make cannot be null or empty!"));
        //}

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_CreateCarFails_IfModelIsNullOrEmpty(string model)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car("Audi", model, 10, 100));

            Assert.That(ex.Message, Is.EqualTo("Model cannot be null or empty!"));
        }

        //[Test]
        //public void Test_CreateCarFails_IfModelIsEmpty()
        //{
        //    ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car//("Audi", string.Empty, 10, 100));
        //
        //    Assert.That(ex.Message, Is.EqualTo("Model cannot be null or empty!"));
        //}

        [Test]
        [TestCase(0)]
        [TestCase(-3)]
        public void Test_CreateCarFails_IfFuelConsuptionIsLessOrEqualToZero(double consuption)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car("Audi", "R8", consuption, 100));

            Assert.That(ex.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-3)]
        public void Test_CreateCarFails_IfFuelCapacityIsLessOrEqualToZero(double capacity)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Car("Audi", "R8", 10, capacity));

            Assert.That(ex.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-3)]
        public void Test_RefuelShouldThrow_IfLessThanOrEqualToZero(double litres)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => car.Refuel(litres));

            Assert.That(ex.Message, Is.EqualTo("Fuel amount cannot be zero or negative!"));
        }

        [Test]
        public void Test_RefuelShouldBeEqualToFuelAmmount()
        {
            car.Refuel(95);

            Assert.AreEqual(95, car.FuelAmount);
        }

        [Test]
        public void Test_RefuelShouldBeEqualToFuelCapacity()
        {
            car.Refuel(102);

            Assert.AreEqual(100, car.FuelAmount);
        }

        [Test]
        public void Test_DriveShouldThrow_IfNotEnoughFuel()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => car.Drive(1));

            Assert.That(ex.Message, Is.EqualTo("You don't have enough fuel to drive!"));
        }

        [Test]

        public void Test_DriveShouldHaveEnoughFuel()
        {
            car.Refuel(10);
            car.Drive(100);

            Assert.AreEqual(0, car.FuelAmount);
        }
    }
}