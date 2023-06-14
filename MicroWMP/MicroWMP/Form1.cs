using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroWMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tạo form duyệt chọn file cần chơi 
            OpenFileDialog dlg = new OpenFileDialog();
            //hiển thị form duyệt chọn file cần chơi 
            DialogResult ret = dlg.ShowDialog();
            //kiểm tra quyết ₫ịnh của người dùng, nếu người dùng chọn OK thì chơi 
            if (ret == DialogResult.OK)
                wmpPlay.URL = dlg.FileName;
        }

        private void wmpPlay_Enter(object sender, EventArgs e)
        {

        }

        private void wmpPlay_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int cx = this.Size.Width;
            int cy = this.Size.Height;
            //thay ₫ổi vị trí của ₫ối tượng WMP về vị trí mong muốn 
            wmpPlay.Location = new Point(10, 40);
            //thay ₫ổi kích thước của ₫ối tượng WMP theo kích thước Form 
            wmpPlay.Size = new Size(cx - 30, cy - 80);
        }
    }
}
