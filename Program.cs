using System;
using CSharpDataStructuresAlgorithms.Searching;
using CSharpDataStructuresAlgorithms.Sorting;
using CSharpDataStructuresAlgorithms.LinkedList;
using CSharpDataStructuresAlgorithms.Stacks;
using CSharpDataStructuresAlgorithms.Queues;
using CSharpDataStructuresAlgorithms.BST;
using CSharpDataStructuresAlgorithms.Heaps;
using CSharpDataStructuresAlgorithms.Hashing;
using CSharpDataStructuresAlgorithms.Graphs;

namespace CSharpDataStructuresAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // var recursion = new Recursion();
            //Console.WriteLine(recursion.sum(5));
            //Console.WriteLine(recursion.factorial(4));
            //Console.ReadKey();

            // var linSearch = new LinearSearch();
            // int[] a = { 1, 5, 7, 23, 35, 76, 98, 101, 102, 105, 110, 200, 1000, 2030 };
            //var intIndex = linSearch.linearSearch(a, 24);
            //Console.WriteLine(intIndex);

            // var binarySearch = new BinarySearch();
            // var intIndex = binarySearch.recursiveSearch(a, 2030, 0, a.Length-1);
            // Console.WriteLine(intIndex);
            // Console.ReadKey();

            // var selectionSort = new SelectionSort();
            // int[] a = { 38, 27, 43, 3, 9, 82, 10 };

            //var retArray = selectionSort.sort(a);
            
            // var insertionSort = new InsertionSort();
            // var retArray = insertionSort.sort(a);
            // foreach(int i in retArray) Console.WriteLine(i.ToString());

            // var bubbleSort = new BubbleSort();
            // var retArray = bubbleSort.sort(a);

            // var shellSort = new ShellSort();
            // var retArray = shellSort.sort(a);

            // var mergeSort = new MergeSort();
            // var retArray = mergeSort.sort(a, 0, a.Length-1);

            // var quickSort = new QuickSort();
            // var retArray = quickSort.sort(a, 0, a.Length-1);
            // foreach(int i in retArray) Console.WriteLine(i.ToString());

            displayLinkedList();
            
            //displayCircularLinkedList();

            //displayDoubleLinkedList();

            //displayStackArray();

            //displayStackLinkedList();

            //displayQueueArray();

            //displayQueueLinkedList();

            //displayDequeue();

            //displayBST();

            //DisplayHeap();

            //DisplayHeapSort();

            //DisplayHashChain();

            //DisplayHashLinearProbe();

            //undirectedGraph();

            //directedGraph();

            //breadthFirstSearchGraph();
        }

        private static void displayLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.InsertSorted(4);
            linkedList.InsertSorted(1);
            linkedList.InsertSorted(-3);
            linkedList.InsertSorted(99);
            //linkedList.Display();
            linkedList.Move(2);
            //linkedList.Display();
            //Console.WriteLine(linkedList.HasCycle());
            linkedList.ReverseList();
            //linkedList.Display();

            // Merge sorted linked lists
            var l1 = new LinkedList<int>();
            l1.InsertSorted(1);
            l1.InsertSorted(2);
            l1.InsertSorted(3);
            var l2 = new LinkedList<int>();
            l2.InsertSorted(4);
            l2.InsertSorted(5);
            l2.InsertSorted(6);
            l2.Display(l2.MergeSortedLinkedList(l1.head, l2.head));


            var palindromLL = new LinkedList<int>();
            palindromLL.AddFirst(1);
            palindromLL.AddLast(2);
            palindromLL.AddLast(3);
            palindromLL.AddLast(3);
            palindromLL.AddLast(2);
            palindromLL.AddLast(1);
            Console.WriteLine("Is LinkedList Palindrome: " + palindromLL.IsPalindrome(palindromLL.head));
        }

        private static void displayCircularLinkedList()
        {
            var cirLinkedList = new CircularLinkedList<int>();
            cirLinkedList.addLast(5);
            cirLinkedList.addLast(7);
            cirLinkedList.addLast(1);
            cirLinkedList.addLast(10);
            cirLinkedList.addLast(53);
            cirLinkedList.addLast(2);
            cirLinkedList.display();
            cirLinkedList.addFirst(25);
            cirLinkedList.display();
            cirLinkedList.addAny(21, 6);
            cirLinkedList.display();
            cirLinkedList.removeFirst();
            cirLinkedList.display();
            cirLinkedList.removeLast();
            cirLinkedList.display();
            cirLinkedList.removeAny(4);
            cirLinkedList.display();
        }

        private static void displayDoubleLinkedList()
        {
            var dblLinkedList = new DoubleLinkedList<int>();
            dblLinkedList.addLast(5);
            dblLinkedList.addLast(10);
            dblLinkedList.addLast(2);
            dblLinkedList.addLast(17);
            dblLinkedList.addLast(1);
            dblLinkedList.addLast(9);
            dblLinkedList.display();
            dblLinkedList.addFirst(12);
            dblLinkedList.addFirst(45);
            dblLinkedList.display();
            dblLinkedList.addAny(23, 4);
            dblLinkedList.addAny(99, 2);
            dblLinkedList.display();
            dblLinkedList.removeFirst();
            dblLinkedList.display();
            dblLinkedList.removeLast();
            dblLinkedList.display();
            dblLinkedList.removeAny(5);
            dblLinkedList.display();
        }

        private static void displayStackArray()
        {
            var stackArray = new StacksArray(7);
            stackArray.push(5);
            stackArray.push(3);
            stackArray.push(4);
            stackArray.push(8);
            stackArray.push(12);
            stackArray.push(1);
            stackArray.display();
            Console.WriteLine(stackArray.peek());
            stackArray.pop();
            stackArray.pop();
            stackArray.display();
        }

        private static void displayStackLinkedList()
        {
            var stackLL = new StacksLinkedList<int>();
            stackLL.push(1);
            stackLL.push(4);
            stackLL.push(2);
            stackLL.push(1);
            Console.WriteLine(stackLL.peek());
            stackLL.push(17);
            stackLL.push(3);
            stackLL.display();
            stackLL.pop();
            stackLL.display();
            stackLL.pop();
            stackLL.display();
        }

        private static void displayQueueArray()
        {
            var queueArray = new QueueArray(10);
            queueArray.enqueue(10);
            queueArray.enqueue(100);
            queueArray.enqueue(34);
            queueArray.enqueue(2);
            queueArray.enqueue(10);
            queueArray.display();
            Console.WriteLine(queueArray.dequeue());
            Console.WriteLine(queueArray.dequeue());
            queueArray.display();

        }

        private static void displayQueueLinkedList()
        {
            var queueLihnkedList = new QueueLinkedList<int>();
            queueLihnkedList.enqueue(5);
            queueLihnkedList.enqueue(10);
            queueLihnkedList.enqueue(122);
            queueLihnkedList.enqueue(1);
            queueLihnkedList.display();
            Console.WriteLine(queueLihnkedList.dequeue());
            queueLihnkedList.display();
            Console.WriteLine(queueLihnkedList.dequeue());
            queueLihnkedList.display();
        }

        private static void displayDequeue()
        {
            var dequeue = new Dequeue<int>();
            dequeue.addFirst(10);
            dequeue.addFirst(5);
            dequeue.addLast(15);
            dequeue.addLast(20);
            dequeue.addFirst(35);
            dequeue.display();
            dequeue.removeFirst();
            dequeue.display();
            dequeue.removeLast();
            dequeue.display();
            Console.WriteLine(dequeue.first());
            Console.WriteLine(dequeue.last());
        }

        private static void displayBST()
        {
            int searchKey = 90;
            var bst = new BinarySearchTree<int>();
            bst.InsertNodeIterative(bst.root, 50);
            bst.InsertNodeIterative(bst.root, 30);
            bst.InsertNodeIterative(bst.root, 80);
            bst.InsertNodeIterative(bst.root, 10);
            bst.InsertNodeRecursive(bst.root, 40);
            bst.InsertNodeRecursive(bst.root, 60);
            bst.InsertNodeRecursive(bst.root, 90);
            Console.WriteLine("Inorder Traversal");
            bst.InorderRecursive(bst.root);
            Console.WriteLine();
            Console.WriteLine();           
            Console.WriteLine("Preorder Traversal");
            bst.PreorderRecursive(bst.root);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal");
            bst.PostOrderRecursive(bst.root);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Level Order Traversal");
            bst.LevelOrderRecursive();
            Console.WriteLine();
            Console.WriteLine();
            var found = bst.SearchRecursive(bst.root, searchKey);
            Console.WriteLine($"Found {searchKey}: {found.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"Count: {bst.Count(bst.root)}" );
            Console.WriteLine();
            Console.WriteLine($"Height: {bst.Height(bst.root)}");

            Console.ReadKey();   
        }

        private static void DisplayHeap()
        {
            var heap = new Heap();
            heap.Insert(25);
            heap.Insert(14);
            heap.Insert(2);
            heap.Insert(20);
            heap.Insert(10);
            heap.Display();
            heap.DeleteMax();
            heap.Display();
            heap.DeleteMax();
            heap.Display();
        }

        private static void DisplayHeapSort()
        {
            int[] a = { 63, 250, 835, 947, 651, 28 };
            var heap = new HeapSort();
            heap.Display(a, 6);
            a = heap.Sort(a, 6);
            heap.Display(a, 6);

        }

        private static void DisplayHashChain()
        {
            var hashChain = new HashChain();
            hashChain.Insert(54);
            hashChain.Insert(78);
            hashChain.Insert(64);
            hashChain.Insert(92);
            hashChain.Display();
        }

        private static void DisplayHashLinearProbe()
        {
            var hashLinearProbe = new HashLinearProbe();
            hashLinearProbe.Insert(54);
            hashLinearProbe.Insert(78);
            hashLinearProbe.Insert(64);
            hashLinearProbe.Insert(92);
            hashLinearProbe.Insert(34);
            hashLinearProbe.Insert(86);
            hashLinearProbe.Insert(28);
            hashLinearProbe.Display();
            Console.WriteLine(hashLinearProbe.Search(34) ? "Element Found!" : "Element not found");
        }

        private static void undirectedGraph()
        {
            Graph g = new Graph(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.display();
            Console.WriteLine("vertices: " + g.vertexCount());
            Console.WriteLine("edge count: " + g.edgeCount());
            g.insertEdge(0, 1, 26);
            g.insertEdge(0, 2, 16);
            g.insertEdge(1, 0, 26);
            g.insertEdge(1, 2, 12);
            g.insertEdge(2, 0, 16);
            g.insertEdge(2, 1, 12);
            g.insertEdge(2, 3, 8);
            g.insertEdge(3, 2, 8);
            g.display();
            Console.WriteLine("edge count: " + g.edgeCount());
            g.edges();
            Console.WriteLine("Edge between 1--3: " + g.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
            Console.WriteLine("Degree of vertex 2: " + g.inDegree(2));
            
            g.display();
            g.removeEdge(1,2);
            Console.WriteLine();
            g.display();
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
        }

        private static void directedGraph()
        {
            Graph g = new Graph(4);
            Console.WriteLine("Graph Adjacency Matrix: ");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edges: " + g.edgeCount());
            g.insertEdge(0, 1, 26);
            g.insertEdge(0, 2, 16);
            g.insertEdge(1, 2, 12);
            g.insertEdge(2, 3, 8);
            Console.WriteLine("Graph Adjacency Matrix: ");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edges: " + g.edgeCount());
            g.edges();
            Console.WriteLine("Edge between 1--3: " + g.existEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));
            Console.WriteLine("Degree of vertex 2: " + (g.inDegree(2) + g.outDegree(2)).ToString());
            Console.WriteLine("In-degree of vertex 2: " + g.inDegree(2));
            Console.WriteLine("Out-degree of vertex 2: " + g.outDegree(2));

            Console.WriteLine();
            g.display(); 
            g.removeEdge(1,2);
            Console.WriteLine();
            g.display();   
            Console.WriteLine("Edge between 1--2: " + g.existEdge(1, 2));        
        }

        private static void breadthFirstSearchGraph()
        {
            Graph g = new Graph(7);
            g.insertEdge(0, 1, 1);
            g.insertEdge(0, 5, 1);
            g.insertEdge(0, 6, 1);
            g.insertEdge(1, 0, 1);
            g.insertEdge(1, 2, 1);
            g.insertEdge(1, 5, 1);
            g.insertEdge(1, 6, 1);
            g.insertEdge(2, 3, 1);
            g.insertEdge(2, 4, 1);
            g.insertEdge(2, 6, 1);
            g.insertEdge(3, 4, 1);
            g.insertEdge(4, 2, 1);
            g.insertEdge(4, 5, 1);
            g.insertEdge(5, 2, 1);
            g.insertEdge(5, 3, 1);
            g.insertEdge(6, 3, 1);
            Console.WriteLine("Breadth First Search: ");
            g.BFS(0);
            Console.WriteLine();
            Console.WriteLine("Depth First Search: ");
            g.DFS(0);
        }
    }
}
