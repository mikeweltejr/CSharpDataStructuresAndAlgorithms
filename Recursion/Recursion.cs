using System;

namespace CSharpDataStructuresAlgorithms
{
    public class Recursion
    {
        // Tail recursion
        public void calculateTail(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculateTail(n-1);
            }
        }

        // Head Recursion
        public void calculateHead(int n)
        {
            if (n > 0)
            {
                calculateHead(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        // Tree Recursion
        public void calculateTree(int n)
        {
            if (n > 0)
            {
                calculateTree(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                calculateTree(n -1);
            }
        }

        // Sum of natural numbers
        public int sum(int n)
        {
            if (n == 0) return 0;
            return sum(n -1) + n;
        }

        public int factorial(int n)
        {
            if (n==0) return 1;
            return (factorial(n-1) * n);
        }  
    }
}