namespace CSharpDataStructuresAlgorithms.Sorting
{
    public class InsertionSort
    {
        public int[] sort(int[] a)
        {
            // [ 2, 3, 5, 1, 4 ]
            for(int i=0; i<a.Length-1; i++)
            {
                int val = a[i];
                int position = i;

                while(position > 0 && a[position - 1] > val)
                {
                    a[position] = a[position - 1];
                    position--;
                }
                a[position] = val;
            }

            return a;
        }
    }
}