using System;

namespace CodingInterview.BigONotation
{
    public class BigOPracticeProblems
    {
        static void Main(string[] args)
        {
            
        }

        // Q: What's the time complexity? 
        // A: O(N + N) -> O(2N) = O(N)
        // 説明：Nはarray.Lengthを意味する。
        void practiceProblem1(int[] array)
        {
            int sum = 0;
            int product = 1;

            // first loop : A
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            // second loop : B
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine(sum + " : " + product);
        }

        // Q: What's the time complexity?
        // A: O(N*N) = O(N^2)
        // 説明：Nはarray.Lengthを意味する。
        void practiceProblem2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + ":" + array[j]);
                }
            }
        }

        // Q: What's the time complexity?
        // A: outer loop -> N (array's length).
        //    inner loop -> N-1 -> N-2 -> N- 3... but constants don't matter anyway
        //    so, O(N^2)
        void practiceProblem3(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // jがi +1 からスタート!
                for (int j = i + 1; j < array.Length; j++)
                {
                    Console.WriteLine(array[i] + ":" + array[j]);
                }
            }
        }

        void practiceProblem4(int[] arrayA, int[] arrayB)
        {
            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    Console.WriteLine(arrayA[i] + arrayB[j]);
                }
            }
        }
    }
}