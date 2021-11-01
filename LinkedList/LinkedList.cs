using System.Collections.Generic;
using System;

namespace CSharpDataStructuresAlgorithms.LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> head { get; private set; }
        public Node<T> tail { get; private set; }
        public int size { get; private set; }


        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddLast(T element)
        {
            var newNode = new Node<T>(element, null);

            if(IsEmpty())
                head = newNode;
            else
                tail.next = newNode;
            
            tail = newNode;
            size++;
        }

        public void AddFirst(T element)
        {
            var newNode = new Node<T>(element, null);
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            size++;
        }

        public void AddAny(T element, int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine($"Invalid Position: {position}");
                return;
            }

            var newNode = new Node<T>(element, null);
            var p = head;
            int i = 1;

            while(i<position-1)
            {
                p = p.next;
                i++;
            }

            newNode.next = p.next;
            p.next = newNode;
            size++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("List is empty");
                return default(T);
            }
            var element = head.element;
            head = head.next;
            size--;

            if(IsEmpty()) tail = null;

            return element;
        }

        public T RemoveLast()
        {
            if(IsEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }
            
            var p = head;
            int i = 1;

            while(i < size -1)
            {
                p = p.next;
                i++;
            }
            
            tail = p;
            p = p.next;
            var e = p.element;
            tail.next = null;
            size--;

            return e;
        }

        public T RemoveAny(int position)
        {
            if(position > size || position < 1)
            {
                Console.WriteLine("Position is below or above the linked list index");
                return default(T);
            }

            var p = head;
            int i = 1;

            while(i < position-1)
            {
                p = p.next;
                i++;
            }
            var e = p.next.element;
            p.next = p.next.next;
            size--;

            return e;
        }

        public int Search(T key)
        {
            var p = head;
            int i = 0;
            
            while(p != null)
            {
                if (p.element.Equals(key)) return i;
                p = p.next;
                i++;
            }

            return -1;
        }

        public void InsertSorted(T e)
        {
            var newNode = new Node<T>(e, null);

            if(IsEmpty())
            {
                head = newNode;
            }
            else
            {
                var p = head;
                var q = head;

                while(p != null && IsLessThan(p.element, e))
                {
                    q = p;
                    p = p.next;
                }
                if (p == head)
                {
                    newNode.next = head;
                    head=newNode;
                }
                else
                {
                    newNode.next = q.next;
                    q.next = newNode;
                }
            }

            size++;
        }      

        public void Move(int k)
        {
            if(head == null || k == 0) return;

            var temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }

            if(k > size) k = k % size;

            k = size - k;

            var current = head;
            int count = 1;
            while(count < k && current != null)
            {
                current = current.next;
                count ++;
            }

            if(current == null) return;

            var kthNode = current;
            temp.next = head;
            head = kthNode.next;
            kthNode.next = null;
        }

        // Always false here but could be true in a linked list where the tail can point back
        public bool HasCycle()
        {
            if(head == null) return false;
            Node<T> slow = head;
            Node<T> fast = head;

            while(slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if(slow == fast) return true;
            }
            return false;
        }

        public Node<T> DetectCycle()
        {
            if(head == null) return null;

            HashSet<Node<T>> s = new HashSet<Node<T>>();
            var current = head;

            while(current != null)
            {
                if(s.Contains(current)) return current;
                s.Add(current);
                current = current.next;
            }

            return null;
        }

        public void ReverseList()
        {
            if(head == null) return;
            Node<T> prev = null;
            Node<T> current = head;

            while(current != null)
            {
                Node<T> temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        public Node<int> MergeSortedLinkedList(Node<int> l1, Node<int> l2)
        {
            if(l1 == null) return l2;
            else if(l2 == null) return l1;

            Node<int> mergedHead = null;
            Node<int> mergedTail = null;
            var tempL1 = l1;
            var tempL2 = l2;

            if(l1.element <= l2.element)
            {
                 mergedHead = l1;
            }
            else
            {
                mergedHead = l2;
            }

            mergedTail = mergedHead;
               

            while(l1 != null && l2 != null)
            {
                Node<int> temp = null;

                if(l1.element <= l2.element)
                {
                    temp = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp = l2;
                    l2 = l2.next;
                }

                mergedTail.next = temp;
                mergedTail = temp;

                if(l1 != null)
                    mergedTail.next = l1;
                else if(l2 != null)
                    mergedTail.next = l2;
            }

            return mergedHead;
        }

        public bool IsPalindrome(Node<T> head)
        {
            if(head == null) return true;
            if(head.next == null) return true;

            var firstHalfEnd = EndOfFirstHalf(head);
            Console.WriteLine(firstHalfEnd.element);
            var secondHalfStart = ReverseList(firstHalfEnd.next);
            Console.WriteLine(secondHalfStart.element);

            var p1 = head;
            var p2 = secondHalfStart;
            bool result = true;

            while(result && p2 != null)
            {
                if(!p1.element.Equals(p2.element)) result = false;
                p1 = p1.next;
                p2 = p2.next;
            }

            firstHalfEnd.next = ReverseList(secondHalfStart);
            return result;
        }

        private Node<T> ReverseList(Node<T> head)
        {
            Node<T> prev = null;
            Node<T> curr = head;
            while(curr != null)
            {
                var nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }

        private Node<T> EndOfFirstHalf(Node<T> head)
        {
            Node<T> fast = head;
            Node<T> slow = head;
            while(fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }

        private bool IsLessThan(T a, T b)
        {
            if(a.GetType() == typeof(int) && b.GetType() == typeof(int))
            {
                return Convert.ToInt32(a) < Convert.ToInt32(b);
            }
            return false;
        }

        public void Display()
        {
            var p = head;
            while(p != null)
            {
                Console.Write(p.element.ToString() + "-----> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void Display(Node<int> n)
        {
            while(n != null)
            {
                Console.Write(n.element.ToString() + "------> ");
                n = n.next;
            }
            Console.WriteLine();
        }
    }
}