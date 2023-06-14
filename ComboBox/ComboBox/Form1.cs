using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khi nút ok được nhấn sẽ hiện thị kết quả chọn trong combo Box.
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxWeb.SelectedItem != null)
                txtKq.Text = "Bạn đã chọn website " + comboBoxWeb.SelectedItem.ToString();
            else
                txtKq.Text = "Bạn chưa chọn mục nào";
        }
        //Khi bấm nút reset sẽ xóa kết quả hiện thị
        private void txtRst_Click(object sender, EventArgs e)
        {
            txtKq.ResetText();
        }
    }
}
