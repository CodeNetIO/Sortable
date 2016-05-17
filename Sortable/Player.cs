using System;

namespace Sortable
{
    /// <summary>
    /// Represents a player
    /// </summary>
    public class Player : IComparable<Player>
    {

        #region Public Properties
        /// <summary>
        /// Gets the player's encounter initiative.
        /// </summary>
        public int Initiative { get; private set; }

        /// <summary>
        /// Gets the player's level.
        /// </summary>
        public int Level => ExperiencePoints / 10;

        /// <summary>
        /// Gets the player's experience points.
        /// </summary>
        public int ExperiencePoints { get; private set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Adds experience points
        /// </summary>
        /// <param name="exp">The number of experience points to add.</param>
        public void AddExperiencePoints(int exp)
        {
            ExperiencePoints += exp;
        }
        #endregion

        /// <summary>
        /// Randomly sets the initiative to a number between 1 and 20 inclusively.
        /// </summary>
        public void RollInitiative()
        {
            Initiative = new Random().Next(1, 20);
        }

        #region IComparable Implementation
        /// <summary>Compares the current player's experience with another player's.</summary>
        /// <returns>0 if experience is equal, +1 if greater than the other, or -1 if less.</returns>
        /// <param name="other">A player to compare experience with.</param>
        /// <exception cref="ArgumentException">Object is not a <see cref="Player"/>.</exception>
        public int CompareTo(object other)
        {
            var player = (other as Player);
            if (player == null)
            {
                throw new ArgumentException("Object to be compared is not a player.", nameof(player));
            }
            return CompareTo(player);
        }

        /// <summary>Compares the current player's experience with another player's.</summary>
        /// <returns>0 if experience is equal, +1 if greater than the other, or -1 if less.</returns>
        /// <param name="other">A player to compare experience with.</param>
        public int CompareTo(Player other)
        {
            // equal to other
            if (this.Initiative == other.Initiative)
                return 0;

            // greater than other
            if (this.Initiative > other.Initiative)
                return 1;

            // less than other
            return -1;
        }
        #endregion
    }
}
