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
            this.SuspendLayout();
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(264, 64);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(142, 20);
            this.txtMaPhieu.TabIndex = 0;
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
            this.cbHuHong.Location = new System.Drawing.Point(264, 121);
            this.cbHuHong.Name = "cbHuHong";
            this.cbHuHong.Size = new System.Drawing.Size(69, 17);
            this.cbHuHong.TabIndex = 3;
            this.cbHuHong.Text = "Hư Hỏng";
            this.cbHuHong.UseVisualStyleBackColor = true;
            // 
            // cbQuaHan
            // 
            this.cbQuaHan.AutoSize = true;
            this.cbQuaHan.Enabled = false;
            this.cbQuaHan.Location = new System.Drawing.Point(264, 169);
            this.cbQuaHan.Name = "cbQuaHan";
            this.cbQuaHan.Size = new System.Drawing.Size(69, 17);
            this.cbQuaHan.TabIndex = 4;
            this.cbQuaHan.Text = "Quá Hạn";
            this.cbQuaHan.UseVisualStyleBackColor = true;
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(266, 241);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(139, 39);
            this.btnTra.TabIndex = 5;
            this.btnTra.Text = "Trả Sách";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.cbQuaHan);
            this.Controls.Add(this.cbHuHong);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaPhieu);
            this.Name = "TraSach";
            this.Size = new System.Drawing.Size(866, 511);
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
    }
}
