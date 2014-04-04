using System.Collections.Generic;

namespace RomanNumbers
{
    public class Roman
    {
        private static Dictionary<string, int> exceptions = new Dictionary<string, int> {{"IV", 4}, {"IX", 9}};

        private static Dictionary<char, int> digits = new Dictionary<char, int> {{'I', 1}, {'V', 5}, {'X', 10}};

        public static int ToDecimal(string roman)
        {
            int result = 0;

            foreach (var x in exceptions)
            {
                if (roman.Contains(x.Key))
                {
                    result += x.Value;
                    roman = roman.Replace(x.Key, "");
                }
            }

            foreach (var c in roman)
            {
                if (digits.ContainsKey(c))
                {
                    result += digits[c];
                }
            }

            return result;
        }
    }
}