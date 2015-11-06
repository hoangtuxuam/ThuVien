namespace ThuVien.GUI.BaoCao
{
    partial class DocGia
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
            this.pnlChon = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxDocGia = new System.Windows.Forms.CheckBox();
            this.cbxSachNhap = new System.Windows.Forms.CheckBox();
            this.cbxSachMuon = new System.Windows.Forms.CheckBox();
            this.grvBaoCao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHienBaoCao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlChon.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChon
            // 
            this.pnlChon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlChon.Controls.Add(this.label3);
            this.pnlChon.Controls.Add(this.cbxSachMuon);
            this.pnlChon.Controls.Add(this.cbxSachNhap);
            this.pnlChon.Controls.Add(this.cbxDocGia);
            this.pnlChon.Location = new System.Drawing.Point(41, 42);
            this.pnlChon.Name = "pnlChon";
            this.pnlChon.Size = new System.Drawing.Size(781, 70);
            this.pnlChon.TabIndex = 1;
            this.pnlChon.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grvBaoCao);
            this.panel1.Location = new System.Drawing.Point(41, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 333);
            this.panel1.TabIndex = 2;
            // 
            // cbxDocGia
            // 
            this.cbxDocGia.AutoSize = true;
            this.cbxDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDocGia.Location = new System.Drawing.Point(56, 33);
            this.cbxDocGia.Name = "cbxDocGia";
            this.cbxDocGia.Size = new System.Drawing.Size(103, 28);
            this.cbxDocGia.TabIndex = 0;
            this.cbxDocGia.Text = "Độc Giả";
            this.cbxDocGia.UseVisualStyleBackColor = true;
            // 
            // cbxSachNhap
            // 
            this.cbxSachNhap.AutoSize = true;
            this.cbxSachNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSachNhap.Location = new System.Drawing.Point(326, 33);
            this.cbxSachNhap.Name = "cbxSachNhap";
            this.cbxSachNhap.Size = new System.Drawing.Size(132, 28);
            this.cbxSachNhap.TabIndex = 1;
            this.cbxSachNhap.Text = "Sách Nhập";
            this.cbxSachNhap.UseVisualStyleBackColor = true;
            // 
            // cbxSachMuon
            // 
            this.cbxSachMuon.AutoSize = true;
            this.cbxSachMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSachMuon.Location = new System.Drawing.Point(600, 33);
            this.cbxSachMuon.Name = "cbxSachMuon";
            this.cbxSachMuon.Size = new System.Drawing.Size(135, 28);
            this.cbxSachMuon.TabIndex = 2;
            this.cbxSachMuon.Text = "Sách Mượn";
            this.cbxSachMuon.UseVisualStyleBackColor = true;
            // 
            // grvBaoCao
            // 
            this.grvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBaoCao.Location = new System.Drawing.Point(38, 51);
            this.grvBaoCao.Name = "grvBaoCao";
            this.grvBaoCao.Size = new System.Drawing.Size(703, 270);
            this.grvBaoCao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Báo Cáo";
            // 
            // btnHienBaoCao
            // 
            this.btnHienBaoCao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHienBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienBaoCao.Location = new System.Drawing.Point(41, 128);
            this.btnHienBaoCao.Name = "btnHienBaoCao";
            this.btnHienBaoCao.Size = new System.Drawing.Size(139, 41);
            this.btnHienBaoCao.TabIndex = 3;
            this.btnHienBaoCao.Text = "Hiện Báo Cáo";
            this.btnHienBaoCao.UseVisualStyleBackColor = false;
            this.btnHienBaoCao.Click += new System.EventHandler(this.btnHienBaoCao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tích chọn nội dung cần báo cáo";
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnHienBaoCao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChon);
            this.Name = "DocGia";
            this.Size = new System.Drawing.Size(866, 511);
            this.pnlChon.ResumeLayout(false);
            this.pnlChon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChon;
        private System.Windows.Forms.CheckBox cbxSachMuon;
        private System.Windows.Forms.CheckBox cbxSachNhap;
        private System.Windows.Forms.CheckBox cbxDocGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grvBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHienBaoCao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
