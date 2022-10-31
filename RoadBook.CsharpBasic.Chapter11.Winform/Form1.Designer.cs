namespace RoadBook.CsharpBasic.Chapter11.Winform
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
            this.label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMenu01 = new System.Windows.Forms.Button();
            this.btnMenu02 = new System.Windows.Forms.Button();
            this.btnMenu03 = new System.Windows.Forms.Button();
            this.btnMenu04 = new System.Windows.Forms.Button();
            this.btnMenu05 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(36, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 23);
            this.label.TabIndex = 0;
            this.label.Text = "주문현황";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(40, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 394);
            this.listBox1.TabIndex = 1;
            // 
            // btnMenu01
            // 
            this.btnMenu01.Location = new System.Drawing.Point(203, 95);
            this.btnMenu01.Name = "btnMenu01";
            this.btnMenu01.Size = new System.Drawing.Size(121, 66);
            this.btnMenu01.TabIndex = 2;
            this.btnMenu01.Tag = "1";
            this.btnMenu01.Text = "김밥";
            this.btnMenu01.UseVisualStyleBackColor = true;
            this.btnMenu01.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu02
            // 
            this.btnMenu02.Location = new System.Drawing.Point(203, 197);
            this.btnMenu02.Name = "btnMenu02";
            this.btnMenu02.Size = new System.Drawing.Size(121, 66);
            this.btnMenu02.TabIndex = 3;
            this.btnMenu02.Tag = "2";
            this.btnMenu02.Text = "라면";
            this.btnMenu02.UseVisualStyleBackColor = true;
            this.btnMenu02.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu03
            // 
            this.btnMenu03.Location = new System.Drawing.Point(203, 289);
            this.btnMenu03.Name = "btnMenu03";
            this.btnMenu03.Size = new System.Drawing.Size(121, 66);
            this.btnMenu03.TabIndex = 4;
            this.btnMenu03.Tag = "3";
            this.btnMenu03.Text = "떡볶이";
            this.btnMenu03.UseVisualStyleBackColor = true;
            this.btnMenu03.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu04
            // 
            this.btnMenu04.Location = new System.Drawing.Point(203, 389);
            this.btnMenu04.Name = "btnMenu04";
            this.btnMenu04.Size = new System.Drawing.Size(121, 66);
            this.btnMenu04.TabIndex = 5;
            this.btnMenu04.Tag = "4";
            this.btnMenu04.Text = "순대";
            this.btnMenu04.UseVisualStyleBackColor = true;
            this.btnMenu04.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu05
            // 
            this.btnMenu05.Location = new System.Drawing.Point(203, 478);
            this.btnMenu05.Name = "btnMenu05";
            this.btnMenu05.Size = new System.Drawing.Size(121, 66);
            this.btnMenu05.TabIndex = 6;
            this.btnMenu05.Tag = "5";
            this.btnMenu05.Text = "공기밥";
            this.btnMenu05.UseVisualStyleBackColor = true;
            this.btnMenu05.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(453, 138);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(212, 138);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "결제하기";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPaymentInfo.Location = new System.Drawing.Point(460, 351);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(193, 30);
            this.lblPaymentInfo.TabIndex = 8;
            this.lblPaymentInfo.Text = "결제전입니다";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(936, 996);
            this.Controls.Add(this.lblPaymentInfo);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnMenu05);
            this.Controls.Add(this.btnMenu04);
            this.Controls.Add(this.btnMenu03);
            this.Controls.Add(this.btnMenu02);
            this.Controls.Add(this.btnMenu01);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMenu01;
        private System.Windows.Forms.Button btnMenu02;
        private System.Windows.Forms.Button btnMenu03;
        private System.Windows.Forms.Button btnMenu04;
        private System.Windows.Forms.Button btnMenu05;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblPaymentInfo;
    }
}

