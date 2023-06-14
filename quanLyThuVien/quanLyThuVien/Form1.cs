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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtisbn.Enabled = false;
            txtBookName.Enabled = false;
            txtTenTG.Enabled = false;
            txtnamXB.Enabled = false;
            txtSLSach.Enabled = true;
            txtBookNum.Enabled = false;
            comboBoxSachState.Enabled = false;
            button1.Enabled = false;
            btnBack.Enabled = false;
            txtTheLoai.Enabled = false;
            button3.Enabled = false;
        }
        danhSachDocGia danhSachDocGia = new danhSachDocGia();
        private void addDG_Click(object sender, EventArgs e)
        {

            danhSachDocGia.themDocGia(new docGia()
            {
                ho = txtHoDG.Text,
                ten = txtTenDG.Text,
                phai = GenderSelect.SelectedItem.ToString(),
                trangThaiThe = Convert.ToInt32(comboBoxState.SelectedIndex.ToString())
            }
            );
            txtHoDG.ResetText();
            txtTenDG.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            danhSachDocGia.hienThiDanhSachDocGia_inorder(form2);
            form2.Show();
        }

        private void delDG_Click(object sender, EventArgs e)
        {
            int madg = Convert.ToInt32(txtmaDG.Text);
            danhSachDocGia.xoaDocGia(madg);
            txtmaDG.ResetText();
        }

        private void editDG_Click(object sender, EventArgs e)
        {
            int madg = Convert.ToInt32(txtmaDG.Text);
            danhSachDocGia.hieuChinhDocGia(madg, new docGia() {
                MADG = madg,
                ho = txtHoDG.Text,
                ten = txtTenDG.Text,
                phai = GenderSelect.SelectedItem.ToString(),
                trangThaiThe = Convert.ToInt32(comboBoxState.SelectedIndex.ToString())
            });
            txtmaDG.ResetText();
        }
        dauSach dauSach;

        private void button1_Click_1(object sender, EventArgs e)
        {
            dauSach.themSach(new sach()
            {
                ISBN = txtisbn.Text,
                tenSach = txtBookName.Text,
                soTrang = Convert.ToInt32(txtBookNum.Text),
                tacGia = txtTenTG.Text,
                namXB = Convert.ToInt32(txtnamXB.Text),
                theLoai = txtTheLoai.Text,
                trangThaiSach = Convert.ToInt32(comboBoxSachState.SelectedIndex.ToString())
            });
            txtisbn.ResetText();
            txtBookName.ResetText();
            txtBookNum.ResetText();
            txtTenTG.ResetText();
            txtnamXB.ResetText();
            txtTheLoai.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soLuongSach = Convert.ToInt32(txtSLSach.Text);
            dauSach = new dauSach(soLuongSach);
            txtisbn.Enabled = true;
            txtBookName.Enabled = true;
            txtTenTG.Enabled = true;
            txtnamXB.Enabled = true;
            txtSLSach.Enabled = false;
            txtBookNum.Enabled = true;
            comboBoxSachState.Enabled = true;
            button1.Enabled = true;
            btnBack.Enabled = true;
            button2.Enabled = false;
            txtTheLoai.Enabled = true;
            button3.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            txtisbn.Enabled = false;
            txtBookName.Enabled = false;
            txtTenTG.Enabled = false;
            txtnamXB.Enabled = false;
            txtSLSach.Enabled = true;
            txtBookNum.Enabled = false;
            comboBoxSachState.Enabled = false;
            button1.Enabled = false;
            btnBack.Enabled = false;
            txtTheLoai.Enabled = false;
            button3.Enabled = false;
            txtisbn.ResetText();
            txtBookName.ResetText();
            txtBookNum.ResetText();
            txtTenTG.ResetText();
            txtnamXB.ResetText();
            txtTheLoai.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            dauSach.hienThiDS(form3);
            form3.ShowDialog();
        }
    }
}
