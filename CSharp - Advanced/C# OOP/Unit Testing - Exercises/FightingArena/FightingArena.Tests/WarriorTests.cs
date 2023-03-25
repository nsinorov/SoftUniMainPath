namespace FightingArena.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;

        //Arange
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Pesho", 15, 45);
        }

        [TearDown]
        public void TearDown()
        {
            warrior = null;
        }

        [Test]

        public void Test_CreateWarrior()
        {
            warrior = new Warrior("Pesho", 15, 45);

            Assert.AreEqual("Pesho", warrior.Name);
            Assert.AreEqual(15, warrior.Damage);
            Assert.AreEqual(45, warrior.HP);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_WarriorShouldThrow_IfNameIsNullOrWhitespace(string name)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Warrior(name, 15, 45));

            Assert.That(ex.Message, Is.EqualTo("Name should not be empty or whitespace!"));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-35)]
        public void Test_WarriorShouldThrow_IfDamageIsLessOrEqualToZero(int damage)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Warrior("Pesho", damage, 45));

            Assert.That(ex.Message, Is.EqualTo("Damage value should be positive!"));
        }

        [Test]
    
        public void Test_WarriorShouldThrow_IfHPIsLessOrEqualToZero()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 15, -45));

            Assert.That(ex.Message, Is.EqualTo("HP should not be negative!"));
        }

        [Test]
        public void Test_AttackShoulThrow_IfHPIsLessThan30()
        {
            var attacker = new Warrior("Gosho", 10, 20);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => attacker.Attack(warrior));

            Assert.That(ex.Message, Is.EqualTo("Your HP is too low in order to attack other warriors!"));
        }

        [Test]
        public void Test_AttackShoulThrow_IfDefendersHPIsLessThan30()
        {
            var defender = new Warrior("Gosho", 10, 20);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => warrior.Attack(defender));

            Assert.That(ex.Message, Is.EqualTo("Enemy HP must be greater than 30 in order to attack him!"));
        }

        [Test]
        public void Test_AttackShoulThrow_IfEnemyIsStronger()
        {
            var defender = new Warrior("Gosho", 50, 120);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => warrior.Attack(defender));

            Assert.That(ex.Message, Is.EqualTo("You are trying to attack too strong enemy"));
        }

        [Test]
        public void Test_AttackShouldSucceed()
        {
            var defender = new Warrior("Gosho", 15, 35);

            warrior.Attack(defender);

            Assert.AreEqual(30, warrior.HP);
            Assert.AreEqual(20, defender.HP);
        }


        [Test]
        public void Test_AttackShouldKill()
        {
            var attacker = new Warrior("Pesho", 45, 35);
            var defender = new Warrior("Gosho", 15, 35);

            attacker.Attack(defender);

            Assert.AreEqual(20, attacker.HP);
            Assert.AreEqual(0, defender.HP);
        }
    }
}