
namespace chucmungnammoi
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
            this.components = new System.ComponentModel.Container();
            this.lblChucMung = new System.Windows.Forms.Label();
            this.btnDungChay = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblChucMung
            // 
            this.lblChucMung.BackColor = System.Drawing.Color.Yellow;
            this.lblChucMung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucMung.ForeColor = System.Drawing.Color.Red;
            this.lblChucMung.Location = new System.Drawing.Point(13, 13);
            this.lblChucMung.Name = "lblChucMung";
            this.lblChucMung.Size = new System.Drawing.Size(580, 110);
            this.lblChucMung.TabIndex = 0;
            // 
            // btnDungChay
            // 
            this.btnDungChay.Location = new System.Drawing.Point(177, 142);
            this.btnDungChay.Name = "btnDungChay";
            this.btnDungChay.Size = new System.Drawing.Size(93, 29);
            this.btnDungChay.TabIndex = 1;
            this.btnDungChay.Text = "Chạy";
            this.btnDungChay.UseVisualStyleBackColor = true;
            this.btnDungChay.Click += new System.EventHandler(this.btnDungChay_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(340, 142);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 29);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 202);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDungChay);
            this.Controls.Add(this.lblChucMung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChucMung;
        private System.Windows.Forms.Button btnDungChay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Timer timer1;
    }
}

