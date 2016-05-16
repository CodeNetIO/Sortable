using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortable
{
    public class CompareInitiativeDescending : IComparer<Player>
    {
        /// <summary>
        /// Supports comparing two objects that are of type Player.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            var playerX = (x as Player);
            var playerY = (y as Player);
            if (playerX == null || playerY == null)
            {
                throw new ArgumentException("Both objects must be of type Player to be compared.");
            }
            return Compare(playerX, playerY);
        }

        /// <summary>Compares two objects and returns a value indicating whether one is less than, 
        /// equal to, or greater than the other.</summary>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x" />
        /// and <paramref name="y" />, as shown in the following table.Value Meaning Less than 
        /// zero<paramref name="x" /> is less than <paramref name="y" />.Zero<paramref name="x" /> 
        /// equals <paramref name="y" />.Greater than zero<paramref name="x" /> is greater than 
        /// <paramref name="y" />.</returns>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        public int Compare(Player x, Player y)
        {
            if (x.Initiative == y.Initiative)
                return 0;
            else if (x.Initiative > y.Initiative)
                return -1;
            else if (x.Initiative < y.Initiative)
                return 1;
            else
                return 1;
        }
    }
}
