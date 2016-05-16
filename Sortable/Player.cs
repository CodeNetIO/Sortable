using System;

namespace Sortable
{
    public class Player : IComparable<Player>
    {
        public Player(int initiative)
        {
            Initiative = initiative;
        }

        /// <summary>
        /// Gets or sets a value representing a player's encounter initiative.
        /// </summary>
        /// <remarks>A higher initiative means the player goes first.</remarks>
        public int Initiative { get; }

        /// <summary>Compares the current player's initiative with another players.</summary>
        /// <returns>0 if Initiatives are equal, -1 if this Initiative is greater than the 
        /// other's, and +1 if it is less.</returns>
        /// <param name="other">A player to compare initiatives with.</param>
        public int CompareTo(Player other)
        {
            // Note:  This sorts the players in descending order by initiative, which is
            //        typically the opposite of most sorting calls. This is one advantage of
            //        implementing the IComparable interface yourself. (Custom Behavior)

            if (this.Initiative == other.Initiative)
                return 0;
            else if (this.Initiative > other.Initiative)
                return -1;
            else if (this.Initiative < other.Initiative)
                return 1;
            else 
                return 1;
        }
    }
}
