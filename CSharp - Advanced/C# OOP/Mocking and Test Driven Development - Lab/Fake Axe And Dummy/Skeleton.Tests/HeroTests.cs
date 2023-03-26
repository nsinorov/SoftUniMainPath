
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    private Mock<IWeapon> weapon;
    private Mock<ITarget> target;
    private Hero hero;

    [SetUp]
    public void Setup()
    {
        this.weapon = new Mock<IWeapon>();
        this.target = new Mock<ITarget>();
        this.hero = new Hero("Ico", weapon.Object);
    }

    [Test]
    public void Attack_AttackPointsEnoughToKillTarget_HeroGainsExperience()
    {      
        var expectedExperience = 50;

        this.target
            .Setup(t => t.Health)
            .Returns(0);
        this.target
            .Setup(t => t.GiveExperience())
            .Returns(expectedExperience);
        this.target
            .Setup(t => t.IsDead())
            .Returns(true);

        this.hero.Attack(this.target.Object);

        Assert.That(this.hero.Experience, Is.EqualTo(expectedExperience));
    }
}