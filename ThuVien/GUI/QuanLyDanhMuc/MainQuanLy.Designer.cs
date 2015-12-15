namespace ThuVien.GUI.QuanLyDanhMuc
{
    partial class MainQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnNXB = new System.Windows.Forms.Button();
            this.btnTacGia = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnDocGia);
            this.panel1.Controls.Add(this.btnNXB);
            this.panel1.Controls.Add(this.btnTacGia);
            this.panel1.Controls.Add(this.btnTheLoai);
            this.panel1.Controls.Add(this.btnSach);
            this.panel1.Location = new System.Drawing.Point(9, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(7, 246);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(112, 41);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Location = new System.Drawing.Point(7, 199);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(112, 41);
            this.btnDocGia.TabIndex = 4;
            this.btnDocGia.Text = "Quản Lý Độc Giả";
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnNXB
            // 
            this.btnNXB.Location = new System.Drawing.Point(7, 152);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(112, 41);
            this.btnNXB.TabIndex = 3;
            this.btnNXB.Text = "Quản Lý Nhà Xuất Bản";
            this.btnNXB.UseVisualStyleBackColor = true;
            this.btnNXB.Click += new System.EventHandler(this.btnNXB_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Location = new System.Drawing.Point(7, 105);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(112, 41);
            this.btnTacGia.TabIndex = 2;
            this.btnTacGia.Text = "Quản Lý Tác Giả";
            this.btnTacGia.UseVisualStyleBackColor = true;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Location = new System.Drawing.Point(7, 58);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(112, 41);
            this.btnTheLoai.TabIndex = 1;
            this.btnTheLoai.Text = "Quản Lý Thể Loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(7, 11);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(112, 41);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "Quản Lý Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(152, 9);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(866, 511);
            this.panelMain.TabIndex = 1;
            // 
            // MainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainQuanLy";
            this.Size = new System.Drawing.Size(1033, 533);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnTacGia;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnNXB;
    }
}
