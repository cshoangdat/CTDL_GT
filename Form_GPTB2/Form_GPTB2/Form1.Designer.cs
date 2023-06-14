
namespace Form_GPTB2
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(142, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(428, 22);
            this.txtA.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(23, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(92, 34);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Nhập a:";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(23, 86);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(92, 34);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Nhập b:";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(142, 93);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(428, 22);
            this.txtB.TabIndex = 6;
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(23, 150);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(92, 34);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "Nhập c:";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(142, 157);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(428, 22);
            this.txtC.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(286, 216);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 59);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Bắt đầu giải";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(23, 289);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(0, 20);
            this.lblKetqua.TabIndex = 10;
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.Location = new System.Drawing.Point(23, 332);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(0, 20);
            this.lblX1.TabIndex = 11;
            this.lblX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(23, 377);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(0, 20);
            this.lblX2.TabIndex = 12;
            this.lblX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
    }
}

