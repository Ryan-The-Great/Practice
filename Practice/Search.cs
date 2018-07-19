using System;
namespace Practice
{
    public class Search
    {
        public static int BinarySearch(int[] ary, int left, int right, int target)
        {
            //not found
            if (ary == null || ary.Length < 1 || left > right)
                return -1;

            int mid = left + ((right - left)/ 2); //left + right / 2 might run into overflow for large left, right

            if (target == ary[mid])
                return mid;
            else if (target < ary[mid])
            {
                return BinarySearch(ary, left, mid - 1, target);
            }
            else
            {
                return BinarySearch(ary, mid + 1, right, target);
            }
        }

    }
}
