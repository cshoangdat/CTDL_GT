using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int i = 10;

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = i.ToString();
            i--;
            if (i < 0) timer1.Enabled = false;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
