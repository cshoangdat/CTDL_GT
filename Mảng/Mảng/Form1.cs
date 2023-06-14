using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mảng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khi nhấn nút in sẽ in ra mảng ở label Kết quả.
        private void btnIn_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            lblKQ.Text = "Các phần tử trong mảng là:\n\r";
            for (int i = 0; i < arr.Length; i++) lblKQ.Text += arr[i] + " ";
        }
        //Xóa nội dung hiện thị ở label Kết quả
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "";
        }
        //Nhấn nút dừng thoát
        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
