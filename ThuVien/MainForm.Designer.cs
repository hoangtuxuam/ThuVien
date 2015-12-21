namespace ThuVien
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTra = new System.Windows.Forms.Button();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblThoat = new System.Windows.Forms.Label();
            this.lblDoiMK = new System.Windows.Forms.Label();
            this.panelChucNang.SuspendLayout();
            this.panelBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChucNang
            // 
            this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChucNang.Controls.Add(this.btnBaocao);
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
            this.btnBaocao.Location = new System.Drawing.Point(10, 226);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(100, 100);
            this.btnBaocao.TabIndex = 3;
            this.btnBaocao.Text = "BÁO CÁO";
            this.btnBaocao.UseVisualStyleBackColor = false;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
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
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackgroundImage = global::ThuVien.Properties.Resources.Banner;
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Controls.Add(this.lblDoiMK);
            this.panelBanner.Controls.Add(this.lblThoat);
            this.panelBanner.Location = new System.Drawing.Point(139, 12);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1033, 98);
            this.panelBanner.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(139, 116);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1033, 533);
            this.panelMain.TabIndex = 2;
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Location = new System.Drawing.Point(941, 6);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(58, 13);
            this.lblThoat.TabIndex = 3;
            this.lblThoat.Text = "Đăng Xuất";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // lblDoiMK
            // 
            this.lblDoiMK.AutoSize = true;
            this.lblDoiMK.Location = new System.Drawing.Point(941, 32);
            this.lblDoiMK.Name = "lblDoiMK";
            this.lblDoiMK.Size = new System.Drawing.Size(72, 13);
            this.lblDoiMK.TabIndex = 4;
            this.lblDoiMK.Text = "Đổi Mật Khẩu";
            this.lblDoiMK.Click += new System.EventHandler(this.lblDoiMK_Click);
            // 
            // MainForm
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ĐongChuongTrinh);
            this.panelChucNang.ResumeLayout(false);
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnQuanLyMuonTra;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Label lblDoiMK;
    }
}

