using System;
using System.Collections.Generic;

namespace Practice
{

    public class ListNode {
       public int val;
       public ListNode next;
       public ListNode(int x) { val = x; }
    }
 

    class MainClass
    {
        public static void Main(string[] args)
        {
            PaintHouse paint = new PaintHouse();

            int[,] input = { { 17, 2, 17 }, { 16, 16, 5 }, { 14, 3, 19 } };
            //int[,] input = { { 5, 8, 6},{ 19, 14, 13},{ 7, 5, 12},{ 14, 15, 17},{ 3, 20, 10} };
            paint.MinCost(input);

            //TwoSum twoSum = new TwoSum();
            //twoSum.Add(1);
            //twoSum.Add(3);
            //twoSum.Add(5);
            //twoSum.Find(4);
            //twoSum.Find(7);

            //String[] input = new string[] { "practice", "makes", "perfect", "coding", "makes" };
            //int result = LeetString.ShortestDistance(input, "practice", "coding");

            //LeetString.Reverse(-2147483648);

            //int[,] matrix = new int[,]
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9}
            //};

            //LeetArray.Rotate(matrix);



            //BinarySearchExample();
            //SelectionSortExample();
            //BubbleSortExample();
            //BSTExample();
            //VarScopeExample();
            //InsertionSortExample();
            //MergeSortExample();

            //LeetArray.Intersect(new int[] { 1 }, new int[] { 1 });


            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //IsPalindrome(head);
        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;

            ListNode fast = head.next, slow = head, mid = null;
            ListNode pre = null, cur = slow, next = null;

            while (fast != null)
            {
                if (fast.next == null) //even list
                {
                    mid = slow.next;
                    fast = null;
                }
                else if (fast.next.next == null) //odd list
                {
                    mid = slow.next.next;
                    fast = null;
                }
                else
                    fast = fast.next.next;

                next = slow.next;
                slow.next = pre;
                pre = slow;

                if(fast != null)
                    slow = next;
            }

            while (slow != null && mid != null)
            {
                if (slow.val != mid.val)
                    return false;

                slow = slow.next;
                mid = mid.next;
            }

            if (slow == null && mid == null)
                return true;
            else
                return false;
        }

        public static void BinarySearchExample()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = Search.BinarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }

        public static void SelectionSortExample()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Sort.SelectionSort(arr);
            Console.WriteLine(String.Join(",", arr));
        }

        public static void BubbleSortExample()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Sort.BubbleSort(arr);
            Console.WriteLine(String.Join(",", arr));
        }

        public static void InsertionSortExample()
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            Sort.InsertionSort(arr);
            Console.WriteLine(String.Join(",", arr));
        }

        public static void MergeSortExample()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Sort.MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(",", arr));
        }

        public static void BSTExample()
        {
            BST bst = new BST();

            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);
            bst.Insert(40);
            bst.InOrderTraverse();

            Console.WriteLine(String.Format("50 found? {0}", bst.Search(50)));
            Console.WriteLine(String.Format("50 found? {0}", bst.Search(40)));
            Console.WriteLine(String.Format("50 found? {0}", bst.Search(80)));
            Console.WriteLine(String.Format("50 found? {0}", bst.Search(100)));

            Console.WriteLine(String.Format("Min value in BST is: " + bst.MinValNode().val));
        }

        public static void VarScopeExample()
        {
            VarScope.Test();
        }
    }
}
