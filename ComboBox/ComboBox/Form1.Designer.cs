
namespace ComboBox
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
            this.comboBoxWeb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRst = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liên kết website";
            // 
            // comboBoxWeb
            // 
            this.comboBoxWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeb.FormattingEnabled = true;
            this.comboBoxWeb.Items.AddRange(new object[] {
            "Tuổi trẻ",
            "Thanh Niên",
            "VNExpress",
            "Dân Trí",
            "Công An",
            "Google",
            "Yahoo"});
            this.comboBoxWeb.Location = new System.Drawing.Point(51, 43);
            this.comboBoxWeb.Name = "comboBoxWeb";
            this.comboBoxWeb.Size = new System.Drawing.Size(145, 24);
            this.comboBoxWeb.TabIndex = 1;
            this.comboBoxWeb.Text = "Liên Kết Website";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRst
            // 
            this.txtRst.Location = new System.Drawing.Point(283, 43);
            this.txtRst.Name = "txtRst";
            this.txtRst.Size = new System.Drawing.Size(75, 23);
            this.txtRst.TabIndex = 3;
            this.txtRst.Text = "Reset";
            this.txtRst.UseVisualStyleBackColor = true;
            this.txtRst.Click += new System.EventHandler(this.txtRst_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(51, 74);
            this.txtKq.Multiline = true;
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(307, 152);
            this.txtKq.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 238);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtRst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxWeb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWeb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtRst;
        private System.Windows.Forms.TextBox txtKq;
    }
}

