namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        //Arange
        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
        }

        [TearDown]
        public void TearDown()
        {
            arena = null;
        }

        [Test]
        public void Test_ArenaShouldBeVoidOnCreate()
        {
            arena = new Arena();
            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void Test_EnrollShoulAddWarrior()
        {
            arena.Enroll(new Warrior("Pesho", 5, 12));

            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        public void Test_EnrollShoulThrow_IfWarriorNameIsNotUnique()
        {
            arena.Enroll(new Warrior("Pesho", 5, 12));

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("Pesho", 5, 12)));

            Assert.That(ex.Message, Is.EqualTo("Warrior is already enrolled for the fights!"));

            Assert.AreEqual(1, arena.Count);
        }

        [Test]
          
        public void Test_FightShouldThrow_IfDefenderWarriorsIsMissing()
        {
            arena.Enroll(new Warrior("Pesho", 5, 12));

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => arena.Fight("Pesho", "Gosho"));

            Assert.That(ex.Message, Is.EqualTo("There is no fighter with name Gosho enrolled for the fights!"));
        }

        [Test]
        
        public void Test_FightShouldThrow_IfAttackerWarriorsIsMissing()
        {
            arena.Enroll(new Warrior("Pesho", 5, 12));

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => arena.Fight("Misho", "Pesho"));

            Assert.That(ex.Message, Is.EqualTo("There is no fighter with name Misho enrolled for the fights!"));
        }

        [Test]

        public void Test_Fight()
        {
            // Arrange
            var attacker = new Warrior("Pesho", 15, 35);
            var defender = new Warrior("Gosho", 15, 45);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            // Act
            arena.Fight(attacker.Name, defender.Name);

            // Assert
            Assert.AreEqual(20, attacker.HP);
            Assert.AreEqual(30, defender.HP);
        }

    }
}
