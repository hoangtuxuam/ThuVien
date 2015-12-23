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
            this.lblDoiMK = new System.Windows.Forms.Label();
            this.lblThoat = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
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
            resources.ApplyResources(this.panelChucNang, "panelChucNang");
            this.panelChucNang.Name = "panelChucNang";
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnBaocao, "btnBaocao");
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.UseVisualStyleBackColor = false;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnQuanLyMuonTra
            // 
            this.btnQuanLyMuonTra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnQuanLyMuonTra, "btnQuanLyMuonTra");
            this.btnQuanLyMuonTra.Name = "btnQuanLyMuonTra";
            this.btnQuanLyMuonTra.UseVisualStyleBackColor = false;
            this.btnQuanLyMuonTra.Click += new System.EventHandler(this.btnQuanLyMuonTra_Click);
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnQuanLyDanhMuc, "btnQuanLyDanhMuc");
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = false;
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackgroundImage = global::ThuVien.Properties.Resources.Banner;
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Controls.Add(this.lblDoiMK);
            this.panelBanner.Controls.Add(this.lblThoat);
            resources.ApplyResources(this.panelBanner, "panelBanner");
            this.panelBanner.Name = "panelBanner";
            // 
            // lblDoiMK
            // 
            resources.ApplyResources(this.lblDoiMK, "lblDoiMK");
            this.lblDoiMK.Name = "lblDoiMK";
            this.lblDoiMK.Click += new System.EventHandler(this.lblDoiMK_Click);
            // 
            // lblThoat
            // 
            resources.ApplyResources(this.lblThoat, "lblThoat");
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.panelChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
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

