using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://www.geeksforgeeks.org/find-the-minimum-element-in-a-binary-search-tree/
/// Find the node with minimum value in a Binary Search Tree
/// This is quite simple. Just traverse the node from root to left recursively until left is NULL. The node whose left is NULL is the node with minimum value.
/// </summary>
namespace BST_Find_MIN_Value_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = null;
            root = tree.Insert(root, 4);
            tree.Insert(root, 2);
            tree.Insert(root, 1);
            tree.Insert(root, 3);
            tree.Insert(root, 6);
            tree.Insert(root, 5);

            Console.WriteLine("The min value of BST is  "+ tree.MinValue(root));
            Console.ReadLine();
        }
    }

    //A binary tree Node
    public class Node
    {
        public int data
        { get; set; }
        public Node Left
        { get; set; }
        public Node Right
        { get; set; }

        public Node(int item)
        {
            data = item;
            Left = Right = null;

        }
    }

    public class BinaryTree
    {
        //Insert Node
       public Node Insert(Node node ,int data)
        {
            // if the tree is empty ,return a new single node
            if (node == null)
                return (new Node(data));
            else
            {
                //otherwise ,recure down the tree
                if (data <= node.data)
                    node.Left = Insert(node.Left, data);
                else
                    node.Right = Insert(node.Right, data);
                return node;
            }
        }

      public int MinValue(Node node)
        {
            Node current = node;
            while(current.Left !=null)
            {
                current = current.Left;
            }

            return (current.data);
        }
    }
}
