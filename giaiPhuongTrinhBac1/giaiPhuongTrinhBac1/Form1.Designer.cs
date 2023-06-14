
namespace giaiPhuongTrinhBac1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsSo1 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thứ nhất:";
            // 
            // txtsSo1
            // 
            this.txtsSo1.Location = new System.Drawing.Point(179, 56);
            this.txtsSo1.Name = "txtsSo1";
            this.txtsSo1.Size = new System.Drawing.Size(278, 22);
            this.txtsSo1.TabIndex = 1;
            this.txtsSo1.TextChanged += new System.EventHandler(this.txtsSo1_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(12, 247);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(57, 33);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số thứ hai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả là:";
            // 
            // txtsSo2
            // 
            this.txtsSo2.Location = new System.Drawing.Point(179, 117);
            this.txtsSo2.Name = "txtsSo2";
            this.txtsSo2.Size = new System.Drawing.Size(278, 22);
            this.txtsSo2.TabIndex = 5;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(179, 181);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(278, 22);
            this.txtKQ.TabIndex = 6;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(85, 247);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(57, 33);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(165, 247);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(57, 33);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(246, 247);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(57, 33);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(360, 247);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 33);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dừng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtsSo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtsSo1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsSo1;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
    }
}

