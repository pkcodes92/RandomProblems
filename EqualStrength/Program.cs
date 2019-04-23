namespace EqualStrength
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int yourLeft = 10;
            int yourRight = 15;
            int friendsLeft = 15;
            int friendsRight = 10;

            bool result = AreEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight);

            Console.WriteLine($"Final result: {result}");
        }

        static bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            bool leftsEqual = false;
            bool rightsEqual = false;
            bool bothEqual;

            if ((yourRight == friendsRight) && (yourLeft == friendsLeft))
            {
                leftsEqual = true;
                rightsEqual = true;
            }
            else if ((yourRight == friendsLeft) && (friendsRight == yourLeft))
            {
                leftsEqual = true;
                rightsEqual = true;
            }

            if (leftsEqual && rightsEqual)
            {
                bothEqual = true;
            }
            else
            {
                bothEqual = false;
            }

            return bothEqual;
        }
    }
}