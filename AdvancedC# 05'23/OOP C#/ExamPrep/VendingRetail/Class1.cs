using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingRetail;

namespace VendingRetail.Tests
{
    [TestClass]
    public class CoffeeMatTests
    {
        [TestMethod]
        public void FillWaterTank_ShouldFillWaterTank_WhenNotFull()
        {
            // Arrange
            CoffeeMat coffeeMat = new CoffeeMat(1000, 5);

            // Act
            string result = coffeeMat.FillWaterTank();

            // Assert
            Assert.AreEqual($"Water tank is filled with {coffeeMat.WaterCapacity}ml", result);
            Assert.AreEqual(coffeeMat.WaterCapacity, coffeeMat.WaterTankLevel);
        }

        [TestMethod]
        public void AddDrink_ShouldAddDrink_WhenSpaceAvailable()
        {
            // Arrange
            CoffeeMat coffeeMat = new CoffeeMat(1000, 5);

            // Act
            bool result = coffeeMat.AddDrink("Espresso", 2.5);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, coffeeMat.Drinks.Count);
        }

        [TestMethod]
        public void BuyDrink_ShouldBuyDrink_WhenAvailableAndEnoughWater()
        {
            // Arrange
            CoffeeMat coffeeMat = new CoffeeMat(1000, 5);
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("Espresso", 2.5);

            // Act
            string result = coffeeMat.BuyDrink("Espresso");

            // Assert
            Assert.AreEqual($"Your bill is 2.50$", result);
            Assert.AreEqual(920, coffeeMat.WaterTankLevel);
            Assert.AreEqual(2.5, coffeeMat.Income);
        }

        [TestMethod]
        public void BuyDrink_ShouldReturnNotAvailable_WhenDrinkNotAvailable()
        {
            // Arrange
            CoffeeMat coffeeMat = new CoffeeMat(1000, 5);
            coffeeMat.FillWaterTank();

            // Act
            string result = coffeeMat.BuyDrink("Cappuccino");

            // Assert
            Assert.AreEqual("Cappuccino is not available!", result);
            Assert.AreEqual(1000, coffeeMat.WaterTankLevel);
            Assert.AreEqual(0, coffeeMat.Income);
        }

        [TestMethod]
        public void CollectIncome_ShouldReturnCollectedIncome_AndResetIncome()
        {
            // Arrange
            CoffeeMat coffeeMat = new CoffeeMat(1000, 5);
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("Espresso", 2.5);
            coffeeMat.BuyDrink("Espresso");

            // Act
            double collectedIncome = coffeeMat.CollectIncome();

            // Assert
            Assert.AreEqual(2.5, collectedIncome);
            Assert.AreEqual(0, coffeeMat.Income);
        }

    }
}
