using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Xử lý khi nút nhấn đăng nhập được nhấn(hiện thông báo)
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhập");
            MessageBox.Show(txtUser.Text);
            MessageBox.Show(txtPass.Text);
        }
        //Xử lý khi nút nhấn dừng được nhấn(hiện thông báo)
        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Thoát hả?", "Hỏi lại", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (kq == DialogResult.OK) Application.Exit();
        }
        //Xử lý khi nút nhấn xóa được nhấn (xóa hết các giá trị ở text box)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }
    }
}
