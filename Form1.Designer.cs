namespace PhanBaoTrung_Buoi3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_cd = new TextBox();
            btn_nhap = new Button();
            txt_cr = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_mssv = new TextBox();
            label4 = new Label();
            txt_hoten = new TextBox();
            label5 = new Label();
            txt_ns = new TextBox();
            label6 = new Label();
            txt_sdt = new TextBox();
            label7 = new Label();
            txt_gt = new TextBox();
            label8 = new Label();
            btn_nhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 73);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Chiều Dài";
            // 
            // txt_cd
            // 
            txt_cd.Location = new Point(170, 65);
            txt_cd.Name = "txt_cd";
            txt_cd.Size = new Size(112, 23);
            txt_cd.TabIndex = 1;
            // 
            // btn_nhap
            // 
            btn_nhap.Location = new Point(150, 178);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(75, 23);
            btn_nhap.TabIndex = 2;
            btn_nhap.Text = "Nhập";
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // txt_cr
            // 
            txt_cr.Location = new Point(170, 124);
            txt_cr.Name = "txt_cr";
            txt_cr.Size = new Size(112, 23);
            txt_cr.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 132);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Chiều Rộng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(480, 35);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 5;
            label3.Text = "Sinh Viên";
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(480, 73);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.Size = new Size(112, 23);
            txt_mssv.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 81);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Mã SV";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(480, 116);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(112, 23);
            txt_hoten.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 124);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Họ Tên";
            // 
            // txt_ns
            // 
            txt_ns.Location = new Point(480, 157);
            txt_ns.Name = "txt_ns";
            txt_ns.Size = new Size(112, 23);
            txt_ns.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 165);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 10;
            label6.Text = "Ngày Sinh";
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(480, 201);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(112, 23);
            txt_sdt.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 209);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 12;
            label7.Text = "SĐT";
            // 
            // txt_gt
            // 
            txt_gt.Location = new Point(480, 247);
            txt_gt.Name = "txt_gt";
            txt_gt.Size = new Size(112, 23);
            txt_gt.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 255);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 14;
            label8.Text = "Giới Tính";
            // 
            // btn_nhan
            // 
            btn_nhan.Location = new Point(517, 319);
            btn_nhan.Name = "btn_nhan";
            btn_nhan.Size = new Size(75, 23);
            btn_nhan.TabIndex = 16;
            btn_nhan.Text = "Nhập";
            btn_nhan.UseVisualStyleBackColor = true;
            btn_nhan.Click += btn_nhan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(btn_nhan);
            Controls.Add(txt_gt);
            Controls.Add(label8);
            Controls.Add(txt_sdt);
            Controls.Add(label7);
            Controls.Add(txt_ns);
            Controls.Add(label6);
            Controls.Add(txt_hoten);
            Controls.Add(label5);
            Controls.Add(txt_mssv);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_cr);
            Controls.Add(label2);
            Controls.Add(btn_nhap);
            Controls.Add(txt_cd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_cd;
        private Button btn_nhap;
        private TextBox txt_cr;
        private Label label2;
        private Label label3;
        private TextBox txt_mssv;
        private Label label4;
        private TextBox txt_hoten;
        private Label label5;
        private TextBox txt_ns;
        private Label label6;
        private TextBox txt_sdt;
        private Label label7;
        private TextBox txt_gt;
        private Label label8;
        private Button btn_nhan;
    }
}
