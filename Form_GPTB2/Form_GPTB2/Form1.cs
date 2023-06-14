using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_GPTB2
{
    public partial class Form1 : Form
    {
        double a, b, c;
        double delta;
        double x1, x2;
        //₫ịnh nghĩa hàm nhập 3 thông số a,b,c của phương trình bậc 2
        void NhapABC()
        {
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            c = Double.Parse(txtC.Text);
        }
        //₫ịnh nghĩa hàm tính nghiệm của phương trình bậc 2
        void GiaiPT()
        {
            //tính biệt số delta của phương trình
            delta = b * b - 4 * a * c;
            if (delta >= 0)
            { //nếu có nghiệm thực
                x1 = (-b + Math.Sqrt(delta)) / 2 / a;
                x2 = (-b - Math.Sqrt(delta)) / 2 / a;
            }
        }
        //₫ịnh nghĩa hàm xuất kết quả
        void XuatKetqua()
        {
            if (delta < 0)
            {
                //báo vô nghiệm
                lblKetqua.Text = "Phương trình vô nghiệm";
                lblX1.Text = "";
                lblX2.Text = "";
            }
            else
            { //báo có 2 nghiệm
                lblKetqua.Text = "Phương trình có 2 nghiệm thực : ";
                lblX1.Text = "X1 = " + x1.ToString();
                lblX2.Text = "X2 = " + x2.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
            //xóa nội dung ban ₫ầu của các Label kết quả
            lblKetqua.Text = lblX1.Text = lblX2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NhapABC(); //nhập a,b,c
            GiaiPT(); //giải phương trình
            XuatKetqua(); //xuất kết quả
        }
    }
}
