namespace CSharpDataStructuresAlgorithms.LinkedList
{
    public class Node<T>
    {
        public T element;
        public Node<T> next;

        public Node(T e, Node<T> n)
        {
            element = e;
            next = n;
        }
    }
}