
namespace Mang_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 9);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(166, 30);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 phần tử mảng";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKQ.Location = new System.Drawing.Point(12, 46);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(306, 95);
            this.lblKQ.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 157);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(116, 38);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(184, 9);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(134, 30);
            this.txtNhap.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(144, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(275, 157);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(116, 38);
            this.btnDung.TabIndex = 5;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(324, 78);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(67, 63);
            this.btnGiam.TabIndex = 6;
            this.btnGiam.Text = "Sắp xếp giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(324, 9);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(67, 63);
            this.btnTang.TabIndex = 7;
            this.btnTang.Text = "Sắp xếp tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 207);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
    }
}

