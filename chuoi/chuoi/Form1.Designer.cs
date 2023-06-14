
namespace chuoi
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnConcat = new System.Windows.Forms.Button();
            this.btn_COMPARE = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(-24, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(442, 39);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CHƯƠNG TRÌNH XỬ LÝ CHUỖI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi thứ nhất";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(133, 55);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(254, 22);
            this.txtS1.TabIndex = 2;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(12, 279);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(121, 38);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chuỗi thứ hai";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(133, 104);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(254, 22);
            this.txtS2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết quả";
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKQ.ForeColor = System.Drawing.Color.White;
            this.lblKQ.Location = new System.Drawing.Point(13, 167);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(374, 91);
            this.lblKQ.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(266, 279);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 38);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(139, 279);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(121, 38);
            this.btnConcat.TabIndex = 10;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btn_COMPARE
            // 
            this.btn_COMPARE.Location = new System.Drawing.Point(12, 323);
            this.btn_COMPARE.Name = "btn_COMPARE";
            this.btn_COMPARE.Size = new System.Drawing.Size(121, 38);
            this.btn_COMPARE.TabIndex = 11;
            this.btn_COMPARE.Text = "COMPARE";
            this.btn_COMPARE.UseVisualStyleBackColor = true;
            this.btn_COMPARE.Click += new System.EventHandler(this.btn_COMPARE_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(139, 323);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(121, 38);
            this.btnIndex.TabIndex = 12;
            this.btnIndex.Text = "Index Of";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(266, 323);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 38);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 376);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btn_COMPARE);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btn_COMPARE;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnXoa;
    }
}

