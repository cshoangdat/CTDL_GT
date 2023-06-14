using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tree_form
{
    public partial class Form1 : Form
    {
        public class Node
        {
            public int element;
            public Node left;
            public Node right;
            public Node(int e, Node l, Node r)
            {
                element = e;
                left = l;
                right = r;
            }
        }
        public class binarySearchTree{
            public Node root;
            public binarySearchTree()
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
            public void inorder(Node temproot, Label label)
            {
                if (temproot != null)
                {
                    inorder(temproot.left, label);
                    label.Text = string.Concat(label.Text, temproot.element + " ");
                    inorder(temproot.right, label);
                }
            }
            public void preorder(Node temproot, Label label)
            {
                if (temproot != null)
                {
                    label.Text = string.Concat(label.Text, temproot.element + " ");
                    preorder(temproot.left, label);
                    preorder(temproot.right, label);
                }
            }
            public void postorder(Node temproot, Label label)
            {
                if (temproot != null)
                {
                    postorder(temproot.left, label);
                    postorder(temproot.right, label);
                    label.Text = string.Concat(label.Text, temproot.element + " ");
                }
            }
            public void levelorder(Label label)
            {
                queueLinkedList q = new queueLinkedList();
                Node t = root;
                label.Text = string.Concat(label.Text, t.element + " ");
                q.enqueue(t);
                while (!q.isEmpty())
                {
                    t = (Node)q.dequeue();
                    if (t.left != null)
                    {
                        label.Text = string.Concat(label.Text, t.left.element + " ");
                        q.enqueue(t.left);
                    }
                    if (t.right != null)
                    {
                        label.Text = string.Concat(label.Text, t.right.element + " ");
                        q.enqueue(t.right);
                    }
                }
            }
        }
        binarySearchTree B = new binarySearchTree();
        public Form1()
        {
            InitializeComponent();
        }
        //Thêm thành phần vào binary tree
        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            B.insert(B.root, num);
            textBox1.ResetText();
            textBox1.Focus();
        }
        //duyệt phần tử theo inorder
        private void button2_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Inorder:\n";
            B.inorder(B.root, lblKQ);
        }
        //duyệt phần tử theo preorder
        private void button3_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Preorder:\n";
            B.preorder(B.root, lblKQ);
        }
        //duyệt phần tử theo postorder
        private void button4_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Postorder:\n";
            B.postorder(B.root, lblKQ);
        }
        //duyệt phần tử theo levelorder
        private void button5_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Levelorder:\n";
            B.levelorder(lblKQ);
        }
    }
}
