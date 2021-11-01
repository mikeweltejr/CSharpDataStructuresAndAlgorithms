using System;

namespace CSharpDataStructuresAlgorithms.Hashing
{
    public class HashLinearProbe
    {
        private int hashSize;
        private int[] hashTable;

        public HashLinearProbe()
        {
            hashSize = 10;
            hashTable = new int[hashSize];
        }

        public int HashCode(int key)
        {
            return key % hashSize;
        }

        public int LinearProbe(int element)
        {
            int i = HashCode(element);
            int j = 0;
            while(hashTable[(i+j)% hashSize] != 0)
            {
                j++;
            }
            return(i+j) % hashSize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            if(hashTable[i] == 0)
                hashTable[i] = element;
            else
            {
                i = LinearProbe(element);
                hashTable[i] = element;
            }
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            int j = 0;
            while(hashTable[(i+j) % hashSize] != key)
            {
                if(hashTable[(i+j) % hashSize] == 0)
                    return false;
                j++;
            }
            return true;
        }

        public void Display()
        {
            for(int i=0; i<hashSize; i++)
            {
                Console.Write(hashTable[i] + " ");
            }
            Console.WriteLine();
        }
    }
}