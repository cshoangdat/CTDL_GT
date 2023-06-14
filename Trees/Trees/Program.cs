using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /* Non-Linear data structure: Duyệt k tuần tử
     * Linear: Duyệt tuần tự
     * tập hợp bởi nhiều Node,
     * edges: Cạnh, Node(u,v): u là cha của v 
     * number of Node  = n, number of Edges = n - 1
     * tree can be empty
     * Root: gốc
     * Siblings: con
     * external Node (leaf Node): Node không con
     * inrternal Node (Non - leaf Node): Node có con
     * path: truy cập tuần tự
     * forest: nhiều trees
     * Height and levels: Height bắt đầu từ 0 -> vị trị đầu, level từ 1: vị trí cao nhất
     * Degree of Node: số lượng node con của nó, degree của external node là 0
     * Binary Tree: nhiều nhất 2 con mỗi Node, các Node là 0 1 hoặc 2
     * left skewed Binary Tree: cây chỉ có bên Left không
     * Số Node tối đa của Binary tree với chiều cao h: 2^(h+1) - 1
     * Proper Binary Tree: Mỗi Node có 0 hoặc 2 con.
     * Full Binary Tree: Internal node có chính xác 2 con và các leaf Node có cùng cấp (same level)
     * Complete Binay Tree: là Binary tree với các node ở mỗi level được đánh số từ trái qua phải without any gap
     * Duyệt binary tree: 
     * + Preorder traversal (root -> left -> right) (+AB)
     * + inorder traversal: left -> root -> right (A+B)
     * + postorder traversal: left -> right -> root (AB+)
     * + level-order: trên xuống dưới, trái sang phải
     * binary search trees (array và linked list)
     * tìm kiếm theo key ưu tiên key lớn
     * key bên trái sẽ nhỏ hơn root và phải
     * key bên phải lớn hơn key còn lại
     * Giá trị của Node không trùng nhau
     * duyệt theo kiểu inorder
     * search: thuật toán: so sánh với root nếu lớn hơn root duyệt bên phải, nếu nhỏ hơn root duyệt bên trái.
     * function seach(key)
     *  troot = root;
     *  while troot then:
     *      if key == troot.element
     *          return true
     *      else if (key > troot.element)
     *          troot = troot.right
     *      else if (key < troot.element)
     *          troot = troot.left
     *      return false
     * search đệ quy: 
     * function reseach(troot,key)
     *      if troot then
     *          if (key == troot.element) then
     *              return true
     *          else if (key < troot.element) then
     *              return research(troot.left,key)
     *          else if (key > troot.element) then
     *              return researc(troot.right, key)
     *      else
     *          return false
     * iterative insertion
     * function insert(troot,e)
     *  temp = null
     *  while troot then
     *      temp = troot
     *      if e == troot.element then
     *      return
     *      else if e < troot.element then
     *          troot = troot.left
     *      else if e> troot.element then
     *          troot = troot.right
     *  n = Node(e)
     *  if(root) then
     *      if e <temp.element then 
     *          temp.left = n
     *      else
     *          temp.right = n
     *  else
     *      root = n
     *      
     *#inorder traversal
     *function inorder(troot)
     *  if troot then
     *      inorder(troot,left)
     *      print(troot.element)h
     *      inorder(troot,right)
     *#preorder traversal
     *
     */
    class Program
    {
        public class Node
        {
            public int element;
            public Node left;
            public Node right;
            public Node(int e, Node l ,Node r)
            {
                element = e;
                left = l;
                right = r;
            }
        }
        public class BinarySearchTree
        {
            public Node root;
            public BinarySearchTree()
            {
                root = null;
            }
            public void insert(Node temproot, int e)
            {
                Node temp = null;
                while (temproot != null)
                {
                    temp = temproot;
                    if (e == temproot.element)
                        return;
                    else if (e < temproot.element)
                        temproot = temproot.left;
                    else if (e > temproot.element)
                        temproot = temproot.right;
                }
                Node n = new Node(e, null, null);
                if (root != null)
                {
                    if (e < temp.element)
                        temp.left = n;
                    else
                        temp.right = n;
                }
                else
                    root = n;
            }
            //public Node insert(Node temproot, int e)
            //{
            //    if (temproot != null)
            //    {
            //        if (e < temproot.element)
            //            temproot.left = insert(temproot.left, e);
            //        else if (e > temproot.element)
            //            temproot.right = insert(temproot.right, e);
            //    }
            //    else
            //    {
            //        Node n = new Node(e, null, null);
            //        temproot = n;
            //    }
            //    return temproot;
            //}
            public void inorder(Node temproot)
            {
                if (temproot != null)
                {
                    inorder(temproot.left);
                    Console.Write(temproot.element + " ");
                    inorder(temproot.right);
                }
            }
            public void preorder(Node temproot)
            {
                if (temproot != null)
                {
                    Console.Write(temproot.element + " ");
                    preorder(temproot.left);
                    preorder(temproot.right);
                }
            }
            public void postorder(Node temproot)
            {
                if (temproot != null)
                {
                    postorder(temproot.left);
                    postorder(temproot.right);
                    Console.Write(temproot.element + " ");
                }
            }

        }

        static void Main(string[] args)
        {
            BinarySearchTree B = new BinarySearchTree();
            /*B.root = B.insert(B.root, 50);*/  //dùng cho đệ qui pải đặt biến trước do có giá trị trả về
            B.insert(B.root, 50);   //dùng cho insert thường
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);
            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal");
            B.preorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal");
            B.postorder(B.root);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
