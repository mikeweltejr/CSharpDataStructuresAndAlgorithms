using System;
using CSharpDataStructuresAlgorithms.LinkedList;

namespace CSharpDataStructuresAlgorithms.Queues
{
    public class Dequeue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        public int size { get; private set; }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addLast(T e)
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

        public void addFirst(T e)
        {
            var newNode = new Node<T>(e, null);

            if(isEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                newNode.next = front;
                front = newNode;
            }
            size++;
        }

        public T removeFirst()
        {
            if (isEmpty()) 
            {
                Console.WriteLine("List is empty");
                return default(T);
            }
            var element = front.element;
            front = front.next;
            size--;

            if(isEmpty()) front = null;

            return element;
        }

        public T removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }
            
            var p = front;
            int i = 1;

            while(i < size -1)
            {
                p = p.next;
                i++;
            }
            
            rear = p;
            p = p.next;
            var e = p.element;
            rear.next = null;
            size--;

            return e;
        }

        public T first()
        {
            if(isEmpty())
            {
                Console.WriteLine("Dequeue is empty");
                return default(T);
            }
            return front.element;
        }

        public T last()
        {
            if(isEmpty())
            {
                Console.WriteLine("Dequeue is empty");
                return default(T);
            }
            return rear.element;
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