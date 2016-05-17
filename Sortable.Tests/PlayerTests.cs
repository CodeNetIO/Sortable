using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sortable.Tests
{
    [TestClass]
    public class PlayerTests
    {
        #region Utilities
        /// <summary>
        /// Creates players to test with
        /// </summary>
        /// <param name="numberOfPlayers">The number of players to create.</param>
        /// <returns>A List of players with initiatives set.</returns>
        private List<Player> CreatePlayers(int numberOfPlayers)
        {
            var result = new List<Player>(numberOfPlayers);

            for (var i = 0; i < numberOfPlayers; i++)
            {
                var player = new Player();
                player.RollInitiative();

                // make sure each player has a unique initiative
                while (result.Any(p => p.Initiative == player.Initiative))
                {
                    player.RollInitiative();
                }

                // get some experience
                player.AddExperiencePoints(new Random().Next(1,1000));
                result.Add(player);
            }

            return result;
        }
        #endregion

        [TestMethod]
        public void DefaultSortTest()
        {
            // Sorts based on experience
            var players = CreatePlayers(8);

             players.Sort();

            for (var i = 0; i < players.Count - 1; i++)
            {
                if (players[i].ExperiencePoints >= players[i + 1].ExperiencePoints)
                {
                    Assert.Fail("Order is not ascending.");
                }
            }

        }

        [TestMethod]
        public void InitiativeSortDescendingTest()
        {
            var players = CreatePlayers(8);

            players.Sort(new CompareInitiativeDescending());

            for (var i = 0; i < players.Count - 1; i++)
            {
                if (players[i].Initiative <= players[i + 1].Initiative)
                {
                    Assert.Fail("Order is not descending.");
                }
            }

        }
    }
}
