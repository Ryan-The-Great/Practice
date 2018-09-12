using System;
using System.Collections.Generic;

namespace Practice
{
    public class PaintHouse
    {
        public int MinCost(int[,] costs)
        {
            if (costs == null || costs.Length < 1)
                return 0;
            else if (costs.GetLength(0) < 2)
                return Math.Min(costs[0, 0], Math.Min(costs[0, 1], costs[0, 2]));
            
            int[] totals = new int[] { costs[0, 0], costs[0, 1], costs[0, 2] };
            for (int r = 1; r < costs.GetLength(0); r++)
            {
                int[] preTotals = new int[totals.Length];
                Array.Copy(totals, preTotals, totals.Length);
                for (int c = 0; c < costs.GetLength(1); c++)
                    totals[c % 3] = costs[r, c % 3] + Math.Min(preTotals[(c + 1) % 3], preTotals[(c + 2) % 3]);
            }
            return Math.Min(totals[0], Math.Min(totals[1], totals[2]));
        }
    }

    public class WordDistance
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            int i1 = Int32.MaxValue, i2 = Int32.MaxValue;
            int minDist = Int32.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word1)
                    i1 = i;
                else if (words[i] == word2)
                    i2 = i;

                if (i1 < Int32.MaxValue && i2 < Int32.MaxValue)
                    minDist = Math.Min(minDist, Math.Abs(i1 - i2));
            }

            return minDist;
        }
    }

    public class WordDistanceII
    {
        private Dictionary<string, List<int>> dict;

        public WordDistanceII(string[] words)
        {
            dict = new Dictionary<string, List<int>>();
            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                    dict[words[i]].Add(i);
                else
                    dict.Add(words[i], new List<int>(new int[] { i }));
            }
        }

        public int Shortest(string word1, string word2)
        {
            int minDist = Int32.MaxValue;

            int li1 = 0, li2 = 0;
            while (li1 < dict[word1].Count && li2 < dict[word2].Count)
            {
                minDist = Math.Min(minDist, Math.Abs(dict[word1][li1] - dict[word2][li2]));
                if (dict[word1][li1] < dict[word2][li2])
                    li1++;
                else
                    li2++;
            }

            return minDist;
        }
    }

    public class NestedListWeightSum
    {
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            Queue<NestedInteger> q = new Queue<NestedInteger>();
            int total = 0;
            int level = 1;

            foreach (NestedInteger ni in nestedList)
                q.Enqueue(ni);

            while (q.Count > 0)
            {
                int qSize = q.Count;

                for (int i = 0; i < qSize; i++)
                {
                    NestedInteger temp = q.Dequeue();
                    if (temp.IsInteger())
                        total += (level * temp.GetInteger());
                    else
                    {
                        foreach (NestedInteger x in temp.GetList())
                            q.Enqueue(x);
                    }
                }

                level++;
            }

            return total;
        }

        public int DepthSumInverse(IList<NestedInteger> nestedList)
        {
            Queue<NestedInteger> q = new Queue<NestedInteger>();
            int total = 0, preTotal = 0;

            foreach (NestedInteger ni in nestedList)
                q.Enqueue(ni);

            while (q.Count > 0)
            {
                int qSize = q.Count;
                int levelTotal = 0;

                for (int i = 0; i < qSize; i++)
                {
                    NestedInteger temp = q.Dequeue();
                    if (temp.IsInteger())
                        levelTotal += temp.GetInteger();
                    else
                    {
                        foreach (NestedInteger x in temp.GetList())
                            q.Enqueue(x);
                    }
                }

                preTotal += levelTotal;
                total += preTotal;
            }

            return total;
        }
    }

    public class NestedInteger
    {
 
        // Constructor initializes an empty nested list.
        public NestedInteger(){}
 
        // Constructor initializes a single integer.
        public NestedInteger(int value){}

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        public bool IsInteger() { return default(bool); }

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        public int GetInteger() { return default(int); }
 
        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value){}
 
        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni){}

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        public IList<NestedInteger> GetList() { return null; }
    }

    public class TwoSumWithDict
    {
        Dictionary<int, int> numDict;

        /** Initialize your data structure here. */
        public TwoSumWithDict()
        {
            numDict = new Dictionary<int, int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (numDict.ContainsKey(number))
                numDict[number] += 1;
            else
                numDict.Add(number, 1);
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            foreach (KeyValuePair<int, int> kv in numDict)
            {
                int diff = value - kv.Key;
                if (numDict.ContainsKey(diff))
                {
                    if ((diff * 2) == value)
                    {
                        if (kv.Value > 1)
                            return true;
                    }
                    else
                        return true;
                }
            }

            return false;
        }
    }
}
