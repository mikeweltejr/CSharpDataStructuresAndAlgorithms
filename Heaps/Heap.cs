using System;

namespace CSharpDataStructuresAlgorithms.Heaps
{
    public class Heap
    {
        private int maxSize;
        private int[] data;
        private int csize;

        public Heap()
        {
            maxSize = 10;
            data = new int[maxSize];
            csize = 0;
            for(int i=0; i<data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public int Length()
        {
            return csize;
        }

        public bool IsEmpty()
        {
            return csize == 0;
        }

        public void Insert(int e)
        {
            if(csize == maxSize)
            {
                Console.WriteLine("No Space in Heap");
                return;
            }

            csize++;
            // index where element has to be inserted
            int hi = csize;
            
            // data[h1/2] is checking that the value is greater than it's parent, if so we need to swap
            // since the relational property states the parent of each node must be greater than or equal to
            // it's children
            while(hi > 1 && e > data[hi/ 2])
            {
                data[hi] = data[hi/2];
                // assign the index of hi to the parent node
                hi = hi / 2;
            }

            // We now know where to put the element (hi)
            data[hi] = e;
        }

        public int DeleteMax()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            // get root element
            int e  = data[1];

            // set the root to the last element since this will fulfill the structural property
            // these statements handle the structural property of a heap
            data[1] = data[csize];
            data[csize] = -1;
            csize--;

            // these statements handle the relational property of a heap
            // i is parent node j is child node
            int i=1;
            int j=i*2;
            while(j<=csize)
            {
                // is left or right child greater? If right is greater increment j
                if(data[j] < data[j+1]) j++;
                // is the parent less than the child, if so we have to swap to handle relational property
                if(data[i] < data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i=j;
                    j=i*2;
                }
                else
                {
                    break;
                }
            }
            return e;
        }

        public int Max()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Heap is empty");
                return -1;
            }
            // return the root node
            return data[1];
        }

        public void Display()
        {
            foreach(int i in data)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}