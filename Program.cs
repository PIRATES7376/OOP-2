using System;
using System.Collections.Generic;


namespace LAB_TASK_1._2
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static int[] FilterPrimeNumbers(int[] arr)
        {
            List<int> primeNumbers = new List<int>();

            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    primeNumbers.Add(num);
                }
            }

            return primeNumbers.ToArray();
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of elements in the first array:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {n1} elements for the first array:");
            int[] array1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of elements in the second array:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {n2} elements for the second array:");
            int[] array2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            int[] combinedArray = new int[n1 + n2];
            Array.Copy(array1, combinedArray, n1);
            Array.Copy(array2, 0, combinedArray, n1, n2);

            int[] primeNumbersArray = FilterPrimeNumbers(combinedArray);

            Console.WriteLine("Prime numbers from the combined arrays:");
            foreach (int prime in primeNumbersArray)
            {
                Console.WriteLine(prime);
            }
        }
    }
}