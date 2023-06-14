using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaiPtBacNhat
{
    public partial class Form1 : Form
    {
        double c, b;
        //Hàm nhập 2 giá trị b,c
        //Hàm giải pt bậc 2 kq là c/b báo lỗi khi a,b không chia được với nhau
        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                double kq = c / b;
                txtKQ.Text = kq.ToString();
            }
            catch (Exception ex) // Xử lý ngoại lệ
            {
                txtKQ.Text = "Lỗi rồi!";
            }
        }
        //Khi nhấn nút xóa sẽ xóa hết text box
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtB.Clear();
            txtC.Clear();
            txtKQ.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
