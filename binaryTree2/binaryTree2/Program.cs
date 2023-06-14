using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTree2
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node (int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
    public class binaryTree
    {
        private Node root;
        public binaryTree()
        {
            root = null;
        }
        public void insert(int data)
        {
            Node newest = new Node(data);
            if (root == null)
            {
                root = newest;
                return;
            }
            insertRec(root, newest);
        }
        private void insertRec(Node root, Node newNode)
        {
            if (root == null) root = newNode;
            if(newNode.data < root.data)
            {
                if (root.left == null) root.left = newNode;
                else insertRec(root.left, newNode);
            }
            else
            {
                if (root.right == null) root.right = newNode;
                else insertRec(root.right, newNode);
            }
        }
        public void display()
        {
            display(root);
        }
        private void display(Node root)
        {
            if (root == null) return;
            display(root.left);
            Console.Write(root.data + " ");
            display(root.right);
        }
        public void removeNode(int key)
        {
            remove(root, key);
        }
        private Node remove(Node root, int key)
        {
            if (root == null) return root;
            if (key < root.data)
                root.left = remove(root.left, key);
            else if (key > root.data)
                root.right = remove(root.right, key);
            else
            {
                //TH1: Node duoc xoa khong co con
                if(root.left == null && root.right == null)
                {
                    root = null;
                }
                //TH2: Node duoc xoa co 2 con
                else if(root.left != null && root.right != null)
                {
                    var maxNode = findMax(root.right);
                    root.data = maxNode.data;
                    root.right = remove(root.right, maxNode.data);
                }
                else
                {
                    var child = root.left != null ? root.left : root.right;
                    root = child;
                }
            }
            return root;
        }
        private Node findMax(Node node)
        {
            while(node.left != null)
            {
                node = node.left;
            }
            return node;
        }
        public Node findNode(Node root, int key)
        {
            Node result;
            if (key < root.data)
            {
                result = findNode(root.left, key);
            }
            else if (key > root.data)
            {
                result =  findNode(root.right, key);
            }
            else result =  root;
            return result;
        }
        public void replaceNode(int key, int newValue)
        {
            Node current = findNode(root, key);
            current.data = newValue;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            binaryTree tree = new binaryTree();
            tree.insert(4);
            tree.insert(2);
            tree.insert(5);
            tree.insert(1);
            tree.insert(3);
            tree.display();
            tree.removeNode(4);
            Console.WriteLine();
            tree.display();
            Console.WriteLine();
            tree.replaceNode(3,10);
            tree.display();
        }
    }
}
