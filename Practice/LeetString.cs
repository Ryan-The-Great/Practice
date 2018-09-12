using System;
namespace Practice
{
    public class LeetString
    {
        public static int Reverse(int x)
        {
            bool isNegative = x < 0 ? true : false;
            if (isNegative)
            {
                int temp;
                if (!Int32.TryParse(x.ToString().Substring(1), out temp))
                    return 0;
                else
                    x = x * -1;
            }

            char[] xChar = x.ToString().ToCharArray();
            int n = xChar.Length;

            for (int i = 0; i < (n / 2); i++)
            {
                char temp = xChar[i];
                xChar[i] = xChar[n - 1 - i];
                xChar[n - 1 - i] = temp;
            }

            try
            {
                int result = Int32.Parse(new String(xChar));
                if (isNegative)
                    result *= -1;
                return result;
            }
            catch (OverflowException)
            {
                return 0;
            }

        }

        public static int ShortestDistance(string[] words, string word1, string word2)
        {
            int minDist = Int32.MaxValue;
            int i1 = -1, i2 = -1;
            for (int i = 0; i < words.Length; i++)
            {
                bool isMatch = false;
                if (words[i].Equals(word1))
                {
                    isMatch = true;
                    i1 = i;
                }
                else if (words[i].Equals(word2))
                {
                    i2 = i;
                    isMatch = true;
                }

                if (i1 > -1 && i2 > -1 && isMatch)
                {
                    int dist = Math.Abs(i1 - i2);
                    if (dist < minDist)
                        minDist = dist;
                }
            }
            return minDist;
        }
    }
}
