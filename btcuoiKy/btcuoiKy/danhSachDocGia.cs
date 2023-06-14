using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btcuoiKy
{
    class Node_tree
    {
        public docGia data;
        public Node_tree left;
        public Node_tree right;
        public Node_tree(docGia docGia)
        {
            data = docGia;
            left = null;
            right = null;
        }
    }
    class danhSachDocGia
    {
        private Node_tree root;
        public danhSachDocGia()
        {
            root = null;
        }
        public void themDocGia(docGia docGia)
        {
            Node_tree newest = new Node_tree(docGia);
            if (root == null) root = newest;
            else
            {
                themDocGia(root, newest);
            }
        }
        private void themDocGia(Node_tree root, Node_tree newNode)
        {
            if (root == null) root = newNode;
            else
            {
                if(newNode.data.MADG < root.data.MADG)
                {
                    if (root.left == null) root.left = newNode;
                    else themDocGia(root.left, newNode);
                }
                else
                {
                    if (root.right == null) root.right = newNode;
                    else themDocGia(root.right, newNode);
                }
            }
        }
        public void xoaDocGia(int madg)
        {
            xoaDocGia(root, madg);
        }
        private Node_tree xoaDocGia(Node_tree root, int madg)
        {
            if (root == null) return root;
            if (madg < root.data.MADG) root.left = xoaDocGia(root.left, madg);
            else if (madg > root.data.MADG) root.right = xoaDocGia(root.right, madg);
            else
            {
                if(root.left == null && root.right == null)
                {
                    root = null;
                }
                else if(root.left != null && root.right != null)
                {
                    var maxNode = findMax(root.right);
                    root.data = maxNode.data;
                    root.right = xoaDocGia(root.right, maxNode.data.MADG);
                }
                else
                {
                    var child = root.left != null ? root.left : root.right;
                    root = child;
                }
            }
            return root;
        }
        private Node_tree findMax(Node_tree node)
        {
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
        }
        public void themSachMuon(int madg, string sach)
        {
            Node_tree node = timDocGia(root, madg);
            if(node != null)
            {
                node.data.SachDangMuon.Add(sach);
            }
        }
        private Node_tree timDocGia(Node_tree node, int madg)
        {
            Node_tree result;
            if (madg < node.data.MADG)
            {
                result = timDocGia(node.left, madg);
            }
            else if (madg > node.data.MADG)
            {
                result = timDocGia(node.right, madg);
            }
            else result = node;
            return result;
        }
        public void hieuChinhDocGia(int madg, docGia newValue)
        {
            Node_tree current = timDocGia(root, madg);
            current.data = newValue;
        }
        public void hienThiDanhSachDocGia_inorder()
        {
            if (root == null) return;
            Console.WriteLine("Danh sach doc gia: ");
            hienThiDanhSachDocGia_inorder(root);
        }
        private void hienThiDanhSachDocGia_inorder(Node_tree node)
        {
            if(node != null)
            {
                hienThiDanhSachDocGia_inorder(node.left);
                Console.WriteLine("Ma doc gia: " + node.data.MADG + ", Ho ten: " + node.data.ho + " " + node.data.ten + ", Phai: " + node.data.phai + ", Trang thai: " + node.data.trangThaiThe);
                //Console.WriteLine("Sach dang muon: ");
                //foreach(string sach in node.data.SachDangMuon)
                //{
                //    Console.Write(sach + " ");
                //}
                hienThiDanhSachDocGia_inorder(node.right);
            }
        }
    }
}
