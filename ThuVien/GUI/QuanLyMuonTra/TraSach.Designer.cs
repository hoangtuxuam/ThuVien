namespace ThuVien.GUI.QuanLyMuonTra
{
    partial class TraSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.cbHuHong = new System.Windows.Forms.CheckBox();
            this.cbQuaHan = new System.Windows.Forms.CheckBox();
            this.btnTra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(264, 64);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(142, 20);
            this.txtMaPhieu.TabIndex = 0;
            this.txtMaPhieu.TextChanged += new System.EventHandler(this.textChange);
            this.txtMaPhieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NhapSo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Mượn";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(457, 62);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // cbHuHong
            // 
            this.cbHuHong.AutoSize = true;
            this.cbHuHong.Location = new System.Drawing.Point(41, 30);
            this.cbHuHong.Name = "cbHuHong";
            this.cbHuHong.Size = new System.Drawing.Size(69, 17);
            this.cbHuHong.TabIndex = 3;
            this.cbHuHong.Text = "Hư Hỏng";
            this.cbHuHong.UseVisualStyleBackColor = true;
            this.cbHuHong.CheckedChanged += new System.EventHandler(this.OnChangeHuHong);
            // 
            // cbQuaHan
            // 
            this.cbQuaHan.AutoSize = true;
            this.cbQuaHan.Enabled = false;
            this.cbQuaHan.Location = new System.Drawing.Point(41, 69);
            this.cbQuaHan.Name = "cbQuaHan";
            this.cbQuaHan.Size = new System.Drawing.Size(69, 17);
            this.cbQuaHan.TabIndex = 4;
            this.cbQuaHan.Text = "Quá Hạn";
            this.cbQuaHan.UseVisualStyleBackColor = true;
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(264, 370);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(139, 39);
            this.btnTra.TabIndex = 5;
            this.btnTra.Text = "Trả Sách";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHuHong);
            this.groupBox1.Controls.Add(this.cbQuaHan);
            this.groupBox1.Location = new System.Drawing.Point(539, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình Trạng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQuaHan);
            this.groupBox2.Controls.Add(this.lblHuHong);
            this.groupBox2.Controls.Add(this.lblGia);
            this.groupBox2.Controls.Add(this.lblTacGia);
            this.groupBox2.Controls.Add(this.lblTenSach);
            this.groupBox2.Location = new System.Drawing.Point(92, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(27, 34);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(35, 13);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "label2";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(27, 78);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(35, 13);
            this.lblTacGia.TabIndex = 1;
            this.lblTacGia.Text = "label3";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(27, 117);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(35, 13);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "label4";
            // 
            // lblHuHong
            // 
            this.lblHuHong.AutoSize = true;
            this.lblHuHong.Location = new System.Drawing.Point(27, 160);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(35, 13);
            this.lblHuHong.TabIndex = 3;
            this.lblHuHong.Text = "label5";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Location = new System.Drawing.Point(27, 199);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(35, 13);
            this.lblQuaHan.TabIndex = 4;
            this.lblQuaHan.Text = "label6";
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraSach";
            this.Size = new System.Drawing.Size(866, 511);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.CheckBox cbHuHong;
        private System.Windows.Forms.CheckBox cbQuaHan;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
    }
}
