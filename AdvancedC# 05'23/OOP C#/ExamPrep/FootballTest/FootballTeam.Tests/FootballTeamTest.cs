using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FootballTeam.Tests
{
    public class Tests
    {
        

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            FootballTeam team = new FootballTeam("CSKA", 21);
            Assert.IsNotNull(team);
            Assert.AreEqual("CSKA", team.Name);
            Assert.AreEqual(21, team.Capacity);
            
            Type t = team.Players.GetType();
            Type expectedType = typeof(List<FootballPlayer>);

            Assert.AreEqual(t, expectedType);
        }
        [TestCase(null)]
        [TestCase("")]
        public void NameShouldThrowArgumentExceptionIfNullOrEmpty(string name)
        {
            FootballTeam team = new FootballTeam("CSKA", 21);
            Assert.Throws<ArgumentException>( () => team.Name = name, "Name cannot be null or empty!");
        }
        [TestCase(0)]
        [TestCase(5)]
        public void CapacitySouldThrowArgumentExceptionIfLessThan15(int capacity)
        {
            FootballTeam team = new FootballTeam("CSKA", 21);
            Assert.Throws<ArgumentException>(() => team.Capacity = capacity, "Capacity min value = 15");
        }
        public void AddMethodShouldAddPlayerCorrectly()
        {
            FootballTeam team = new FootballTeam("CSKA", 21);
            FootballPlayer player = new FootballPlayer("Hristo", 4, "deffender");
            string expectedMessage = team.AddNewPlayer(player);
            Assert.AreEqual(1,team.Players.Count);
            Assert.AreEqual(expectedMessage, $"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}");
        }
    }
}