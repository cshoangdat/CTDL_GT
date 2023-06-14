
namespace Mảng
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
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKQ.Location = new System.Drawing.Point(12, 48);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(423, 71);
            this.lblKQ.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 133);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(129, 33);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(157, 133);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(306, 133);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(129, 33);
            this.btnDung.TabIndex = 3;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 199);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblKQ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
    }
}

