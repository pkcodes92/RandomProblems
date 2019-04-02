namespace LuhnValidator
{
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class Luhn
    {
        public static bool IsValid(string number)
        {
            var str = Regex.Replace(number, "\\s+", "");
            var length = str.Length; 

            if (length < 2)
            {
                return false;
            }

            var isNumeric = long.TryParse(str, out long _);

            if (!isNumeric)
            {
                return false;
            }

            return Enumerable.Range(0, length).Select(i => ConvertToDigit(i, str[length - i - 1])).Sum() % 10 == 0; 
        }

        private static int ConvertToDigit(int indexFromRight, char c)
        {
            var i = (int)char.GetNumericValue(c);

            if (indexFromRight % 2 == 1)
            {
                i *= 2;
            }

            if (i > 9)
            {
                i -= 9;
            }

            return i; 
        }
    }
}