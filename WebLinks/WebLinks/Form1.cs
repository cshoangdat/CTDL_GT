using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebLinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstWeb.SelectedItem != null)
                txtKQ.Text = "Bạn đã chọn website " + lstWeb.SelectedItem.ToString();
            else
                txtKQ.Text = "Bạn chưa chọn mục nào";
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            txtKQ.ResetText();
        }
    }
}
