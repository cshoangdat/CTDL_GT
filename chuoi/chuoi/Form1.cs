using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hàm so sánh 2 chuỗi có phân biệt hoa, thường
        private void btnCompare_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;
            int kq = string.Compare(s1, s2); //So sánh, có phân biệt hoa thường
            lblKQ.Text = "txtS1 ";
            if (kq == -1) lblKQ.Text += "<";
            else if (kq == 0) lblKQ.Text += "=";
            else lblKQ.Text += ">";
            lblKQ.Text += " txtS2";
        }
        //Hàm so sánh 2 chuỗi không phân biệt hoa, thường
        private void btn_COMPARE_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;
            int kq = string.Compare(s1, s2, true);//Sosánh không phânbiệt thườnghoa
            lblKQ.Text = "txtS1 ";
            if (kq == -1) lblKQ.Text += "<";
            else if (kq == 0) lblKQ.Text += "=";
            else lblKQ.Text += ">";
            lblKQ.Text += " txtS2";
        }
        //Hàm nối chuỗi
        private void btnConcat_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;
            lblKQ.Text = string.Concat(s1, s2); // Nối chuỗi
        }
        //Cho biết vị trí chuỗi S2 trong chuỗi S1
        private void btnIndex_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;
            // Chỉ ra vị trí của chuỗi 2 trong chuỗi 1
            if (s1.IndexOf(s2) >= 0) lblKQ.Text = "txtS2 có trong txtS1 tại vị trí " + s1.IndexOf(s2);
            else lblKQ.Text = "txtS2 không xuất hiện trong txtS1!";
        }
        //Chèn chuỗi
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;
            lblKQ.Text += s1.Insert(s1.IndexOf(" "), s2); // Chèn chuỗi 2 vào sau từ đầu tiên của chuỗi 1
            //lblKQ.Text+=s1.Insert(s1.LastIndexOf(" "), s2); //Chèn chuỗi2 vào trước từ cuối của chuỗi1
        }
        //Hàm xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtS1.ResetText();
            txtS2.ResetText();
            lblKQ.Text = "";
            txtS1.Focus();
        }
    }
}
