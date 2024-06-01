using NUnit.Framework;
using System.Linq;

namespace RobotFactory.Tests
{
    public class FactoryTests
    {
        private Factory fact;
        [SetUp]
        public void Setup()
        {
            fact = new("Iva", 55);
        }

        [Test]
        public void ContructorItsWorkCorrect()
        {
            string expectedName = "Iva";
            int expectedCapacity = 55;

            Assert.AreEqual(expectedName,fact.Name);
            Assert.AreEqual(expectedCapacity, fact.Capacity);
            Assert.NotNull(fact.Robots);
            Assert.NotNull(fact.Supplements);
        }
        [Test]
        public void NameSetterItsWorkCorrect()
        {
            string expectedName = "IvR";
            fact.Name = expectedName;
            Assert.AreEqual(expectedName,fact.Name);
        }
        [Test]
        public void CapacitySetterItsWorkCorrect()
        {
            int expectedCapacity = 33;
            fact.Capacity = expectedCapacity;
            Assert.AreEqual(expectedCapacity, fact.Capacity);
        }
        [Test]
        public void ProduceRobotShouldNotAddRobotToInnerCollectionWhenCapacityLimitIsReached()
        {
            string expectedMessage = $"The factory is unable to produce more robots for this production day!";

            fact.Capacity = 0;

            string actualMessage = fact.ProduceRobot("Terminator", 1000.2341, 24);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ProduceSupplemenShouldAddSuplementToInnerCollection()
        {
            Supplement expectedSupplement = new("Laser", 25);

            string expectedMessage = $"Supplement: {expectedSupplement.Name} IS: {expectedSupplement.InterfaceStandard}";

            string actualMessage = fact.ProduceSupplement(expectedSupplement.Name, expectedSupplement.InterfaceStandard);

            Supplement actualSupplement = fact.Supplements.Single();

            Assert.AreEqual(expectedSupplement.Name, actualSupplement.Name);
            Assert.AreEqual(expectedSupplement.InterfaceStandard, actualSupplement.InterfaceStandard);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}