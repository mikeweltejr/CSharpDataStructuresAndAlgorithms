namespace CSharpDataStructuresAlgorithms.LinkedList
{
    public class DNode<T>
    {
        public T element { get; set; }
        public DNode<T> next { get; set; }
        public DNode<T> prev { get; set; }

        public DNode(T e, DNode<T> n, DNode<T> p)
        {
            element = e;
            next = n;
            prev = p;
        }
    }
}