
namespace doikieuchu
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKQ = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(149, 13);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(179, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad1.Location = new System.Drawing.Point(32, 69);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(99, 21);
            this.rad1.TabIndex = 2;
            this.rad1.TabStop = true;
            this.rad1.Text = "chữ thường";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad2.Location = new System.Drawing.Point(32, 96);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(108, 21);
            this.rad2.TabIndex = 3;
            this.rad2.TabStop = true;
            this.rad2.Text = "CHỮ IN HOA";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn kiểu chữ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(253, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 72);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(16, 141);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(90, 23);
            this.btnKQ.TabIndex = 6;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(149, 142);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(179, 22);
            this.txtKQ.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 176);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

