using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
    Lowest Common Ancestor in a Binary Search Tree.
    Given values of two nodes in a Binary Search Tree, write a c program to find the Lowest Common Ancestor (LCA). You may assume that both the values exist in the tree.
   
     http://www.geeksforgeeks.org/lowest-common-ancestor-in-a-binary-search-tree/
    */



namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let us contruct the BST shown in the above figure 
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(20);
            tree.root.left = new Node(8);
            tree.root.right = new Node(22);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new BinarySearch.Node(12);
            tree.root.left.right.left = new Node(10);
            tree.root.left.right.right = new Node(14);

            int n1 = 10, n2 = 14;
            Node t = tree.lca(tree.root, n1, n2);
            Console.WriteLine("LCA of " + n1 + "and " + n2 + " " + t.data);

            n1 = 14;
            n2 = 8;
            t = tree.lca(tree.root, n1, n2);
            Console.WriteLine("LCA of " + n1 + "and " + n2 + " " + t.data);

            n1 = 10;
            n2 = 22;
            t = tree.lca(tree.root, n1, n2);
            Console.WriteLine("LCA of " + n1 + "and " + n2 + " " + t.data);

            Console.ReadKey();

        }
    }

    public class Node
    {
        public int data
        {
            get; set;
        }

        public Node left
        { get; set; }
        public Node right
        { get; set; }
        public Node(int item)
        {
            data = item;
            left = right = null;
        }

    }
    public class BinaryTree
    {
        public Node root;
        public Node lca(Node node, int n1, int n2)
        {
            if (node == null)
                return null;
            //if both n1 and n2 are smaller than root , then LCA lies in left
            if (node.data > n1 && node.data > n2)
                return lca(node.left, n1, n2);
            if (node.data < n1 && node.data < n2)
                return lca(node.right, n1, n2);

            return node;
        }


    }

}
