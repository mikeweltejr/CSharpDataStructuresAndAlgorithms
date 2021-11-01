using System;

namespace CSharpDataStructuresAlgorithms.Queues
{
    public class QueueArray
    {
        private int[] data;
        public int rear { get; private set; }
        public int front { get; private set; }
        public int size { get; private set; }

        public QueueArray(int n)
        {
            data = new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }

        public bool isFull()
        {
            return size == data.Length;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void enqueue(int e)
        {
            if(isFull())
            {
                Console.WriteLine("Stack is full/overflow");
                return;
            }

            data[rear] = e;
            rear++;
            size++;
        }

        public int dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            var e = data[front];
            front++;
            size--;
            
            return e;
        }

        public void display()
        {
            for(int i=front; i<rear; i++)
            {
                Console.Write(data[i].ToString() + "--");
            }
            Console.WriteLine();
        }
    }
}