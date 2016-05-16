using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sortable.Tests
{
    [TestClass]
    public class PlayerTests
    {
        #region Utilities

        private List<Player> CreatePlayersWithInitiatives(int numberOfPlayers)
        {
            List<Player> result = new List<Player>(numberOfPlayers);

            for (var i = 0; i < numberOfPlayers; i++)
            {
                var initiative = new Random().Next(1,20);
                // unique initiative
                while (result.Any(p => p.Initiative == initiative))
                {
                    initiative = new Random().Next(1, 20);
                }
                result.Add(new Player(initiative));
            }

            return result;
        }
        #endregion

        [TestMethod]
        public void InitiativeOrderTest()
        {
            var players = CreatePlayersWithInitiatives(8);

             players.Sort();

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
