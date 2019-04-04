namespace TowersOfHanoiApp
{
    using System;

    public class TowerOfHanoi
    {
        int m_numDiscs;

        public TowerOfHanoi()
        {
            NumDiscs = 0; 
        }

        public TowerOfHanoi(int newVal)
        {
            NumDiscs = newVal;
        }

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