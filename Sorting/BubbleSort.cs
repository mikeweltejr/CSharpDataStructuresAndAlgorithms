namespace CSharpDataStructuresAlgorithms.Sorting
{
    public class BubbleSort
    {
        public int[] sort(int[] a)
        {
            for(int pass=a.Length-1; pass>=0; pass--)
            {
                for(int i=0; i<pass; i++)
                {
                    if(a[i] > a[i+1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            }
            return a;
        }
    }
}