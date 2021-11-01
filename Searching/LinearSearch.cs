namespace CSharpDataStructuresAlgorithms.Searching
{
    public class LinearSearch
    {
        public int linearSearch(int[] a, int key)
        {
            int index = 0;
            while(index < a.Length)
            {
                if(a[index] == key) return index;

                index = index + 1;
            }
            return -1;
        }
    }
}