using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chucmungnammoi
{
    public partial class Form1 : Form
    {
        string str = "CHÚC MỪNG NĂM MỚI - HAPPY NEW YEAR";
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //khi nhấn btn Chạy sẽ kích hoạt timer, khi nhấn btn dừng sẽ ngắt timer.
        private void btnDungChay_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnDungChay.Text = "CHẠY";
            }
            else
            {
                timer1.Enabled = true;
                btnDungChay.Text = "DỪNG";
            }
        }
        //Khi nhấn thoát sẽ thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //khi timer kích hoạt các chữ sẽ xuất hiện lần lượt.
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblChucMung.Text = str.Substring(0, i);
            i++;
            if (i > str.Length) i = 0;
        }
    }
}
