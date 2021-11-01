using System;

namespace CSharpDataStructuresAlgorithms.Sorting
{
    public class MergeSort
    {
        public int[] sort(int[] a, int left, int right)
        {
            if (left<right)
            {
                int mid = (left + right) / 2;
                // left side of array
                // this will keep the left side going until there are no mroe splits
                sort(a, left, mid);
                // right side of array
                // this will happen after all of the left side has been split and merged
                sort(a, mid+1, right);
                // merge arrays back
                merge(a, left, mid, right);
            }
            return a;
        }

        public void merge(int[] a, int left, int mid, int right)
        {
            int[] b = new int[a.Length + 1];
            int i = left;
            int j = mid + 1;
            int k = left;

            while(i<=mid && j<=right)
            {
                // If a[i] < a[j] set b[k] = a[i] and increment i
                if(a[i]<a[j])
                {
                    b[k] = a[i];
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    j++;
                }
                k++;
            }

            // fill in b[k] 
            while(i<=mid)
            {
                b[k] = a[i];
                i++;
                k++;
            }

            // fill in b[k]
            while(j<=right)
            {
                b[k] = a[j];
                j++;
                k++;
            }

            // copy everything back to a
            for(int x=left; x<right+1; x++)
            {
                a[x] = b[x];
            }            
        }
    }
}