using System;
using CSharpDataStructuresAlgorithms.LinkedList;

namespace CSharpDataStructuresAlgorithms.Queues
{
    public class QueueLinkedList<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int size;

        public bool isEmpty()
        {
            return size == 0;
        }

        public void enqueue(T e)
        {
            var newNode = new Node<T>(e, null);

            if(isEmpty())
            {
                front = newNode;
            }
            else
            {
                rear.next = newNode;
            }
            rear = newNode;
            size++;
        }

        public T dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }

            var e = front.element;
            front = front.next;
            size--;

            if(isEmpty())
            {
                rear = null;
            }
            return e;
        }

        public T first()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return front.element;
        }

        public void display()
        {
            var p = front;

            while(p != null)
            {
                Console.Write(p.element.ToString() + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}