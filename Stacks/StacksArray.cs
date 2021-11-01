using System;

namespace CSharpDataStructuresAlgorithms.Stacks
{
    public class StacksArray
    {
        private int[] data;
        public int top { get; private set; }

        public StacksArray(int size)
        {
            data = new int[size];
            top=0;
        }
        
        public bool isEmpty()
        {
            return top == 0;
        }

        public bool isFull()
        {
            return top == data.Length;
        }

        public void push(int e)
        {
            if(isFull())
            {
                Console.WriteLine("Stack is full/overflow");
                return;
            }

            data[top] = e;        
            top++;
        }

        public int pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            var e = data[top - 1];
            top--;
            return e;
        }

        public int peek()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            return data[top - 1];
        }

        public void display()
        {
            for(int i=0; i<top; i++)
            {
                Console.Write(data[i].ToString() + "--");
            }
            Console.WriteLine();
        }
    }
}