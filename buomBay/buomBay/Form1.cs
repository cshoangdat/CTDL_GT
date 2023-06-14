using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buomBay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Đặt tọa độ đầu tiên cho bướm
        int x = 5;
        int y = 2;
        //Khi timer bật nếu pic1 sẽ di chuyển và chạm cạnh thì sẽ bật lại
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic1.Bottom >= this.ClientSize.Height) y = -y;
            if (pic1.Top <= 0) y = -y;
            if (pic1.Left <= 0) x = -x;
            if (pic1.Right >= this.ClientSize.Width) x = -x;
            pic1.Left += x;
            pic1.Top += y;
        }
        //Khi bấm nút bắt đầu thì kích hoạt timer, dừng sẽ ngắt timer
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                btn.Text = "DỪNG";
            }
            else
            {
                timer1.Enabled = false;
                btn.Text = "BẮT ĐẦU";
            }
        }
    }
}
