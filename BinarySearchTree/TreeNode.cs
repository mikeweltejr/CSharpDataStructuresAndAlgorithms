namespace CSharpDataStructuresAlgorithms.BST
{
    public class TreeNode<T>
    {
        public T element;
        public TreeNode<T> left;
        public TreeNode<T> right;

        public TreeNode(T e, TreeNode<T> l, TreeNode<T> r)
        {
            element = e;
            left = l;
            right = r;
        }
    }
}