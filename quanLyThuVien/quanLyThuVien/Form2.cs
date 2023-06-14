using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyThuVien
{
    public partial class Form2 : Form
    {
        public string LabelValue { get; set; }
        public void UpdateLabelValue(string value)
        {
            lblKQ.Text = value;
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
