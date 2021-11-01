using CSharpDataStructuresAlgorithms.BST;

namespace CSharpDataStructuresAlgorithms.BinaryTree
{
    public class BinaryTree<T>
    {
        public void InsertNode(TreeNode<T> tempRoot, T element)
        {
            var newNode = new TreeNode<T>(element, null, null);
        }
    }
}