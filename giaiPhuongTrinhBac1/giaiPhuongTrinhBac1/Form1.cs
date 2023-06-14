using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaiPhuongTrinhBac1
{
    public partial class Form1 : Form
    {
        double a, b;
        //tạo giá trị nhập vào là dạng double
        void nhap()
        {
            a = double.Parse(txtsSo1.Text);
            b = double.Parse(txtsSo2.Text);
        }
        //hàm cộng
        void sum()
        {
            double kq = a + b;
            txtKQ.Text = kq.ToString();
        }
        //hàm trừ
        void sub()
        {
            double kq = a - b;
            txtKQ.Text = kq.ToString();
        }
        //hàm nhân
        void mul()
        {
            double kq = a * b;
            txtKQ.Text = kq.ToString();
        }
        //hàm chia
        void div()
        {
            if (b != 0)
            {
                double kq = a / b;
                txtKQ.Text = kq.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi không thể chia cho 0");
                txtsSo2.Clear();
                txtsSo2.Focus();
            }
        }
        //Ban đầu xóa hết text ở text box.
        public Form1()
        {
            InitializeComponent();
            txtsSo1.Text = txtsSo2.Text = txtKQ.Text = "";
        }
        //Xử lý khi nhấn cộng trừ nhân chia
        private void btnCong_Click(object sender, EventArgs e)
        {
            nhap();
            sum();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            nhap();
            sub();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            nhap();
            mul();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            nhap();
            div();
        }
        //Xử lý khi nhấn nút xoá
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtsSo1.Clear();
            txtsSo2.Clear();
            txtKQ.Clear();
        }
        //Xử lý khi nút Dừng được nhấn
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Thoát hả?", "Hỏi lại", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (kq == DialogResult.OK) Application.Exit();
        }

        private void txtsSo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
