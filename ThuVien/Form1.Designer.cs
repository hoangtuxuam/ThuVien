﻿namespace ThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTra = new System.Windows.Forms.Button();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.quanLyNhanVien1 = new ThuVien.GUI.QuanLyDanhMuc.QuanLyNhanVien();
            this.panelChucNang.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChucNang
            // 
            this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChucNang.Controls.Add(this.btnBaocao);
            this.panelChucNang.Controls.Add(this.btnTimKiem);
            this.panelChucNang.Controls.Add(this.btnQuanLyMuonTra);
            this.panelChucNang.Controls.Add(this.btnQuanLyDanhMuc);
            this.panelChucNang.Location = new System.Drawing.Point(13, 13);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(120, 636);
            this.panelChucNang.TabIndex = 0;
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaocao.Location = new System.Drawing.Point(10, 340);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(100, 100);
            this.btnBaocao.TabIndex = 3;
            this.btnBaocao.Text = "BÁO CÁO";
            this.btnBaocao.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiem.Location = new System.Drawing.Point(10, 230);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 100);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyMuonTra
            // 
            this.btnQuanLyMuonTra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLyMuonTra.Location = new System.Drawing.Point(10, 120);
            this.btnQuanLyMuonTra.Name = "btnQuanLyMuonTra";
            this.btnQuanLyMuonTra.Size = new System.Drawing.Size(100, 100);
            this.btnQuanLyMuonTra.TabIndex = 1;
            this.btnQuanLyMuonTra.Text = "QUẢN LÍ MƯỢN TRẢ SÁCH";
            this.btnQuanLyMuonTra.UseVisualStyleBackColor = false;
            this.btnQuanLyMuonTra.Click += new System.EventHandler(this.btnQuanLyMuonTra_Click);
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(10, 10);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(100, 100);
            this.btnQuanLyDanhMuc.TabIndex = 0;
            this.btnQuanLyDanhMuc.Text = "QUẢN LÍ DANH MỤC";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = false;
            // 
            // panelBanner
            // 
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Location = new System.Drawing.Point(139, 12);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1033, 98);
            this.panelBanner.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.quanLyNhanVien1);
            this.panelMain.Location = new System.Drawing.Point(139, 116);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1033, 533);
            this.panelMain.TabIndex = 2;
            // 
            // quanLyNhanVien1
            // 
            this.quanLyNhanVien1.Location = new System.Drawing.Point(3, 5);
            this.quanLyNhanVien1.Name = "quanLyNhanVien1";
            this.quanLyNhanVien1.Size = new System.Drawing.Size(866, 511);
            this.quanLyNhanVien1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.panelChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelChucNang.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQuanLyMuonTra;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private GUI.QuanLyDanhMuc.QuanLyNhanVien quanLyNhanVien1;
    }
}
