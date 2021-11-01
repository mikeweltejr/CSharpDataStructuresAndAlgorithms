using System;

namespace CSharpDataStructuresAlgorithms.Heaps
{
    public class HeapSort
    {
        public int[] Sort(int[] a, int n)
        {
            var heap = new Heap();
            for(int i=0; i<n; i++)
            {
                heap.Insert(a[i]);
            }

            int k = n-1;
            for(int i=0; i<n; i++)
            {
                a[k] = heap.DeleteMax();
                k--;
            }

            return a;
        }

        public void Display(int[] a, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        } 
    }
}