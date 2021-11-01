namespace CSharpDataStructuresAlgorithms.Searching
{
    public class BinarySearch
    {
        public int iterativeSearch(int[] a, int key)
        {
            int left = 0;
            int right = a.Length - 1;

            while (left <= right)
            {
                int m = (left + right) / 2;
                if(key == a[m])
                    return m;
                else if(key < a[m])
                    right = m - 1;
                else if(key > a[m])
                    left = m + 1;
            }
            return -1;
        }

        public int recursiveSearch(int[] a, int key, int left, int right)
        {
            if (left > right) return -1;

            int m = (left + right) / 2;
            if (key == a[m]) 
                return m;
            else if(key < a[m])
                return recursiveSearch(a, key, left, m - 1);
            else if(key > a[m])
                return recursiveSearch(a, key, m + 1, right);

            return -1;
        }
    }
}