using System;

namespace CSharpDataStructuresAlgorithms.LinkedList
{
    public class DoubleLinkedList<T>
    {
        public DNode<T> head { get; private set; }
        public DNode<T> tail { get; private set; }
        public int size { get; private set; }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void display()
        {
            var p = head;

            while(p != null)
            {
                Console.Write(p.element.ToString() + " ------> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void addLast(T e)
        {
            var newNode = new DNode<T>(e, null, null);

            if(isEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }

            size++;
        }

        public void addFirst(T e)
        {
            var newNode = new DNode<T>(e, null, null);

            if(isEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }

            size++;
        }

        public void addAny(T e, int position)
        {
            if(position <= 0 || position > size)
            {
                Console.WriteLine("Index is out of range for list");
                return;
            }

            var newNode = new DNode<T>(e, null, null);
            var p = head;
            int i = 1;

            while(i < position - 1)
            {
                p = p.next;
                i++;
            }

            newNode.next = p.next;
            p.next.prev = newNode;
            p.next = newNode;
            newNode.prev = p;

            size++;
        }

        public T removeFirst()
        {
            if(isEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            var e = head.element;
            head = head.next;
            head.prev = null;
            size--;

            if(isEmpty())
                tail = null;

            return e;
        }

        public T removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            var e = tail.element;
            tail = tail.prev;
            tail.next = null;

            size--;

            return e;
        }

        public T removeAny(int position)
        {
            if(position <= 0 || position > size)
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            var p = head;
            int i = 1;

            while(i < position - 1)
            {
                p = p.next;
                i++;
            }

            var e = p.next.element;
            p.next = p.next.next;
            p.next.prev = p;

            size--;

            return e;
        }
    }
}