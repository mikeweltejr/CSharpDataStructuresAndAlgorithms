using System;
using CSharpDataStructuresAlgorithms.LinkedList;

namespace CSharpDataStructuresAlgorithms.Hashing
{
    public class HashChain
    {
        private int hashSize;
        private LinkedList<int>[] hashTable;

        public HashChain()
        {
            hashSize = 10;
            hashTable = new LinkedList<int>[hashSize];
            for(int i=0; i<hashSize; i++)
            {
                hashTable[i] = new LinkedList<int>();
            }
        }

        public int HashCode(int key)
        {
            return key % hashSize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            hashTable[i].InsertSorted(element);
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            return hashTable[i].Search(key) != -1;
        }

        public void Display()
        {
            for(int i=0; i<hashSize; i++)
            {
                Console.Write($"[ {i} ] ");
                hashTable[i].Display();
            }
            Console.WriteLine();
        }
    }
}