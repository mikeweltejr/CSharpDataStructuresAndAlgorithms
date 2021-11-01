using System;
using System.Collections.Generic;
using CSharpDataStructuresAlgorithms.Queues;

namespace CSharpDataStructuresAlgorithms.BST
{
    public class BinarySearchTree<T>
    {
        public TreeNode<T> root;

        public bool SearchIterative(T key)
        {
            var tempRoot = root;
            while(tempRoot != null)
            {
                if(key.Equals(tempRoot.element)) return true;
                
                if(IsLessThan(key, tempRoot.element)) tempRoot = tempRoot.left;
                if(IsGreaterThan(key, tempRoot.element)) tempRoot = tempRoot.right;
            }

            return false;
        }

        public bool SearchRecursive(TreeNode<T> tempRoot, T key)
        {
            if(tempRoot != null)
            {
                if(key.Equals(tempRoot.element)) return true;
                else if(IsLessThan(key, tempRoot.element)) return SearchRecursive(tempRoot.left, key);
                else if(IsGreaterThan(key, tempRoot.element)) return SearchRecursive(tempRoot.right, key);
            }

            return false;
        }

        public void InsertNodeIterative(TreeNode<T> tempRoot, T element)
        {
            TreeNode<T> temp = null;
            while(tempRoot != null)
            {
                temp = tempRoot;
                if(element.Equals(tempRoot.element)) return;
                else if(IsLessThan(element, tempRoot.element)) tempRoot = tempRoot.left;
                else if(IsGreaterThan(element, tempRoot.element)) tempRoot = tempRoot.right;
            }

            var node = new TreeNode<T>(element, null, null);
            if(root != null)
            {
                if(IsLessThan(element, temp.element)) temp.left = node;
                else temp.right = node;
            }
            else
            {
                root = node;
            }
        }

        public TreeNode<T> InsertNodeRecursive(TreeNode<T> tempRoot, T element)
        {
            if(tempRoot != null)
            {
                if(IsLessThan(element, tempRoot.element)) 
                    tempRoot.left = InsertNodeRecursive(tempRoot.left, element);
                else if(IsGreaterThan(element, tempRoot.element)) 
                    tempRoot.right = InsertNodeRecursive(tempRoot.right, element);
            }
            else
            {
                var node = new TreeNode<T>(element, null, null);
                tempRoot = node;
            }
            return tempRoot;
        }

        public void InorderRecursive(TreeNode<T> tempRoot)
        {
            if(tempRoot != null)
            {
                InorderRecursive(tempRoot.left);
                Console.Write(tempRoot.element + " ");
                InorderRecursive(tempRoot.right);
            }
        }

        public void PreorderRecursive(TreeNode<T> tempRoot)
        {
            if(tempRoot != null)
            {
                Console.Write(tempRoot.element + " ");
                PreorderRecursive(tempRoot.left);
                PreorderRecursive(tempRoot.right);
            }
        }

        public void PostOrderRecursive(TreeNode<T> tempRoot)
        {
            if(tempRoot != null)
            {
                PostOrderRecursive(tempRoot.left);
                PostOrderRecursive(tempRoot.right);
                Console.Write(tempRoot.element + " ");
            }
        }

        public void LevelOrderRecursive()
        {
            var q = new QueueLinkedList<TreeNode<T>>();
            var tempRoot = root;

            Console.Write(tempRoot.element + " ");
            q.enqueue(tempRoot);

            while(!q.isEmpty())
            {
                tempRoot = q.dequeue();
                if(tempRoot.left != null)
                {
                    Console.Write(tempRoot.left.element + " ");
                    q.enqueue(tempRoot.left);
                }
                if(tempRoot.right != null)
                {
                    Console.Write(tempRoot.right.element + " ");
                    q.enqueue(tempRoot.right);
                }
            }
        }

        public void LevelOrderRecursiveQueue()
        {
            if(root == null) return;
            
            var q = new Queue<TreeNode<T>>();
            var temp = root;

            q.Enqueue(temp);

            while(q.Count > 0)
            {   
                temp = q.Dequeue();
                if(temp.left != null)
                    q.Enqueue(temp.left);
                if(temp.right != null)
                    q.Enqueue(temp.left);
            }
        }

        public bool Delete(T element)
        {
            var parent = root;
            TreeNode<T> pp = null; // Parent-Parent Node

            while(parent != null && !parent.element.Equals(element))
            {
                pp = parent;
                if(IsLessThan(element, parent.element))
                    parent = parent.left;
                else
                    parent = parent.right;
            }
            if(parent == null)
                return false;

            // Case when the node has both the right and left subtree
            if(parent.left != null && parent.right != null)
            {
                var s = parent.left;
                var ps = parent;

                while(s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                parent.element = s.element;
                parent = s;
                pp = ps;
            }

            // Case when the node has either left or right subtree
            TreeNode<T> c = null;
            if(parent.left != null)
                c = parent.left;
            else
                c = parent.right;
            
            if(parent == root)
                root = null;
            else
            {
                if(parent == pp.left)
                    pp.left = c;
                else
                    pp.right = c;
            }

            return true;
        }

        public int Count(TreeNode<T> tempRoot)
        {
            if(tempRoot != null)
            {
                int x = Count(tempRoot.left);
                int y = Count(tempRoot.right);
                return x + y + 1;
            }
            return 0;
            
        }


        public int Height(TreeNode<T> tempRoot)
        {
            if(tempRoot != null)
            {
                int x = Height(tempRoot.left);
                int y = Height(tempRoot.right);

                if(x > y)
                    return x+1;
                else
                    return y+1;
            }
            return 0;
        }

        public bool IsLessThan(T a, T b, bool isEqual = false)
        {
            if(a.GetType() == typeof(int) && b.GetType() == typeof(int))
            {
                if (isEqual) return Convert.ToInt32(a) <= Convert.ToInt32(b);
                return Convert.ToInt32(a) < Convert.ToInt32(b);
            }
            return false;            
        }

        public bool IsGreaterThan(T a, T b, bool isEqual = false)
        {
            if(a.GetType() == typeof(int) && b.GetType() == typeof(int))
            {
                if (isEqual) return Convert.ToInt32(a) >= Convert.ToInt32(b);
                return Convert.ToInt32(a) > Convert.ToInt32(b);
            }
            return false;
        }
    }
}