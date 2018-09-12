using System;
namespace Practice
{
    public class Sort
    {
        public static void SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length-1; i++)
            {
                int temp = input[i];
                for (int j = i+1; j < input.Length; j++)
                {
                    if(input[j] < temp)
                    {
                        Swap(input, i, j);
                        //temp = input[j];
                        //input[j] = input[i];
                        //input[i] = temp;
                    }
                }
            }
        }

        public static void BubbleSort(int[] input)
        {
            
            for (int n = input.Length - 1; n > 0 ; n--)
            {
                bool isSorted = true;
                for (int i = 0; i < n; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        isSorted = false;
                        Swap(input, i, i + 1);
                    }
                }
                if (isSorted)
                    break;
            }
        }

        public static void InsertionSort(int[] input)
        {
            for (int n = 1; n < input.Length; n++)
            {
                int val = input[n];
                int i = n-1;

                //from 1 element before the marker, shift everything to the right that is less than the marker value
                while (i >= 0 && input[i] > val)
                {
                    input[i + 1] = input[i];
                    i--;
                }
                //i + 1 to compansaate the last i-- from while loop
                input[i+1] = val;
            }
        }

        public static void MergeSort(int[] input, int l, int r)
        {
            if (r > l) //more than 1 element
            {
                int m = l + (r - l) / 2;
                MergeSort(input, l, m);
                MergeSort(input, m + 1, r);

                Merge(input, l, m, r);
            }
        }

        public static void QuickSort(int[] input, int l, int r)
        {
            
        }

        public static void Partition(int[] input)
        {
            
        }

        public static void Merge(int[] input, int l, int m, int r)
        {
            //merging
            int nl = m - l + 1, nr = r - m;
            int[] L = new int[nl], R = new int[nr];

            for (int i = 0; i < nl; i++)
            {
                L[i] = input[l + i];
            }
            for (int i = 0; i < nr; i++)
            {
                R[i] = input[m + i + 1];
            }

            int li = 0, ri = 0;

            int ini = l;

            while (li < L.Length && ri < R.Length)
            {
                if (L[li] < R[ri])
                {
                    input[ini++] = L[li++];
                }
                else
                {
                    input[ini++] = R[ri++];
                }
            }

            while (li < L.Length)
            {
                input[ini++] = L[li++];
            }

            while (ri < R.Length)
            {
                input[ini++] = R[ri++];
            }
        }

        public static void Swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
