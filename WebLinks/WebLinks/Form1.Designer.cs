
namespace WebLinks
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
            this.lstWeb = new System.Windows.Forms.ListBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstWeb
            // 
            this.lstWeb.FormattingEnabled = true;
            this.lstWeb.ItemHeight = 16;
            this.lstWeb.Items.AddRange(new object[] {
            "Tuổi trẻ",
            "Thanh niên",
            "VNExPress",
            "Dân Trí",
            "Công An",
            "Google",
            "Yahoo"});
            this.lstWeb.Location = new System.Drawing.Point(32, 63);
            this.lstWeb.Name = "lstWeb";
            this.lstWeb.Size = new System.Drawing.Size(135, 84);
            this.lstWeb.TabIndex = 0;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(189, 63);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKQ.Size = new System.Drawing.Size(194, 128);
            this.txtKQ.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(33, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 38);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRst
            // 
            this.btnRst.Location = new System.Drawing.Point(103, 153);
            this.btnRst.Name = "btnRst";
            this.btnRst.Size = new System.Drawing.Size(64, 38);
            this.btnRst.TabIndex = 3;
            this.btnRst.Text = "Reset";
            this.btnRst.UseVisualStyleBackColor = true;
            this.btnRst.Click += new System.EventHandler(this.btnRst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liên kết website";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRst);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lstWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWeb;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRst;
        private System.Windows.Forms.Label label1;
    }
}

