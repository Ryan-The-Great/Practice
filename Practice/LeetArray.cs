using System;
using System.Collections.Generic;

namespace Practice
{
    public class LeetArray
    {
        public LeetArray()
        {
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> intersection = new List<int>();
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int[] large, small;

            if (nums1.Length < 1 || nums2.Length < 1)
                return new int[] { };

            if (nums1.Length >= nums2.Length)
            {
                large = nums1;
                small = nums2;
            }
            else
            {
                large = nums2;
                small = nums1;
            }

            foreach (int val in large)
            {
                if (freq.ContainsKey(val))
                    freq[val] += 1;
                else
                    freq[val] = 1;
            }

            foreach (int val in small)
            {
                if (freq.ContainsKey(val) && freq[val] > 0)
                {
                    intersection.Add(val);
                    freq[val] -= 1;
                }
            }

            // Slow O(m + n)
            /*
            Array.Sort(large);
            Array.Sort(small);

            int i = 0, j = 0;

            while (i < large.Length && j < small.Length)
            {
                if (large[i] == small[j])
                {
                    intersection.Add(large[i]);
                        j++;
                        i++;
                }
                else if (large[i] < small[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }

            }
            */

            return intersection.ToArray();
        }

        public static int MaxProfit(int[] prices)
        {
            //can be done by 
            /*

            int N = prices.Length;
        
            if (N<=1) return 0;
            
            int [] max = new int[N];
            
            max[0]=0;
            for(int i=1;i<N;i++){
                max[i]= prices[i]-prices[i-1];
            }
            
            int profit=0;
            for(int i=1;i<N;i++){
                profit = profit + Math.Max(max[i],0);
            }
            
            */

            bool isPurchased = false;
            int purchasePrice = default(int);
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (!isPurchased && prices[i + 1] > prices[i])
                {
                    isPurchased = true;
                    purchasePrice = prices[i];
                }

                if (isPurchased && prices[i + 1] <= prices[i])
                {
                    isPurchased = false;
                    profit += prices[i] - purchasePrice;
                }
            }

            if (isPurchased) //sell at the last tick
                profit += prices[prices.Length - 1] - purchasePrice;

            return profit;
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> theSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (theSet.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    theSet.Add(nums[i]);
                }
            }
            return false;
        }

        public static int[] PlusOne(int[] digits)
        {
            digits[digits.Length - 1] += 1;

            for (int i = digits.Length - 1; i >= 1; i--)
            {
                if (digits[i] > 9)
                {
                    digits[i] = 0;
                    digits[i - 1] += 1;
                }
            }

            if (digits[0] >= 10)
            {
                digits[0] = 0;
                List<int> temp = new List<int>(digits);
                temp.Insert(0, 1);
                digits = temp.ToArray();
            }
            return digits;
        }

        public static void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;

            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    if (zeroCount > 0)
                    {
                        nums[i - zeroCount] = nums[i];
                        nums[i] = 0;
                    }
                }

                if (i > nums.Length - 1 - zeroCount)
                {
                    nums[i] = 0;
                }
            }
        }

        public static void Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int col = 0; col < n / 2; col++)
            {
                for (int row = 0; row < n - 1 - col; row++)
                {
                    int temp = matrix[row, col];
                    int newCol = n - 1 - row;
                    int newRow = col;

                    matrix[col, row] = matrix[newCol, newRow];

                    while (newCol != col || newRow != row)
                    {
                        int newTemp = matrix[newRow, newCol];
                        matrix[newRow, newCol] = temp;
                        temp = newTemp;

                        int tempRow = newRow;

                        newRow = newCol;
                        newCol = n - 1 - tempRow;

                    }
                }
            }
        }
    }
}
