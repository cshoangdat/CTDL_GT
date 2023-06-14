using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_list_App
{
    public partial class Form1 : Form
    {
        //Định nghĩa Node trong single linked List và circular linked list 
        public class singleNode {
            public int element;
            public singleNode next;
            public singleNode(int e, singleNode n){
                element = e;
                next = n;
            }
        }
        //Định nghĩa node cho doubly Linked List
        public class doublyNode
        {
            public int element;
            public doublyNode next;
            public doublyNode prev;
            public doublyNode(int e, doublyNode n, doublyNode p)
            {
                element = e;
                next = n;
                prev = p;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        //Khởi tạo class single linked list
        public class single_linkedList
        {
            public singleNode head;
            public singleNode tail;
            public int size;
            //Khởi tạo single Linked list
            public single_linkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public bool isempty()
            {
                return size == 0;
            }
            //Thêm phần tử vào cuối singlelinked List
            public void addLast(int e)
            {
                singleNode newest = new singleNode(e, null);
                if (isempty())
                {
                    head = newest;
                }
                else
                {
                    tail.next = newest;
                }
                tail = newest;
                size = size + 1;
            }
            //Thêm phần tử vào đầu single linked list
            public void addFirst(int e)
            {
                singleNode newest = new singleNode(e,null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head = newest;
                }
                size += 1;
            }
            //Them vao vi tri bat ki cua List
            public void addAny(int e, int position)
            {
                if(position < 0 || position > size)
                {
                    MessageBox.Show("Nhap lai gia tri vi tri","Nhap lai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                singleNode newest = new singleNode(e, null);
                singleNode p = head;
                int i = 0;
                while(i < position - 1){
                    p = p.next;
                    i++;
                }
                newest.next = p.next;
                p.next = newest;
                size = size + 1;
            }
            //Xoa phan tu dau
            public int removeFirst()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                else
                {
                    int e = head.element;
                    head = head.next;
                    size = size - 1;
                    result = e;
                }
                return result;
            }
            //Xoa phan tu cuoi
            public int removeLast()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                else
                {
                    singleNode p = head;
                    int i = 1;
                    while(i < size - 1)
                    {
                        p = p.next;
                        i++;
                    }
                    tail = p;
                    p = p.next;
                    int e = p.element;
                    tail.next = null;
                    size = size - 1;
                    result = e;
                }
                return result;
            }
            //Xoa phan tu tai vi tri bat ki
            public int removeAny(int position)
            {
                int result = 0;
                if (position <= 0 || position >= size)
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                singleNode p = head;
                int i = 0;
                while (i < position - 1)
                {
                    p = p.next;
                    i += 1;
                }
                int e = p.next.element;
                p.next = p.next.next;
                size = size - 1;
                return result;
            }
            //Tìm kiếm phần tử trong single linked List
            public int search(int key)
            {
                int result = -1;
                singleNode p = head;
                int index = 0;
                while (p != null)
                {
                    if (p.element == key)
                    {
                        result = index;
                    }
                    p = p.next;
                    index = index + 1;
                }
                if(result == -1) MessageBox.Show($"Khong ton tai gia tri {key} trong list", "No Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        //Khởi tạo class circular linked list
        public class circular_linkedList
        {
            public singleNode head;
            public singleNode tail;
            public int size;
            public circular_linkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            //Thêm phần tử vào cuối circular linked list
            public void addLast(int e)
            {
                singleNode newest = new singleNode(e, null);
                if (isEmpty())
                {
                    newest.next = newest;
                    head = newest;
                    tail = newest;
                }
                else
                {
                    tail.next = newest;
                    tail = newest;
                    newest.next = head;
                }
                size = size + 1;
            }
            //Thêm phần tử vào đầu circular linked list
            public void addFirst(int e)
            {
                singleNode newest = new singleNode(e, null);
                if (isEmpty())
                {
                    newest.next = newest;
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head = newest;
                    tail.next = head;
                }
                size = size + 1;
            }
            //Thêm phần tử vào vị trí bất kỳ của circular linked list
            public void addAny(int e, int pos)
            {
                singleNode newest = new singleNode(e, null);
                if (pos < 0 || pos > size)
                {
                    MessageBox.Show("Nhap lai gia tri vi tri", "Nhap lai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                singleNode p = head;
                int i = 0;
                while (i < pos - 1)
                {
                    p = p.next;
                    i++;
                }
                newest.next = p.next;
                p.next = newest;
                tail.next = head;
                size = size + 1;
            }
            //Bỏ phần tử đầu của circular linked list
            public int removeFirst()
            {
                int result = 0;
                if (isEmpty())
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                else
                {
                    int e = head.element;
                    head = head.next;
                    tail.next = head;
                    size = size - 1;
                    result = e;
                }
                return result;
            }
            //Bỏ phần tử cuối của circular linked list
            public int removeLast()
            {
                int result = 0;
                if (isEmpty())
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                else
                {
                    singleNode p = head;
                    int i = 1;
                    while (i < size - 1)
                    {
                        p = p.next;
                        i++;
                    }
                    tail = p;
                    p = p.next;
                    int e = p.element;
                    tail.next = null;
                    tail.next = head;
                    size = size - 1;
                    result = e;
                }
                return result;
            }
            //Bỏ phần tử ở vị trí bất kỳ của circular linked list
            public int removeAny(int position)
            {
                int result = 0;
                if (position <= 0 || position >= size)
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                singleNode p = head;
                int i = 0;
                while (i < position - 1)
                {
                    p = p.next;
                    i += 1;
                }
                int e = p.next.element;
                p.next = p.next.next;
                tail.next = head;
                size = size - 1;
                return result;
            }
            //Tìm kiếm phần tử trong circular linked list
            public int search(int key)
            {
                int result = -1;
                singleNode p = head;
                int index = 0;
                while (index <size)
                {
                    if (p.element == key)
                    {
                        result = index;
                    }
                    p = p.next;
                    index = index + 1;
                }
                if (result == -1) MessageBox.Show($"Khong ton tai gia tri {key} trong list", "No Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        //Khởi tạo class doubly linked list
        public class doubly_linkedList
        {
            public doublyNode head;
            public doublyNode tail;
            public int size;
            public doubly_linkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public bool isempty()
            {
                return size == 0;
            }
            //Thêm phần tử vào vị trí cuối của doubly linked list
            public void addLast(int e)
            {
                doublyNode newest = new doublyNode(e, null, null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    tail.next = newest;
                    newest.prev = tail;
                    tail = newest;
                }
                size = size + 1;
            }
            //Thêm phần tử vào vị trí đầu của doubly linked list
            public void addFirst(int e)
            {
                doublyNode newest = new doublyNode(e, null, null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head.prev = newest;
                    head = newest;
                }
                size = size + 1;
            }
            //Thêm phần tử vào vị trí bất kỳ của doubly linked list
            public void addAny(int e, int pos)
            {
                doublyNode newest = new doublyNode(e, null, null);
                if (pos < 0 || pos > size)
                {
                    MessageBox.Show("Nhap lai gia tri vi tri", "Nhap lai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    doublyNode p = head;
                    int i = 1;
                    while (i < pos - 1)
                    {
                        p = p.next;
                        i++;
                    }
                    newest.next = p.next;
                    p.next.prev = newest;
                    p.next = newest;
                    newest.prev = p;
                    size = size + 1;
                }
            }
            //Bỏ phần tử ở vị trí đầu của doubly linked list
            public int removeFirst()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                else
                {
                    result = head.element;
                    head = head.next;
                    head.prev = null;
                    size = size - 1;
                }
                return result;
            }
            //Bỏ phần tử ở vị trí cuối của doubly linked list
            public int removeLast()
            {

                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                else
                {
                    result = tail.element;
                    doublyNode p = head;
                    int i = 1;
                    while (i < size - 1)
                    {
                        p = p.next;
                        i++;
                    }
                    tail = p;
                    p.next = null;
                    size = size - 1;
                }
                return result;
            }
            //Bỏ phần tử ở vị trí bất kỳ của doubly linked list
            public int removeAny(int pos)
            {
                int result = 0;
                if (pos <= 0 || pos >= size)
                {
                    MessageBox.Show("Mang rong", "Trong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    result = -1;
                }
                doublyNode p = head;
                int i = 1;
                while (i < pos - 1)
                {
                    p = p.next;
                    i++;
                }
                result = p.next.element;
                p.next = p.next.next;
                p.next.prev = p;
                size = size - 1;
                return result;
            }
            //tìm kiếm phần tử trong doubly linked list
            public int search(int key)
            {
                int result = -1;
                doublyNode p = head;
                int index = 0;
                while (index < size)
                {
                    if (p.element == key)
                    {
                        result = index;
                    }
                    p = p.next;
                    index = index + 1;
                }
                if (result == -1) MessageBox.Show($"Khong ton tai gia tri {key} trong list", "No Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        //Khởi tạo các linked list
        single_linkedList l = new single_linkedList();
        circular_linkedList circularList = new circular_linkedList();
        doubly_linkedList doublyList = new doubly_linkedList();
        //Khi khởi tạo các nút nhấn đều không hoạt động trừ 3 nút nhấn chọn loại linked list bao gồm single linked list, circular linked list, doubly linked list
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button14.Enabled = false;
        }
        //Thêm phần tử vào đầu linked list khi nhấn nút add first dựa vào lựa chọn loại linked list
        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if(button11.Enabled == true)
            {
                l.addFirst(num);
            }
            if (button12.Enabled == true)
            {
                circularList.addFirst(num);
            }
            if (button13.Enabled == true)
            {
                doublyList.addFirst(num);
            }
            textBox1.ResetText();
            textBox1.Focus();
        }
        //Thêm phần tử vào cuối linked list khi nhấn nút add Last dựa vào lựa chọn loại linked list
        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if (button11.Enabled == true)
            {
                l.addLast(num);
            }
            if (button12.Enabled == true)
            {
                circularList.addLast(num);
            }
            if (button13.Enabled == true)
            {
                doublyList.addLast(num);
            }
            textBox1.ResetText();
            textBox1.Focus();
        }
        //Hiện thị các phần tử có trong list khi nhấn nút display dựa vào lựa chọn loại linked list
        private void button3_Click(object sender, EventArgs e)
        {
            if (button11.Enabled == true)
            {
                singleNode p = l.head;
                lblKQ.Text = "Single Linked list chua cac phan tu: ";
                while (p != null)
                {
                    lblKQ.Text += p.element;
                    lblKQ.Text += " ";
                    p = p.next;
                }
            }
            if (button12.Enabled == true)
            {
                singleNode p = circularList.head;
                lblKQ.Text = "Circular linked list chua cac phan tu: ";
                int i = 0;
                while (i < circularList.size)
                {
                    lblKQ.Text += p.element;
                    lblKQ.Text += " ";
                    p = p.next;
                    i++;
                }
            }
            if (button13.Enabled == true)
            {
                doublyNode p = doublyList.head;
                lblKQ.Text = "Doubly linked list chua cac phan tu: ";
                while (p!=null)
                {
                    lblKQ.Text += p.element;
                    lblKQ.Text += " ";
                    p = p.next;
                }
            }
        }
        //Thoát ứng dụng khi nhấn nút close
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Xóa các giá trị linked list khi nhấn nút delete dựa vào lựa chọn loại linked list
        private void button4_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            textBox1.Focus();
            if (button11.Enabled == true)
            {
                l.size = 0;
                l.head = null;
                l.tail = null;
            }
            if (button12.Enabled == true)
            {
                circularList.size = 0;
                circularList.head = null;
                circularList.tail = null;
            }
            if (button13.Enabled == true)
            {
                doublyList.size = 0;
                doublyList.head = null;
                doublyList.tail = null;
            }
        }
        //Thêm giá trị vào vị trí người dùng nhập vào tại textBox2 của List khi nhấn vào nút Add Any dựa vào lựa chọn loại linked list
        private void button10_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int pos = Convert.ToInt32(textBox2.Text);
            if (button11.Enabled == true)
            {
                l.addAny(num, pos);
            }
            if (button12.Enabled == true)
            {
                circularList.addAny(num, pos);
            }
            if (button13.Enabled == true)
            {
                doublyList.addAny(num, pos);
            }
            textBox1.ResetText();
            textBox1.Focus();
            textBox2.ResetText();
        }
        //Xóa vị trí đầu tiên của List khi nhấn nút remove first dựa vào lựa chọn loại linked list
        private void button8_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (button11.Enabled == true)
            {
                num = l.removeFirst();
            }
            if (button12.Enabled == true)
            {
                num = circularList.removeFirst();
            }
            if (button13.Enabled == true)
            {
                num = doublyList.removeFirst();
            }
            MessageBox.Show($"Da xoa phan tu dau la: {num} cua List", "Is Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Xóa vị trí cuối cùng của List khi nhấn nút remove last dựa vào lựa chọn loại linked list
        private void button7_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (button11.Enabled == true)
            {
                num = l.removeLast();
            }
            if (button12.Enabled == true)
            {
                num = circularList.removeLast();
            }
            if (button13.Enabled == true)
            {
                num = doublyList.removeLast();
            }
            MessageBox.Show($"Da xoa phan tu cuoi la: {num} cua List", "Is Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Xóa vị trí người dùng nhập vào tại textBox3 khi nhấn nút remove any dựa vào lựa chọn loại linked list
        private void button6_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(textBox3.Text);
            int num = 0;
            if (button11.Enabled == true)
            {
                num = l.removeAny(pos);
            }
            if (button12.Enabled == true)
            {
                num = circularList.removeAny(pos);
            }
            if (button13.Enabled == true)
            {
                num = doublyList.removeAny(pos);
            }
            textBox3.ResetText();
            MessageBox.Show($"Da xoa phan tu thu {pos} cua List", "Is Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Tìm vị trí của phần tử người dùng nhập vào khi nhấn nút search dựa vào lựa chọn loại linked list
        private void button9_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox4.Text);
            int num = 0;
            if (button11.Enabled == true)
            {
                num = l.search(key);
            }
            if (button12.Enabled == true)
            {
                num = circularList.search(key);
            }
            if (button13.Enabled == true)
            {
                num = doublyList.search(key);
            }
            textBox4.ResetText();
            MessageBox.Show($"{key} tai vi tri thu {num} cua List", "Searching", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Khi chọn single linked list thì circular linked list và doubly linked list sẽ bị disable cho đến khi người dùng bấm exit
        private void button11_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button13.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button14.Enabled = true;
        }
        //Khi chọn circular linked list thì single linked list và doubly linked list sẽ bị disable cho đến khi người dùng bấm exit
        private void button12_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button13.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button14.Enabled = true;
        }
        //Khi chọn doubly linked list thì circular linked list và single linked list sẽ bị disable cho đến khi người dùng bấm exit
        private void button13_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button14.Enabled = true;
        }
        //Khi bấm nút exit sẽ trở về trạng thái ban đầu chỉ có thể lựa chọn loại linked list còn các nút nhấn còn lại sẽ bị disable
        private void button14_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button14.Enabled = false;
            lblKQ.Text = "";
        }
    }
}
