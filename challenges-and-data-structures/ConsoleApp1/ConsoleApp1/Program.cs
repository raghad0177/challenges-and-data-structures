using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Challenge 1
           // A    
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] result = ArrayReversal(arr);
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

            // Challenge 1
            // B
            int[] test1 = { 1, 2, 3, 4, 5, 6 };
            int[] test2 = { 2, 3, 3, 4, 4, 6, 6, 9 };
            Console.WriteLine("");
            Console.WriteLine(MostFrequentNumber(test1));
            Console.WriteLine(MostFrequentNumber(test2));  

            // Challenge 2
            int[] test3 = { 2, 3, 4, 6, 9 };
            Console.WriteLine(MaximumValue(test3));

            // Challenge 3
            int[] test4 = { 2, 3, 4, 6, 9, 7 };
            int[] result2 = RemoveMiddleValue(test4);
            foreach (int num in result2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(" ");
            // Challenge 4
            int[] test5 = { 2, 3, 4, 6, 9 };
            int[] result3 = MiddleValue(test5, 10);
            foreach (int num in result3)
            {
                Console.Write(num + " ");
            }
        }


        //// Challenge 1 A
        static int[] ArrayReversal(int[] x)
        {
            int[] y = new int[x.Length];
            int count = 0;
            for (int i = x.Length - 1; i >= 0; i--)
            {
                y[count] = x[i];
                count++;
            }
            return y;
        }


        //// Challenge 1 B
        static int MostFrequentNumber(int[] x)
        {
            int result = 0;
            int max = 0;
            int maxres = 0;
            for (int i = 0; i < x.Length; i++)
            {
                max = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[i] == x[j])
                    {
                        max++;
                    }
                }
                if (max > result || (max == result && x[i] < maxres))
                {
                    maxres = x[i];
                    result = max;
                }
                if (max == 0)
                {
                    maxres = x[0];
                }

            }
            return maxres;
        }

        //// Challenge 2 
        static int MaximumValue(int[] x)
        {
            int Max = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > Max)
                {
                    Max = x[i];
                }
            }
            return Max;
        }

        //// Challenge 3
        static int[] RemoveMiddleValue(int[] x)
        {
            int[] arr2 = new int[x.Length - 1];
            int Count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x.Length % 2 == 0)
                {
                    if (i == x.Length / 2)
                    {
                        continue;
                    }
                    else
                    {
                        arr2[Count] = x[i];
                        Count++;
                    }
                }
                if (x.Length % 2 != 0)
                {
                    if (i == x.Length / 2)
                    {
                        continue;
                    }
                    else
                    {
                        arr2[Count] = x[i];
                        Count++;
                    }
                }
            }
            return arr2;
        }
        // Challenge 4 
        static int[] MiddleValue(int[] arr , int value)
        {
            int[] arr2 = new int[arr.Length + 1];
            int mid = (arr.Length + 1) / 2;

            for (int i = 0, j = 0; i < arr2.Length; i++)
            {
                if (i == mid)
                {
                    arr2[i] = value;
                }
                else
                {
                    arr2[i] = arr[j];
                    j++;
                }
            }

            return arr2;
        }
    }
}











