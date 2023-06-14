using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace except
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ham xu ly ngoai le.
        private void button1_Click(object sender, EventArgs e)
        {
            txtKQ.ResetText();
            try
            {
                int so1 = int.Parse(txtSo1.Text);
                int so2 = int.Parse(txtSo2.Text);
                txtKQ.Text += (float)so1 / so2;
            }
            catch (Exception ex) // Xử lý ngoại lệ
            {
                txtKQ.Text = "Lỗi rồi!";
            }
        }
    }
}
