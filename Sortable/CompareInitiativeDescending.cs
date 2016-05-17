using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortable
{
    public class CompareInitiativeDescending : IComparer<Player>
    {
        /// <summary>Compares the iniatives of two players and returns results descendingly.</summary>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x" />
        /// and <paramref name="y" />, as shown in the following table.  Value Meaning Less than 
        /// zero<paramref name="x" /> is greater than <paramref name="y" />.  Zero<paramref name="x" /> 
        /// equals <paramref name="y" />.  Greater than zero<paramref name="x" /> is less than 
        /// <paramref name="y" />.</returns>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param> 
        /// <exception cref="ArgumentException">x is not a <see cref="Player"/> OR y is not a <see cref="Player"/>.</exception>
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

        /// <summary>Compares the iniatives of two players and returns results descendingly.</summary>
        /// <returns>A signed integer that indicates the relative values of <paramref name="x" />
        /// and <paramref name="y" />, as shown in the following table.  Value Meaning Less than 
        /// zero<paramref name="x" /> is greater than <paramref name="y" />.  Zero<paramref name="x" /> 
        /// equals <paramref name="y" />.  Greater than zero<paramref name="x" /> is less than 
        /// <paramref name="y" />.</returns>
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
