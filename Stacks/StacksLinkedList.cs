using System;
using CSharpDataStructuresAlgorithms.LinkedList;

namespace CSharpDataStructuresAlgorithms.Stacks
{
    public class StacksLinkedList<T>
    {
        public Node<T> top { get; private set; }
        public int size { get; private set; }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void push(T e)
        {
            var newNode = new Node<T>(e, null);

            if(isEmpty())
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }

            size++;
        }

        public T pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }

            var e = top.element;
            top = top.next;
            size--;

            return e;
        }

        public T peek()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            
            return top.element;
        }

        public void display()
        {
            var p = top;
            while(p != null)
            {
                Console.Write(p.element.ToString() + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}