using NUnit.Framework;

namespace RobotFactory.Tests
{
    public class Tests
    {
        private Supplement supplement;
        private Robot robot;
        private Factory factory;

        [SetUp]
        public void Setup()
        {
            supplement = new Supplement("Supplement", 3);
            robot = new Robot("Robot", 3.50, 5);
            factory = new Factory("Factory", 2);
        }

        [Test]
        public void Test_ConstructorTest()
        {
            Assert.AreEqual(factory.Name, "Factory");
            Assert.AreEqual(factory.Capacity, 2);
            Assert.AreEqual(factory.Robots.Count, 0);
            Assert.AreEqual(factory.Supplements.Count, 0);

        }

        [Test]
        public void Test_SupplementCreateTest()
        {
            Assert.AreEqual(supplement.Name, "Supplement");
            Assert.AreEqual(supplement.InterfaceStandard, 3);
            Assert.AreEqual(supplement.ToString(), "Supplement: Supplement IS: 3");
        }

        [Test]
        public void Test_RobotCreateTest()
        {
            Assert.AreEqual(robot.Model, "Robot");
            Assert.AreEqual(robot.Price, 3.50);
            Assert.AreEqual(robot.InterfaceStandard, 5);
            Assert.AreEqual(robot.Supplements.Count, 0);
            Assert.AreEqual(robot.ToString(), "Robot model: Robot IS: 5, Price: 3.50");
        }
  

        [Test]
        public void Test_ProduceRobotValidationTest()
        {
            factory = new Factory("test", 1);

            factory.ProduceRobot("test", 2.5, 2);
            Assert.That(() => factory.ProduceRobot("test", 2.5, 2), Is.EqualTo("The factory is unable to produce more robots for this production day!"));
        }

        [Test]
        public void Test_ProduceRobotsTest()
        {
            Robot testRobot = new Robot("test", 2.5, 2);
            Assert.That(() => factory.ProduceRobot("test", 2.5, 2), Is.EqualTo($"Produced --> {testRobot}"));
            Assert.AreEqual(factory.Robots.Count, 1);
        }

        [Test]
        public void Test_ProduceSupplementsTest()
        {
            Assert.That(() => factory.ProduceSupplement("test", 2), Is.EqualTo("Supplement: test IS: 2"));
            Assert.AreEqual(factory.Supplements.Count, 1);
        }

        [Test]
        public void Test_UpgradeTheRobotsValidationTest()
        {
            robot.Supplements.Add(supplement);
            Assert.That(() => factory.UpgradeRobot(robot, supplement), Is.EqualTo(false));

            robot = new Robot("test", 2.5, 5);
            Assert.That(() => factory.UpgradeRobot(robot, supplement), Is.EqualTo(false));
        }

        [Test]
        public void Test_UpgradeRobotTest()
        {
            supplement = new Supplement("test", 5);
            Assert.That(() => factory.UpgradeRobot(robot, supplement), Is.EqualTo(true));
            Assert.AreEqual(robot.Supplements.Count, 1);
        }

        [Test]
        public void Test_SellRobots()
        {
            Robot tests1 = new Robot("neshto", 5, 5);
            Robot tests2 = new Robot("neshto", 4, 5);

            factory.Robots.Add(robot);
            factory.Robots.Add(tests1);
            factory.Robots.Add(tests2);

            Assert.That(() => factory.SellRobot(4), Is.EqualTo(tests2));
        }

    }
}