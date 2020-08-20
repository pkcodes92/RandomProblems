namespace TowersOfHanoiApp
{
    using System;

    /// <summary>
    /// This is the tower of hanoi class.
    /// </summary>
    public class TowerOfHanoi
    {
        int m_numDiscs;

        /// <summary>
        /// This initializes an instance of <see cref="TowerOfHanoi"/>.
        /// </summary>
        public TowerOfHanoi()
        {
            NumDiscs = 0; 
        }

        /// <summary>
        /// Tower of Hanoi constructor.
        /// </summary>
        /// <param name="newVal">The new value.</param>
        public TowerOfHanoi(int newVal)
        {
            NumDiscs = newVal;
        }

        /// <summary>
        /// Gets or sets the number of discs.
        /// </summary>
        public int NumDiscs
        {
            get { return m_numDiscs; }
            set
            {
                if (value > 0)
                {
                    m_numDiscs = value;
                }
            }
        }

        /// <summary>
        /// This method moves the tower from one peg to another.
        /// </summary>
        /// <param name="n">The number of discs.</param>
        /// <param name="from">The original peg.</param>
        /// <param name="to">The destination peg.</param>
        /// <param name="other">The remaining discs.</param>
        public void MoveTower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                MoveTower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                MoveTower(n - 1, other, to, from); 
            }
        }
    }
}