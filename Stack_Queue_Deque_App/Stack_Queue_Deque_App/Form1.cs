using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Queue_Deque_App
{
    public partial class Form1 : Form
    {
        //-------------------------------------------Stack với Array-------------------------------------------
        public class stack_array
        {
            //Khởi tạo mảng với stack
            public int[] data;
            public int top;
            public stack_array(int n)
            {
                data = new int[n];
                top = 0;
            }
            public int length()
            {
                return top;
            }
            public bool isempty()
            {
                return top == 0;
            }
            public bool isfull()
            {
                return top == data.Length;
            }
            //Thêm phần tử vào cuối Stack(Array)
            public void push(int e)
            {
                if (isfull())
                {
                    MessageBox.Show("Stack is full !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    data[top] = e;
                    top = top + 1;
                }
            }
            // loại bỏ phần tử cuối stack(Array)
            public int pop()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Stack is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = data[top - 1];
                    top = top - 1;
                }
                return result;
            } 
            //lấy giá trị cuối của stack(Array)
            public int peek()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Stack is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = data[top - 1];
                }
                return result;
            }
        }
        //-------------------------------------------Stack với Linked List-------------------------------------------
        //Định nghĩa Node cho Linked List
        public class Node
        {
            public int element;
            public Node next;
            public Node(int e, Node n)
            {
                element = e;
                next = n;
            }
        }
        //khởi tạo linked list với stack
        public class stack_linkedList
        {
            public int size;
            public Node top;
            public stack_linkedList()
            {
                size = 0;
                top = null;
            }
            public bool isempty()
            {
                return size == 0;
            }
            //Thêm phần tử vào cuối Stack(Linked List)
            public void push(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    top = newest;
                }
                else
                {
                    newest.next = top;
                    top = newest;
                }
                size = size + 1;
            }
            // loại bỏ phần tử cuối stack(Linked List)
            public int pop()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Stack is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = top.element;
                    top = top.next;
                    size = size - 1;
                }
                return result;
            }
            //lấy giá trị cuối của stack(Linked List)
            public int peek()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Stack is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = top.element;
                }
                return result;
            }
        }
        //-------------------------------------------Queue với Array-------------------------------------------
        //Khởi tạo array với queue
        public class queue_array
        {
            public int[] data;
            public int front;
            public int rear;
            public int size;
            public queue_array(int n)
            {
                data = new int[n];
                front = 0;
                size = 0;
                rear = 0;
            }
            public bool isempty()
            {
                return size == 0;
            }
            public int length()
            {
                return size;
            }
            public bool isfull()
            {
                return size == data.Length;
            }
            //Thêm phần tử vào cuối queue(Array)
            public void enqueue(int e)
            {
                if (isfull())
                {
                    MessageBox.Show("Queue is full !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    data[rear] = e;
                    rear = rear + 1;
                    size = size + 1;
                }
            }
            // loại bỏ phần tử đầu queue(Array)
            public int dequeue()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Queue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = data[front];
                    front = front + 1;
                    size = size - 1;
                }
                return result;
            }
            // Lấy giá trị đầu của queue(Array)
            public int first()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Queue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else result = data[front];
                return result;
            }
        }
        //-------------------------------------------Queue với Linked List-------------------------------------------
        //Khởi tạo Linked List với queue
        public class queue_linkedList
        {
            public Node front = null;
            public Node rear = null;
            public int size = 0;
            public bool isempty()
            {
                return size == 0;
            }
            //Thêm phần tử vào cuối queue(Linked List)
            public void enQueue(int e) 
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    front = newest;
                    rear = newest;
                }
                else
                {
                    rear.next = newest;
                    rear = newest;
                }
                size = size + 1;
            }
            // loại bỏ phần tử đầu queue(Linked List)
            public int deQueue() 
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Queue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = front.element;
                    front = front.next;
                }
                size = size - 1;
                return result;
            }
            //lấy giá trị đầu của queue(Linked List)
            public int first()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Queue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = front.element;
                }
                return result;
            }
        }
        //-------------------------------------------Deque với Array-------------------------------------------
        //Khởi tạo array với deque
        public class deque_array
        {
            public int[] data;
            public int front;
            public int rear;
            public int size;
            public deque_array(int n)
            {
                data = new int[n];
                front = 0;
                rear = 0;
                size = 0;
            }
            public bool isempty()
            {
                return size == 0;
            }
            public bool isfull()
            {
                return size == data.Length;
            }
            //Thêm phần tử vào cuối deque(Array)
            public void addLast(int e)
            {
                if (isfull())
                {
                    MessageBox.Show("Deque is full !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rear = size;
                    data[rear] = e;
                    rear = rear + 1;
                    size = size + 1;
                }
            }
            //Thêm phần tử vào đầu deque(Array)
            public void addFirst(int e)
            {
                if (isfull())
                {
                    MessageBox.Show("Deque is full !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Array.Copy(data, front, data, front + 1, size);
                    data[front] = e;
                    size = size + 1;
                }
            }
            // loại bỏ phần tử đầu deque(Array)
            public int removeFirst()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Deque is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = data[front];
                    Array.Copy(data, front + 1, data, front, size - 1);
                    size = size - 1;
                }
                return result;
            }
            // loại bỏ phần tử cuối deque(Array)
            public int removeLast()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("Deque is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = data[rear-1];
                    rear = rear - 1;
                    size = size - 1;
                }
                return result;
            }
            //Tìm kiếm phần tử trong deque(Array)
            public int seach(int key)
            {
                int result = -1;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] == key) result = i;
                }
                if(result == -1) MessageBox.Show($"Khong ton tai gia tri {key} trong list", "No Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
        }
        //-------------------------------------------Deque với Linked List-------------------------------------------
        //Khởi tạo linked list với deque
        public class deque_linkedList
        {
            public int size;
            public Node front;
            public Node rear;
            public bool isempty()
            {
                return size == 0;
            }
            public deque_linkedList()
            {
                front = null;
                rear = null;
                size = 0;
            }
            //Thêm phần tử vào cuối deque(linked list)
            public void addLast(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    front = newest;
                    rear = newest;
                }
                else
                {
                    rear.next = newest;
                    rear = newest;
                }
                size = size + 1;
            }
            //Thêm phần tử vào đầu deque(linked list)
            public void addFirst(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    front = newest;
                    rear = newest;
                }
                else
                {
                    newest.next = front;
                    front = newest;
                }
                size = size + 1;
            }
            // loại bỏ phần tử đầu deque(linked list)
            public int removeFirst()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("DeQue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    result = front.element;
                    front = front.next;
                    size = size - 1;
                }
                return result;
            }
            // loại bỏ phần tử cuối deque(linked list)
            public int removeLast()
            {
                int result = 0;
                if (isempty())
                {
                    MessageBox.Show("DeQue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = -1;
                }
                else
                {
                    Node p = front;
                    for(int i = 1;i<size - 1; i++)
                    {
                        p = p.next;
                    }
                    result = p.next.element;
                    rear = p;
                    rear.next = null;
                    size = size - 1;
                }
                return result;
            }
            //Tìm kiếm phần tử trong deque(linked list)
            public int search(int key)
            {
                int result = -1;
                Node p = front;
                int i = 0;
                while(p!= null)
                {
                    if (p.element == key) result = i;
                    p = p.next;
                    i++;
                }
                if (result == -1) MessageBox.Show($"Khong ton tai gia tri {key} trong list", "No Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }
        }
        //-------------------------------------------Build App-------------------------------------------
        //Khởi tạo form 1 ban đầu chỉ có 3 nút có thể nhấn để lựa chọn là stack hoặc queue hoặc deque
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        public const int arrLen = 0;
        private stack_array stackArr;
        private stack_linkedList stackLinkedList = new stack_linkedList();
        private queue_array queueArr;
        private queue_linkedList queueLinkedList = new queue_linkedList();
        private deque_array dequeArr;
        private deque_linkedList dequeLinkedList = new deque_linkedList();
        //Khi stack được chọn thì các nút chức năng liên quan sẽ kích hoạt và tắt các nút không liên quan
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button20.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button21.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
        //Khi array được chọn sẽ kiểm tra tiếp đang chọn ở stack hay queue hay deque để thực hiện
        private void button4_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == true)
            {
                button5.Enabled = false;
                textBox1.Enabled = true;
                textBox3.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button19.Enabled = true;
            }
            if (button2.Enabled == true)
            {
                button5.Enabled = false;
                textBox1.Enabled = true;
                textBox3.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button19.Enabled = true;
                button6.Enabled = true;
            }
            if (button3.Enabled == true)
            {
                button5.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button6.Enabled = true;
            }
        }
        //Đối với mảng sẽ định trước số lượng phần tử trong mảng và khởi tạo mảng với số lượng phần tử nhập vào text box 1.
        private void button6_Click(object sender, EventArgs e)
        {
            int arrLen = Convert.ToInt32(textBox1.Text);
            if (button1.Enabled == true)
            {
                stackArr = new stack_array(arrLen);
                button6.Enabled = false;
                textBox1.Enabled = false;
            }
            if(button2.Enabled == true)
            {
                queueArr = new queue_array(arrLen);
                button6.Enabled = false;
                textBox1.Enabled = false;
            }
            if (button3.Enabled == true)
            {
                dequeArr = new deque_array(arrLen);
                button6.Enabled = false;
                textBox1.Enabled = false;
            }
        }
        //Với stack khi nhấn nut push sẽ thêm phần tử vào.
        private void button7_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            if(button4.Enabled == true)
            {
                stackArr.push(num);
            }
            if (button5.Enabled == true)
            {
                stackLinkedList.push(num);
            }
            textBox3.ResetText();
            textBox3.Focus();
        }
        //Hiện thị ra màn hình kết quả khi nhấn nút display
        private void button19_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == true)
            {
                if(button4.Enabled == true)
                {
                    label5.Text = $"Stack Array có chiều dài: {stackArr.length()} \n";
                    label5.Text += "Gồm các phần tử: ";
                    for (int i = 0; i< stackArr.top; i++)
                    {
                        label5.Text += Convert.ToString(stackArr.data[i]) + " ";
                    }
                }
                if(button5.Enabled == true)
                {
                    label5.Text = "Stack linked list gồm các phần tử: ";
                    Node p = stackLinkedList.top;
                    while(p != null)
                    {
                        label5.Text += p.element;
                        label5.Text += " ";
                        p = p.next;
                    }
                }
            }
            if (button2.Enabled == true)
            {
                if (button4.Enabled == true)
                {
                    label5.Text = $"Queue Array có chiều dài: {queueArr.length()} \n";
                    label5.Text += "Gồm các phần tử: ";
                    for (int i = queueArr.front ; i < queueArr.rear; i++)
                    {
                        label5.Text += Convert.ToString(queueArr.data[i]) + " ";
                    }
                }
                if (button5.Enabled == true)
                {
                    label5.Text = "Queue linked list gồm các phần tử: ";
                    Node p = queueLinkedList.front;
                    while (p != null)
                    {
                        label5.Text += p.element;
                        label5.Text += " ";
                        p = p.next;
                    }
                }
            }
            if(button3.Enabled == true)
            {
                if (button4.Enabled == true)
                {
                    label5.Text = $"Deque Array có chiều dài: {dequeArr.size} \n";
                    label5.Text += "Gồm các phần tử: ";
                    for (int i = 0; i < dequeArr.size; i++)
                    {
                        label5.Text += Convert.ToString(dequeArr.data[i]) + " ";
                    }
                }
                if (button5.Enabled == true)
                {
                    label5.Text = "Deque linked list gồm các phần tử: ";
                    Node p = dequeLinkedList.front;
                    while (p != null)
                    {
                        label5.Text += p.element;
                        label5.Text += " ";
                        p = p.next;
                    }
                }
            }
        }
        //Loại bỏ phần tử trong stack khi nhấn nút pop
        private void button8_Click(object sender, EventArgs e)
        {
           int num = 0;
           if(button4.Enabled == true)
           {
                num = stackArr.pop();
                MessageBox.Show($"Đã loại bỏ phần tử {num} của stack Array", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           if (button5.Enabled == true)
           {
               num = stackLinkedList.pop();
               MessageBox.Show($"Đã loại bỏ phần tử {num} của stack linked list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }
        //Lấy phần tử đầu trong stack ra bằng peek
        private void button9_Click(object sender, EventArgs e)
        {
            int num = 0;
            if(button4.Enabled == true)
            {
                num = stackArr.peek();
                MessageBox.Show($"phần tử đầu của stack Array là: {num}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button5.Enabled == true)
            {
                num = stackLinkedList.peek();
                MessageBox.Show($"Phần tử đầu của stack linked list là: {num}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Khi nhấn nút exit sẽ thoát khỏi chế độ đang chọn và sẽ được chọn lại chế độ là queue hay stack hay deque
        int count = 0;
        private void button20_Click(object sender, EventArgs e)
        {
            count++;
            if(count == 1)
            {
                if(button4.Enabled == true)
                {
                    button5.Enabled = true;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button19.Enabled = false;
                    textBox1.ResetText();
                    textBox1.Enabled = false;
                    textBox3.Enabled = false;
                    label5.Text = "";
                }
                if(button5.Enabled == true)
                {
                    button4.Enabled = true;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button19.Enabled = false;
                    textBox1.ResetText();
                    textBox1.Enabled = false;
                    textBox3.Enabled = false;
                    label5.Text = "";
                }
                if (button4.Enabled == true && button5.Enabled == true)
                {
                    button5.Enabled = false;
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    count = 0;
                }
            }
            if(count == 2)
            {
                if (button4.Enabled == true && button5.Enabled == true)
                {
                    button5.Enabled = false;
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    count = 0;
                }
            }
        }
        //Khi loại lựa chọn là linked list sẽ kiểm tra tiếp đang ở chế độ queue hay stack hay deque
        private void button5_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == true)
            {
                textBox3.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button19.Enabled = true;
                button4.Enabled = false;
            }
            if (button2.Enabled == true)
            {
                textBox3.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button19.Enabled = true;
                button4.Enabled = false;
            }
            if (button3.Enabled == true)
            {
                textBox3.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button19.Enabled = true;
                button4.Enabled = false;
                textBox2.Enabled = true;
                button18.Enabled = true;
            }
        }
        //Khi Enqueue được chọn sẽ bật chức năng liên quan và tắt stack và deque đi
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button20.Enabled = true;
            button2.Enabled = true;;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button21.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
        //Khi chọn enqueue sẽ thêm phần tử vào queue
        private void button10_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            if (button4.Enabled == true)
            {
                queueArr.enqueue(num);
            }
            if (button5.Enabled == true)
            {
                queueLinkedList.enQueue(num);
            }
            textBox3.ResetText();
            textBox3.Focus();
        }
        //Khi chọn dequeue sẽ loại bỏ phần tử trong queue
        private void button11_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (button4.Enabled == true)
            {
                num = queueArr.dequeue();
                MessageBox.Show($"Đã loại bỏ phần tử {num} của Queue Linked List", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button5.Enabled == true)
            {
                num = queueLinkedList.deQueue();
                MessageBox.Show($"Đã loại bỏ phần tử {num} của Queue Linked List", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Khi chọn first sẽ lấy phần tử đầu của queue
        private void button12_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (button4.Enabled == true)
            {
                num = queueArr.first();
                MessageBox.Show($"phần tử đầu của Queue Linked List là: {num}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button5.Enabled == true)
            {
                num = queueLinkedList.first();
                MessageBox.Show($"phần tử đầu của Queue Linked List là: {num}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Khi chọn deque sẽ bật các chức năng liên quan và tắt stack và enqueue
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button20.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button21.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
        //Khi bấm add First sẽ thêm phần tử vào đầu deque
        private void button13_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            if (button4.Enabled == true)
            {
                dequeArr.addFirst(num);
            }
            if(button5.Enabled == true)
            {
                dequeLinkedList.addFirst(num);
            }
            textBox3.ResetText();
            textBox3.Focus();
        }
        //Khi bấm addLast sẽ thêm phần tử vào cuối deque
        private void button14_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            if (button5.Enabled == true) dequeLinkedList.addLast(num);
            if (button4.Enabled == true) dequeArr.addLast(num);
            textBox3.ResetText();
            textBox3.Focus();
        }
        //Khi bấm remove First sẽ loại bỏ phần tử ở đầu của deque
        private void button15_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (button4.Enabled == true) num = dequeArr.removeFirst();
            if (button5.Enabled == true) num = dequeLinkedList.removeFirst();
            MessageBox.Show($"Đã xoá phần tử đầu là: {num} của List", "Is Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Khi bấm remove Last sẽ loại bỏ phần tử ở cuối của deque
        private void button16_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (button4.Enabled == true) num = dequeArr.removeLast();
            if (button5.Enabled == true) num = dequeLinkedList.removeLast();
            MessageBox.Show($"Đã xoá phần tử cuối là: {num} của List", "Is Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Khi bấm seach sẽ tìm phần tử có trong deque không với giá trị nhập từ textbox2
        private void button18_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox2.Text);
            int num = 0;
            if (button4.Enabled == true) num = dequeArr.seach(key);
            if (button5.Enabled == true) num = dequeLinkedList.search(key);
            MessageBox.Show($"{key} tại ví trí thứ {num} của List", "Searching", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.ResetText();
            textBox2.Focus();
        }
        //Khi nhấn exit sẽ thoát app
        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
