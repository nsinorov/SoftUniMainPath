using NUnit.Framework;
using System;

namespace VehicleGarage.Tests
{
    public class Tests
    {

        [TestFixture]
        public class GarageTests
        {
            private Garage garage;
            private Vehicle vehicle;

            [SetUp]
            public void Setup()
            {
                garage = new Garage(2);
            }

            [Test]
            public void AddVehicle_ShouldAddVehicle_WhenCapacityAndLicensePlateNumberAreValid()
            {
                // Arrange
                Vehicle vehicle = new Vehicle("Tesla", "Model S", "ABC123", 500);

                // Act
                bool result = garage.AddVehicle(vehicle);

                // Assert
                Assert.IsTrue(result);
                Assert.AreEqual(1, garage.Vehicles.Count);
            }
            [Test]
            public void AddVehicle_ShouldNotAddVehicle_WhenCapacityIsExceeded()
            {
                // Arrange
                Vehicle vehicle1 = new Vehicle("Tesla", "Model S", "ABC123", 500);
                Vehicle vehicle2 = new Vehicle("Toyota", "Camry", "XYZ456", 600);
                Vehicle vehicle3 = new Vehicle("Honda", "Civic", "DEF789", 700);

                // Act
                bool result1 = garage.AddVehicle(vehicle1);
                bool result2 = garage.AddVehicle(vehicle2);
                bool result3 = garage.AddVehicle(vehicle3);

                // Assert
                Assert.IsTrue(result1);
                Assert.IsTrue(result2);
                Assert.IsFalse(result3);
                Assert.AreEqual(2, garage.Vehicles.Count);
            }

            [Test]
            public void AddVehicle_WhenCapacityIsNotFull_ShouldReturnTrue()
            {
                // Arrange
                var garage = new Garage(2);
                var vehicle = new Vehicle("Toyota", "Corolla", "ABC123", 100);

                // Act
                bool result = garage.AddVehicle(vehicle);

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void AddVehicle_WhenCapacityIsFull_ShouldReturnFalse()
            {
                // Arrange
                var garage = new Garage(1);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 100);
                var vehicle2 = new Vehicle("Honda", "Civic", "DEF456", 100);
                garage.AddVehicle(vehicle1);

                // Act
                bool result = garage.AddVehicle(vehicle2);

                // Assert
                Assert.IsFalse(result);
            }

            [Test]
            public void AddVehicle_WhenVehicleWithSameLicensePlateNumberAlreadyExists_ShouldReturnFalse()
            {
                // Arrange
                var garage = new Garage(2);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 100);
                var vehicle2 = new Vehicle("Honda", "Civic", "ABC123", 100);
                garage.AddVehicle(vehicle1);

                // Act
                bool result = garage.AddVehicle(vehicle2);

                // Assert
                Assert.IsFalse(result);
            }

       

            [Test]
            public void DriveVehicle_WhenVehicleIsNotDamagedAndBatteryLevelIsSufficient_ShouldReduceBatteryLevelAndNotSetIsDamaged()
            {
                // Arrange
                var garage = new Garage(1);
                var vehicle = new Vehicle("Toyota", "Corolla", "ABC123", 100);
                garage.AddVehicle(vehicle);

                // Act
                garage.DriveVehicle("ABC123", 20, false);

                // Assert
                Assert.AreEqual(80, vehicle.BatteryLevel);
                Assert.IsFalse(vehicle.IsDamaged);
            }

            [Test]
            public void DriveVehicle_WhenVehicleIsDamaged_ShouldNotReduceBatteryLevelAndNotSetIsDamaged()
            {
                // Arrange
                var garage = new Garage(1);
                var vehicle = new Vehicle("Toyota", "Corolla", "ABC123", 100);
                vehicle.IsDamaged = true;
                garage.AddVehicle(vehicle);

                // Act
                garage.DriveVehicle("ABC123", 20, false);

                // Assert
                Assert.AreEqual(100, vehicle.BatteryLevel);
                Assert.IsTrue(vehicle.IsDamaged);
            }


            [Test]
            public void DriveVehicle_WhenVehicleIsDamaged_ShouldNotReduceBatteryLevelAndNotSetVehicleIsDamagedToTrue()
            {
                //Arrange
                var garage = new Garage(1);
                var vehicle = new Vehicle("Ford", "Fiesta", "AB123CD", 100);
                garage.AddVehicle(vehicle);
                vehicle.IsDamaged = true;
                var batteryDrainage = 50;
                var initialBatteryLevel = vehicle.BatteryLevel;

                //Act
                garage.DriveVehicle("AB123CD", batteryDrainage, false);

                //Assert
                Assert.AreEqual(initialBatteryLevel, vehicle.BatteryLevel);
                Assert.IsTrue(vehicle.IsDamaged);
            }

            [Test]
            public void DriveVehicle_WhenAccidentOccured_ShouldSetVehicleIsDamagedToTrue()
            {
                //Arrange
                var garage = new Garage(1);
                var vehicle = new Vehicle("Ford", "Fiesta", "AB123CD", 100);
                garage.AddVehicle(vehicle);
                var batteryDrainage = 50;
                var initialBatteryLevel = vehicle.BatteryLevel;

                //Act
                garage.DriveVehicle("AB123CD", batteryDrainage, true);

                //Assert
                Assert.AreEqual(initialBatteryLevel - batteryDrainage, vehicle.BatteryLevel);
                Assert.IsTrue(vehicle.IsDamaged);
            }

            [Test]
            public void Test_AddVehicle()
            {
                // Arrange
                var garage = new Garage(2);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 10000);
                var vehicle2 = new Vehicle("Honda", "Civic", "DEF456", 8000);

                // Act
                var result1 = garage.AddVehicle(vehicle1);
                var result2 = garage.AddVehicle(vehicle2);

                // Assert
                Assert.IsTrue(result1);
                Assert.IsTrue(result2);
                Assert.AreEqual(2, garage.Vehicles.Count);
            }

            [Test]
            public void Test_AddVehicle_CapacityReached()
            {
                // Arrange
                var garage = new Garage(1);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 10000);
                var vehicle2 = new Vehicle("Honda", "Civic", "DEF456", 8000);

                // Act
                var result1 = garage.AddVehicle(vehicle1);
                var result2 = garage.AddVehicle(vehicle2);

                // Assert
                Assert.IsTrue(result1);
                Assert.IsFalse(result2);
                Assert.AreEqual(1, garage.Vehicles.Count);
            }

            [Test]
            public void Test_AddVehicle_DuplicateLicensePlateNumber()
            {
                // Arrange
                var garage = new Garage(2);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 10000);
                var vehicle2 = new Vehicle("Honda", "Civic", "ABC123", 8000);

                // Act
                var result1 = garage.AddVehicle(vehicle1);
                var result2 = garage.AddVehicle(vehicle2);

                // Assert
                Assert.IsTrue(result1);
                Assert.IsFalse(result2);
                Assert.AreEqual(1, garage.Vehicles.Count);
            }

            [Test]
            public void Test_ChargeVehicles()
            {
                // Arrange
                var garage = new Garage(2);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 10000);
                var vehicle2 = new Vehicle("Honda", "Civic", "DEF456", 8000);
                garage.AddVehicle(vehicle1);
                garage.AddVehicle(vehicle2);
                vehicle1.BatteryLevel = 50;
                vehicle2.BatteryLevel = 80;

                // Act
                var result = garage.ChargeVehicles(70);

                // Assert
                Assert.AreEqual(1, result);
                Assert.AreEqual(100, vehicle1.BatteryLevel);
                Assert.AreEqual(80, vehicle2.BatteryLevel);
            }

            [Test]
            public void Test_DriveVehicle()
            {
                // Arrange
                var garage = new Garage(1);
                var vehicle1 = new Vehicle("Toyota", "Corolla", "ABC123", 10000);
                garage.AddVehicle(vehicle1);

                // Act
                garage.DriveVehicle("ABC123", 50, false);

                // Assert
                Assert.AreEqual(50, vehicle1.BatteryLevel);
            }
        }
    }
}
