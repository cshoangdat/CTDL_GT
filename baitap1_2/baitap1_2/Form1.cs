using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Đếm độ dài chuỗi và số lượng từ
        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            string s = txtHoTen.Text.Trim();
            for (int i = 0; i < s.Length - 1; i++)
                if ((s.Substring(i, 1) == " ") && (s.Substring(i + 1, 1) != " "))
                    count++;
            if (s.Length > 0) count++;
            lblKQ.Text = "Số từ là: " + count;
            lblKQ.Text += " và Đô dài là: " + txtHoTen.Text.Length;
        }
        //In ra chuỗi dạng thường
        private void button2_Click(object sender, EventArgs e)
        {
            string s = txtHoTen.Text.Trim();
            if (s.Length == 0) lblKQ.Text = "Chuỗi rỗng!";
            else
            {
                lblKQ.Text = "Chuỗi kết quả là: " + txtHoTen.Text.ToLower();
            }
        }
        //In ra chuỗi dạng in hoa
        private void button3_Click(object sender, EventArgs e)
        {
            string s = txtHoTen.Text.Trim();
            if (s.Length == 0) lblKQ.Text = "Chuỗi rỗng!";
            else
            {
                lblKQ.Text = "Chuỗi kết quả là: " + txtHoTen.Text.ToUpper();
            }
        }
        //In ra chuỗi có viết hoa đầu mỗi từ
        private void button4_Click(object sender, EventArgs e)
        {
            string s = txtHoTen.Text.Trim();
            if (s.Length == 0) lblKQ.Text = "Chuỗi rỗng!";
            else
            {
                lblKQ.Text = "Chuỗi kết quả là: ";
                lblKQ.Text += s.Substring(0, 1).ToUpper();
                for (int i = 1; i < s.Length; i++)
                {
                    if ((s[i - 1].ToString() == " ") && (s[i].ToString() != " "))
                    {
                        string ss = s[i].ToString();
                        lblKQ.Text += ss.ToUpper();
                    }
                    else lblKQ.Text += s[i].ToString();
                }
            }
        }
        //làm mất dấu khoảng cách
        private void button5_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Chuỗi kết quả là: " + txtHoTen.Text.Replace(" ","");
        }
    }
}
