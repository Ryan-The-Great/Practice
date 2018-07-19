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
                        temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                    }
                }
            }
        }

        public static void BubbleSort(int[] input)
        {
            
            for (int n = 0; n < input.Length - 1; n++)
            {
                bool isSorted = true;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        isSorted = false;
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                    }
                }
                if (isSorted)
                    break;
            }
        }
    }
}
