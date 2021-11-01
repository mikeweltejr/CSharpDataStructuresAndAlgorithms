namespace CSharpDataStructuresAlgorithms.Sorting
{
    public class ShellSort
    {
        public int[] sort(int[] a)
        {
            // { 100, 45, 3, 2, 5, 34, 23 };
            // { 2, 45, 3, 100, 5, 34, 23 }
            // { 2, 5, 3, 100, 45, 34, 23 }
            // { 2, 5, 3, 23, 45, 34, 100 }
            // { 2, 3, 5, 23, 45, 34, 100 }
            // { 2, 3, 5, 23, 34, 45, 100 }
            int gap = a.Length / 2;
            while(gap > 0)
            {
                int i = gap;
                while (i<a.Length)
                {
                    int temp = a[i];
                    int j = i - gap;

                    while(j>=0 && a[j] > temp)
                    {
                        a[j+gap] = a[j];
                        j = j - gap;
                    }
                    a[j+gap] = temp;
                    i++;
                }
                gap = gap/2;
            }
            return a;
        }
    }
}