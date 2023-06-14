using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuoi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Đếm số từ trong txtHoTen
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string s = txtHoTen.Text.Trim();
            for (int i = 0; i < s.Length - 1; i++)
                if ((s.Substring(i, 1) == " ") && (s.Substring(i + 1, 1) != " "))
                    count++;
            if (s.Length > 0) count++;
            lblKQ.Text = "Số từ là: " + count;
        }
        //đổi thành chữ Hoa Đầu Từ cho chuỗi txtHoTen
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
        //lấy ra từ bên trái của chuỗi txtHoTen
        private void button2_Click(object sender, EventArgs e)
        {
            string s = txtHoTen.Text.Trim();
            if (s.Length == 0) lblKQ.Text = "Chuỗi rỗng!";
            else
            {
                lblKQ.Text = "Từ đầu tiên của chuỗi là: ";
                lblKQ.Text += s.Substring(0, s.IndexOf(" "));
            }
        }
        // lấy ra từ bên phải của chuỗi txtHoTen
        private void button5_Click(object sender, EventArgs e)
        {
            string s = txtHoTen.Text.Trim();
            if (s.Length == 0) lblKQ.Text = "Chuỗi rỗng!";
            else
            {
                lblKQ.Text = "Từ đầu tiên của chuỗi là: ";
                lblKQ.Text += s.Substring(s.LastIndexOf(" ") + 1, s.Length - s.LastIndexOf("")-1);
            }
        }
        //Xóa
        private void button3_Click(object sender, EventArgs e)
        {
            txtHoTen.ResetText();
            lblKQ.Text = "";
            txtHoTen.Focus();
        }
        //Dừng chương trình
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
