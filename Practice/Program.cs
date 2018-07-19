using System;

namespace Practice
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            //BinarySearchExample();
            //SelectionSortExample();
            //BubbleSortExample();
            //BSTExample();
            VarScopeExample();
        }

        public static void BinarySearchExample()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 41;

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
