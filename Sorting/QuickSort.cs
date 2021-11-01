namespace CSharpDataStructuresAlgorithms.Sorting
{
    public class QuickSort
    {
        public int[] sort(int[] a, int low, int high)
        {   
            if (low < high)
            {
                int pi = partition(a, low, high);
                sort(a, low, pi-1);
                sort(a, pi+1, high);
            }
            return a;
        }

        public int partition(int[] a, int low, int high)
        {
            int pivot = a[low];
            int i = low;
            int j = high;

            do
            {
                while(i <= j && a[i] <= pivot)
                {
                    i++;
                }
                while(i <=j && a[j] > pivot)
                {
                    j--;
                }
                if (i <= j) swap(a, i, j);
                
            } while(i<j);

            swap(a, low, j);
            
            return j;
        }

        public void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}