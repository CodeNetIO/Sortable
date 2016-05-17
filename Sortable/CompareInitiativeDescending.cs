using System;
using System.Collections.Generic;

namespace Sortable
{
    public class CompareInitiativeDescending : IComparer<Player>
    {
        /// <summary>
        /// Compares the iniatives of two players and returns results descendingly.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param> 
        /// <exception cref="ArgumentException">
        /// x is not a <see cref="Player"/>
        /// OR
        /// y is not a <see cref="Player"/>.
        /// </exception>
        public int Compare(object x, object y)
        {
            var playerX = (x as Player);
            var playerY = (y as Player);
            if (playerX == null || playerY == null)
            {
                throw new ArgumentException(
                    "Both objects must be of type Player to be compared.");
            }
            return Compare(playerX, playerY);
        }

        /// <summary>
        /// Compares the iniatives of two players and returns results descendingly.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        public int Compare(Player x, Player y)
        {
            if (x.Initiative == y.Initiative)
                return 0;

            if (x.Initiative > y.Initiative)
                return -1;

            return 1;
        }
    }
}
