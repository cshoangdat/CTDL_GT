
namespace graph_app
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
            this.dfsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bfsBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.findTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dfsBtn
            // 
            this.dfsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dfsBtn.Location = new System.Drawing.Point(216, 12);
            this.dfsBtn.Name = "dfsBtn";
            this.dfsBtn.Size = new System.Drawing.Size(90, 41);
            this.dfsBtn.TabIndex = 0;
            this.dfsBtn.Text = "DFS";
            this.dfsBtn.UseVisualStyleBackColor = true;
            this.dfsBtn.Click += new System.EventHandler(this.dfsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn thuật toán tìm kiếm: ";
            // 
            // bfsBtn
            // 
            this.bfsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfsBtn.Location = new System.Drawing.Point(312, 12);
            this.bfsBtn.Name = "bfsBtn";
            this.bfsBtn.Size = new System.Drawing.Size(90, 41);
            this.bfsBtn.TabIndex = 2;
            this.bfsBtn.Text = "BFS";
            this.bfsBtn.UseVisualStyleBackColor = true;
            this.bfsBtn.Click += new System.EventHandler(this.bfsBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findBtn.Location = new System.Drawing.Point(298, 194);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(104, 29);
            this.findBtn.TabIndex = 8;
            this.findBtn.Text = "Tìm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findTxt
            // 
            this.findTxt.Location = new System.Drawing.Point(144, 200);
            this.findTxt.Name = "findTxt";
            this.findTxt.Size = new System.Drawing.Size(148, 22);
            this.findTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đỉnh cần tìm kiếm:";
            // 
            // txtKq
            // 
            this.txtKq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtKq.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKq.Location = new System.Drawing.Point(12, 65);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(390, 111);
            this.txtKq.TabIndex = 9;
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Location = new System.Drawing.Point(298, 229);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 29);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 264);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.findTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bfsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dfsBtn);
            this.Name = "Form1";
            this.Text = "GRAPH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dfsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bfsBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox findTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtKq;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

