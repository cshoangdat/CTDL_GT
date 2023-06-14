using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mang_2
{
    public partial class Form1 : Form
    {
        int[] arr = new int[5];
        int sopt = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //Hàm nhập khi click vào sẽ đưa giá trị trong txtNhap vào mảng, khi mảng đủ 5 số thì thông báo
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (sopt == 5) MessageBox.Show("Mảng đã đầy!");
            else
            {
                arr[sopt] = Convert.ToInt32(txtNhap.Text);
                sopt++;
                txtNhap.ResetText();
                txtNhap.Focus();
            }
        }
        //Hàm in ra kết quả các phần tử của mảng
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (sopt == 0) lblKQ.Text = "Mảng rỗng!";
            else
            {
                lblKQ.Text = "Các phần tử trong mảng là:\n\r";
                for (int i = 0; i < sopt; i++) lblKQ.Text = lblKQ.Text + arr[i] + " ";
            }
        }
        //Xóa sẽ xóa lblKQ và khai báo lại số phần tử là 0
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            sopt = 0;
            txtNhap.Focus();
        }
        //Thoát
        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Xắp sếp mảng tăng dần
        private void btnTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0) lblKQ.Text = "Mảng rỗng!";
            else Array.Sort(arr, 0, sopt);
            lblKQ.Text = "Đã sắp xếp mảng tăng dần!";
        }
        //Sắp xếp mảng giảm dần
        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0) lblKQ.Text = "Mảng rỗng!";
            else Array.Reverse(arr, 0, sopt);
            lblKQ.Text = "Đã sắp xếp mảng giảm dần!";
        }
    }
}
