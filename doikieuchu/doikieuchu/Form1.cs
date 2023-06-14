using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doikieuchu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khi nhấn nút Kết quả sẽ in họ và tên bằng kiểu chữ được chọn
        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text.Trim();
            if (rad1.Checked == true) txtKQ.Text = hoten.ToLower();
            if (rad2.Checked == true) txtKQ.Text = hoten.ToUpper();
        }
        //Xóa troogs các txt và rad1 và đưa trỏ vào ô txtHoTen
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtKQ.Clear();
            rad1.Checked = true;
            txtHoTen.Focus();
        }
    }
}
