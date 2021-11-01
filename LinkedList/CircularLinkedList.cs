using System;

namespace CSharpDataStructuresAlgorithms.LinkedList
{
    public class CircularLinkedList<T>
    {
        public Node<T> head { get; private set; }
        public Node<T> tail { get; private set; }
        public int size { get; private set; }

        
        private bool isEmpty()
        {
            return size == 0;
        }
        public void addLast(T e)
        {
            var newNode = new Node<T>(e, null);

            if(isEmpty())
            {
                newNode.next = newNode;
                head = newNode;
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
            }        
            tail = newNode;

            size++;
        }

        public void addFirst(T e)
        {
            var newNode = new Node<T>(e, null);

            if(isEmpty())
            {
                newNode.next = newNode;
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.next = head;
                head = newNode;
            }

            size++;
        }

        public void addAny(T e, int position)
        {
            if(position <=0 || position > size)
            {
                Console.WriteLine("Position is out of range");
                return;
            }

            var newNode = new Node<T>(e, null);
            var p = head;
            int i = 1;
            
            while(i < position -1)
            {
                p = p.next;
                i++;
            }

            newNode.next = p.next;
            p.next = newNode;
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
            tail.next = head.next;
            head = head.next;
            size--;

            if(isEmpty())
            {
                head = null;
                tail = null;
            }

            return e;
        }

        public T removeLast()
        {
            if(isEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            var p = head;
            int i = 1;

            while(i < size - 1)
            {
                p = p.next;
                i++;
            }

            tail = p;
            p = p.next;
            var e = p.element;
            tail.next = head;

            size--;

            if(isEmpty())
            {
                head = null;
                tail = null;
            }

            return e;
        }

        public T removeAny(int position)
        {
            if(position <= 0 || position > size)
            {
                Console.WriteLine("Index is out of range");
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
            size--;

            if(isEmpty())
            {
                head = null;
                tail = null;
            }

            return e;
        }

        public void display()
        {
            var p = head;
            var i = 0;
            
            while(i < size)
            {
                Console.Write(p.element.ToString() + "-----> ");
                p = p.next;
                i++;
            }
            Console.WriteLine();
        }       
    }
}