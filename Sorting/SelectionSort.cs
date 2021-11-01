using System.Collections.Generic;

namespace CSharpDataStructuresAlgorithms.Sorting
{
    public class SelectionSort
    {
        public int[] sort(int[] a)
        {
            for(int i=0; i<a.Length-1; i++)
            {
                int position = i;
                for(int j=i+1; j<a.Length; j++)
                {
                    if(a[j] < a[position])
                        position = j;
                }
                int temp = a[i];
                a[i] = a[position];
                a[position] = temp;
            }

            return a;
        }
    }
}